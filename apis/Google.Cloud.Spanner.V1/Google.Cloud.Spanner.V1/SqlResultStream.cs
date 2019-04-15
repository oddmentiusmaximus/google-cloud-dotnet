﻿// Copyright 2019 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.Cloud.Spanner.V1.Internal;
using Google.Rpc;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using static Google.Api.Gax.Grpc.RetrySettings;

namespace Google.Cloud.Spanner.V1
{
    /// <summary>
    /// Implements buffering, retry and resume for the results of executing streaming SQL calls.
    /// </summary>
    internal sealed class SqlResultStream : IAsyncEnumerator<PartialResultSet>
    {
        /// <summary>
        /// The default maximum buffer size. Currently this isn't user-tweakable; we don't expect to see more than this many
        /// responses without a resume token anyway.
        /// </summary>
        private const int DefaultMaxBufferSize = 512;
        // TODO: Validate that these make sense!
        private static readonly BackoffSettings s_defaultBackoffSettings = new BackoffSettings(TimeSpan.FromSeconds(1), TimeSpan.FromSeconds(15), 2.0);

        private readonly LinkedList<PartialResultSet> _buffer;
        private readonly SpannerClient _client;
        private readonly ExecuteSqlRequest _request;
        private readonly Session _session;
        private readonly CallSettings _callSettings;
        private readonly BackoffSettings _backoffSettings;
        private readonly IJitter _backoffJitter;
        private readonly int _maxBufferSize;

        /// <summary>
        /// Indicates whether the underlying stream has completed. We may still be draining results from the buffer.
        /// </summary>
        private bool _finished;
        private bool _safeToRetry = true;

        private AsyncServerStreamingCall<PartialResultSet> _grpcCall;

        /// <summary>
        /// Constructor for normal usage, with default buffer size, backoff settings and jitter.
        /// </summary>
        internal SqlResultStream(SpannerClient client, ExecuteSqlRequest request, Session session, CallSettings callSettings)
            : this(client, request, session, callSettings, DefaultMaxBufferSize, s_defaultBackoffSettings, RetrySettings.RandomJitter)
        {
        }

        /// <summary>
        /// Constructor with complete control, for testing purposes.
        /// </summary>
        internal SqlResultStream(
            SpannerClient client,
            ExecuteSqlRequest request,
            Session session,
            CallSettings callSettings,
            int maxBufferSize,
            BackoffSettings backoffSettings,
            IJitter backoffJitter)
        {
            _buffer = new LinkedList<PartialResultSet>();
            _client = GaxPreconditions.CheckNotNull(client, nameof(client));
            _request = GaxPreconditions.CheckNotNull(request, nameof(request));
            _session = GaxPreconditions.CheckNotNull(session, nameof(session));
            _callSettings = callSettings;
            _maxBufferSize = GaxPreconditions.CheckArgumentRange(maxBufferSize, nameof(maxBufferSize), 1, 10_000);
            _backoffSettings = GaxPreconditions.CheckNotNull(backoffSettings, nameof(backoffSettings));
            _backoffJitter = GaxPreconditions.CheckNotNull(backoffJitter, nameof(backoffJitter));
        }

        public PartialResultSet Current { get; private set; }

        public void Dispose()
        {
            _grpcCall?.Dispose();
            _grpcCall = null;
            _finished = true;
            _buffer.Clear();
        }

        public async Task<bool> MoveNext(CancellationToken cancellationToken)
        {
            var value = await ComputeNextAsync(cancellationToken).ConfigureAwait(false);
            Current = value;
            return value != null;
        }

        // See https://github.com/googleapis/google-cloud-java/blob/master/google-cloud-clients/google-cloud-spanner/src/main/java/com/google/cloud/spanner/SpannerImpl.java#L2674
        private async Task<PartialResultSet> ComputeNextAsync(CancellationToken cancellationToken)
        {
            // The retry state is local to the method as we're not trying to handle callers retrying.
            RetryState retryState = new RetryState(_client.Settings.Scheduler ?? SystemScheduler.Instance, _backoffSettings, _backoffJitter);

            while (true)
            {
                // If we've successfully read to the end of the stream and emptied the buffer, we've read all the responses.
                if (_finished && _buffer.Count == 0)
                {
                    return null;
                }

                // Buffer contains items up to a resume token or has reached capacity: flush.
                if (_buffer.Count > 0 && (_finished || !_safeToRetry || !_buffer.Last.Value.ResumeToken.IsEmpty))
                {
                    var firstResult = _buffer.First.Value;
                    _buffer.RemoveFirst();
                    return firstResult;
                }

                try
                {
                    if (_grpcCall == null)
                    {
                        // Note: no cancellation token here; if we've been given a short cancellation token,
                        // it ought to apply to just the MoveNext call, not the original request.
                        _grpcCall = _client.ExecuteStreamingSql(_request, _callSettings).GrpcCall;
                    }
                    bool hasNext = await _grpcCall.ResponseStream
                        .MoveNext(cancellationToken)
                        .WithSessionExpiryChecking(_session)
                        .ConfigureAwait(false);
                    retryState.Reset();

                    if (hasNext)
                    {
                        var next = _grpcCall.ResponseStream.Current;
                        var hasResumeToken = !next.ResumeToken.IsEmpty;

                        if (hasResumeToken)
                        {
                            _request.ResumeToken = next.ResumeToken;
                            _safeToRetry = true;
                        }
                        // If the buffer is empty and this result has a resume token or we cannot resume safely
                        // anyway, we can yield it immediately rather than placing it in the buffer to be
                        // returned on the next iteration.
                        if ((hasResumeToken || !_safeToRetry) && _buffer.Count == 0)
                        {
                            return next;
                        }
                        _buffer.AddLast(next);
                        if (_buffer.Count > _maxBufferSize && !hasResumeToken)
                        {
                            // We need to flush without a restart token.  Errors encountered until we see
                            // such a token will fail the read.
                            _safeToRetry = false;
                        }
                    }
                    else
                    {
                        _finished = true;
                        // Let the next iteration of the loop return 0 or buffered data.
                    }
                }
                catch (RpcException e) when (e.StatusCode == StatusCode.Cancelled && cancellationToken.IsCancellationRequested)
                {
                    // gRPC throws RpcException, but it's more idiomatic to see an OperationCanceledException
                    cancellationToken.ThrowIfCancellationRequested();
                }
                catch (RpcException e) when (_safeToRetry && retryState.CanRetry(e))
                {
                    _client.Settings.Logger.Warn($"Exception when reading from result stream. Retrying.", e);
                    await retryState.RecordErrorAndWaitAsync(e, cancellationToken).ConfigureAwait(false);

                    // Clear anything we've received since the previous response that contained a resume token
                    _buffer.Clear();
                    _grpcCall.Dispose();
                    _grpcCall = null;
                }
            }
        }

