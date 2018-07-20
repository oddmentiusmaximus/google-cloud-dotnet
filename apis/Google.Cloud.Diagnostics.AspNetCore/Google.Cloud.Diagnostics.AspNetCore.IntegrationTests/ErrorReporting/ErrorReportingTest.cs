﻿// Copyright 2016 Google Inc. All Rights Reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Cloud.ClientTesting;
using Google.Cloud.Diagnostics.Common.IntegrationTests;
using Google.Cloud.Diagnostics.Common.IntegrationTests.ErrorReporting;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Diagnostics.AspNetCore.IntegrationTests
{
    public class ErrorReportingTest : IDisposable
    {
        private static readonly ErrorEventEntryPolling s_polling = new ErrorEventEntryPolling();

        private readonly string _testId;

        private readonly TestServer _server;
        private readonly HttpClient _client;

        private readonly DateTime _startTime;

        public ErrorReportingTest()
        {
            _testId = IdGenerator.FromDateTime();

            var builder = new WebHostBuilder().UseStartup<ErrorReportingTestApplication>();
            _server = new TestServer(builder);
            _client = _server.CreateClient();

            _startTime = DateTime.UtcNow;
        }

        [Fact]
        public async Task NoExceptions()
        {
            var response = await _client.GetAsync($"/ErrorReporting/{nameof(ErrorReportingController.Index)}/{_testId}");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);

            var errorEvents = s_polling.GetEvents(_startTime, _testId, 0);
            Assert.Empty(errorEvents);
        }

        [Fact]
        public async Task ManualLog()
        {
            var response = await _client.GetAsync($"/ErrorReporting/{nameof(ErrorReportingController.ThrowCatchLog)}/{_testId}");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);

            var errorEvent = s_polling.GetEvents(_startTime, _testId, 1).Single();
            ErrorEventEntryVerifiers.VerifyFullErrorEventLogged(errorEvent, _testId, nameof(ErrorReportingController.ThrowCatchLog), (int)HttpStatusCode.OK);
        }

        [Fact]
        public async Task LogsException()
        {
            await Assert.ThrowsAsync<Exception>(() =>
                _client.GetAsync($"/ErrorReporting/{nameof(ErrorReportingController.ThrowsException)}/{_testId}"));

            var errorEvent = s_polling.GetEvents(_startTime, _testId, 1).Single();
            ErrorEventEntryVerifiers.VerifyFullErrorEventLogged(errorEvent, _testId, nameof(ErrorReportingController.ThrowsException), (int)HttpStatusCode.OK);
        }

        [Fact]
        public async Task LogsMultipleExceptions()
        {
            await Assert.ThrowsAsync<Exception>(() =>
                _client.GetAsync($"/ErrorReporting/{nameof(ErrorReportingController.ThrowsException)}/{_testId}"));
            await Assert.ThrowsAsync<ArgumentException>(() =>
                _client.GetAsync($"/ErrorReporting/{nameof(ErrorReportingController.ThrowsArgumentException)}/{_testId}"));
            await Assert.ThrowsAsync<Exception>(() =>
                _client.GetAsync($"/ErrorReporting/{nameof(ErrorReportingController.ThrowsException)}/{_testId}"));
            await Assert.ThrowsAsync<Exception>(() =>
                _client.GetAsync($"/ErrorReporting/{nameof(ErrorReportingController.ThrowsException)}/{_testId}"));

            var errorEvents = s_polling.GetEvents(_startTime, _testId, 4);
            Assert.Equal(4, errorEvents.Count());

            var exceptionEvents = errorEvents.Where(e => e.Message.Contains(nameof(ErrorReportingController.ThrowsException)));
            Assert.Equal(3, exceptionEvents.Count());
            foreach (var errorEvent in exceptionEvents)
            {
                ErrorEventEntryVerifiers.VerifyFullErrorEventLogged(errorEvent, _testId, nameof(ErrorReportingController.ThrowsException), (int)HttpStatusCode.OK);
            }

            var argumentExceptionEvent = errorEvents.Where(e => e.Message.Contains(nameof(ErrorReportingController.ThrowsArgumentException))).Single();
            ErrorEventEntryVerifiers.VerifyFullErrorEventLogged(argumentExceptionEvent, _testId, nameof(ErrorReportingController.ThrowsArgumentException), (int)HttpStatusCode.OK);
        }

        public void Dispose()
        {
            _client.Dispose();
            _server.Dispose();
        }

        /// <summary>
        /// A simple web application base to test the <see cref="GoogleExceptionLogger"/>
        /// and associated classes.
        /// </summary>
        private class ErrorReportingTestApplication
        {
            public void ConfigureServices(IServiceCollection services)
            {
                services.AddGoogleExceptionLogging(options =>
                {
                    options.ProjectId = TestEnvironment.GetTestProjectId();
                    options.ServiceName = EntryData.Service;
                    options.Version = EntryData.Version;
                })
                .AddMvc();
            }

            public void Configure(IApplicationBuilder app)
            {
                app.UseGoogleExceptionLogging()
                    .UseMvc(routes =>
                    {
                        routes.MapRoute(
                            name: "default",
                            template: "{controller=ErrorReporting}/{action=Index}/{id}");
                    });
            }
        }
    }

    /// <summary>
    /// A controller for the <see cref="ErrorReportingTestApplication"/> used to log exceptions.
    /// </summary>
    public class ErrorReportingController : Controller
    {
        private readonly IExceptionLogger _exceptionLogger;
        public ErrorReportingController(IExceptionLogger exceptionLogger)
        {
            _exceptionLogger = exceptionLogger;
        }

        /// <summary>Catches and handles a thrown <see cref="Exception"/>.</summary>
        public string Index(string id)
        {
            var message = EntryData.GetMessage(nameof(Index), id);
            try
            {
                throw new Exception(message);
            }
            catch
            {
                // Do nothing.
            }
            return message;
        }

        /// <summary>Throws an <see cref="Exception"/>.</summary>
        public string ThrowsException(string id)
        {
            string message = EntryData.GetMessage(nameof(ThrowsException), id);
            throw new Exception(message);
        }

        /// <summary>Throws an <see cref="ArgumentException"/>.</summary>
        public string ThrowsArgumentException(string id)
        {
            string message = EntryData.GetMessage(nameof(ThrowsArgumentException), id);
            throw new ArgumentException(message);
        }

        /// <summary>Catches and logs a thrown <see cref="Exception"/>.</summary>
        public string ThrowCatchLog(string id)
        {
            var message = EntryData.GetMessage(nameof(Index), id);
            try
            {
                throw new Exception(message);
            }
            catch (Exception e)
            {
                _exceptionLogger.Log(e);
            }
            return message;
        }
    }
}