        /// <summary>
        /// Keeps track of whether exceptions should be retried or not, along with any delay between retries.
        /// We may want to make this a top-level class at some point.
        /// </summary>
        internal class RetryState
        {
            internal static readonly string RetryInfoKey = (RetryInfo.Descriptor.FullName + "-bin").ToLowerInvariant();
            private const int DefaultMaxConsecutiveErrors = 1;

            private readonly IScheduler _scheduler;
            private readonly BackoffSettings _backoffSettings;
            private readonly IJitter _backoffJitter;
            private readonly int _maxConsecutiveErrors;
            private TimeSpan _nextDelay;
            private int _consecutiveErrors;

            internal RetryState(IScheduler scheduler, BackoffSettings backoffSettings, IJitter backoffJitter)
                : this(scheduler, backoffSettings, backoffJitter, DefaultMaxConsecutiveErrors)
            {
            }

            internal RetryState(IScheduler scheduler, BackoffSettings backoffSettings, IJitter backoffJitter, int maxConsecutiveErrors)
            {
                _scheduler = scheduler;
                _backoffSettings = backoffSettings;
                _backoffJitter = backoffJitter;
                _maxConsecutiveErrors = maxConsecutiveErrors;
                Reset();
            }

            internal RetryState Clone() =>
                new RetryState(_scheduler, _backoffSettings, _backoffJitter);

            /// <summary>
            /// Indicates whether the given exception can be retried in the current state.
            /// This does not change the state.
            /// </summary>
            internal bool CanRetry(RpcException exception)
            {
                if (_consecutiveErrors >= _maxConsecutiveErrors)
                {
                    return false;
                }

                switch (exception.StatusCode)
                {
                    // TODO: Work out what the Java retriable cases look like in .NET.
                    // It matches on messages "HTTP/2 error code: INTERNAL_ERROR", "Connection closed with unknown cause", "Received unexpected EOS on DATA frame from server".
                    // I'd rather not use the message text if possible.
                    case StatusCode.Internal:
                    // TODO: Check that this is valid. The Java code doesn't allow it, but it seems reasonable for a large
                    // result set to require multiple calls to fetch all the data.
                    case StatusCode.DeadlineExceeded:
                    case StatusCode.Unavailable:
                        return true;
                    case StatusCode.ResourceExhausted:
                        return (GetRetryDelay(exception) ?? TimeSpan.Zero) > TimeSpan.Zero;
                    default:
                        return false;
                }
            }

            /// <summary>
            /// Updates the state on the basis of the given exception, delaying for as long as is necessary
            /// between retries.
            /// </summary>
            internal async Task RecordErrorAndWaitAsync(RpcException exception, CancellationToken cancellationToken)
            {
                _consecutiveErrors++;
                TimeSpan thisDelay = GetRetryDelay(exception) ?? _nextDelay;
                await _scheduler.Delay(_backoffJitter.GetDelay(thisDelay), cancellationToken).ConfigureAwait(false);
                _nextDelay = _backoffSettings.NextDelay(_nextDelay);
            }

            /// <summary>
            /// Resets the state, in terms of delays and error counts. This should
            /// be called after each successful call.
            /// </summary>
            internal void Reset()
            {
                _consecutiveErrors = 0;
                _nextDelay = _backoffSettings.Delay;
            }

            private TimeSpan? GetRetryDelay(RpcException e)
            {
                foreach (var entry in e.Trailers)
                {
                    if (entry.Key == RetryInfoKey)
                    {
                        // TODO: Handle invalid values silently, rather than throwing?
                        RetryInfo retryInfo = RetryInfo.Parser.ParseFrom(entry.ValueBytes);
                        return retryInfo.RetryDelay.ToTimeSpan();
                    }
                }
                return null;
            }
        }
    }
}
