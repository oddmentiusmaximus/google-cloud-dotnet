// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/talent/v4beta1/completion_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.Talent.V4Beta1 {

  /// <summary>Holder for reflection information generated from google/cloud/talent/v4beta1/completion_service.proto</summary>
  public static partial class CompletionServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/talent/v4beta1/completion_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CompletionServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjRnb29nbGUvY2xvdWQvdGFsZW50L3Y0YmV0YTEvY29tcGxldGlvbl9zZXJ2",
            "aWNlLnByb3RvEhtnb29nbGUuY2xvdWQudGFsZW50LnY0YmV0YTEaHGdvb2ds",
            "ZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8aKGdvb2dsZS9jbG91ZC90YWxlbnQv",
            "djRiZXRhMS9jb21tb24ucHJvdG8iwgMKFENvbXBsZXRlUXVlcnlSZXF1ZXN0",
            "Eg4KBnBhcmVudBgBIAEoCRINCgVxdWVyeRgCIAEoCRIWCg5sYW5ndWFnZV9j",
            "b2RlcxgDIAMoCRIRCglwYWdlX3NpemUYBCABKAUSDwoHY29tcGFueRgFIAEo",
            "CRJQCgVzY29wZRgGIAEoDjJBLmdvb2dsZS5jbG91ZC50YWxlbnQudjRiZXRh",
            "MS5Db21wbGV0ZVF1ZXJ5UmVxdWVzdC5Db21wbGV0aW9uU2NvcGUSTgoEdHlw",
            "ZRgHIAEoDjJALmdvb2dsZS5jbG91ZC50YWxlbnQudjRiZXRhMS5Db21wbGV0",
            "ZVF1ZXJ5UmVxdWVzdC5Db21wbGV0aW9uVHlwZSJLCg9Db21wbGV0aW9uU2Nv",
            "cGUSIAocQ09NUExFVElPTl9TQ09QRV9VTlNQRUNJRklFRBAAEgoKBlRFTkFO",
            "VBABEgoKBlBVQkxJQxACImAKDkNvbXBsZXRpb25UeXBlEh8KG0NPTVBMRVRJ",
            "T05fVFlQRV9VTlNQRUNJRklFRBAAEg0KCUpPQl9USVRMRRABEhAKDENPTVBB",
            "TllfTkFNRRACEgwKCENPTUJJTkVEEAMixQIKFUNvbXBsZXRlUXVlcnlSZXNw",
            "b25zZRJfChJjb21wbGV0aW9uX3Jlc3VsdHMYASADKAsyQy5nb29nbGUuY2xv",
            "dWQudGFsZW50LnY0YmV0YTEuQ29tcGxldGVRdWVyeVJlc3BvbnNlLkNvbXBs",
            "ZXRpb25SZXN1bHQSPwoIbWV0YWRhdGEYAiABKAsyLS5nb29nbGUuY2xvdWQu",
            "dGFsZW50LnY0YmV0YTEuUmVzcG9uc2VNZXRhZGF0YRqJAQoQQ29tcGxldGlv",
            "blJlc3VsdBISCgpzdWdnZXN0aW9uGAEgASgJEk4KBHR5cGUYAiABKA4yQC5n",
            "b29nbGUuY2xvdWQudGFsZW50LnY0YmV0YTEuQ29tcGxldGVRdWVyeVJlcXVl",
            "c3QuQ29tcGxldGlvblR5cGUSEQoJaW1hZ2VfdXJpGAMgASgJMucBCgpDb21w",
            "bGV0aW9uEtgBCg1Db21wbGV0ZVF1ZXJ5EjEuZ29vZ2xlLmNsb3VkLnRhbGVu",
            "dC52NGJldGExLkNvbXBsZXRlUXVlcnlSZXF1ZXN0GjIuZ29vZ2xlLmNsb3Vk",
            "LnRhbGVudC52NGJldGExLkNvbXBsZXRlUXVlcnlSZXNwb25zZSJggtPkkwJa",
            "Ei8vdjRiZXRhMS97cGFyZW50PXByb2plY3RzLyovdGVuYW50cy8qfTpjb21w",
            "bGV0ZVonEiUvdjRiZXRhMS97cGFyZW50PXByb2plY3RzLyp9OmNvbXBsZXRl",
            "QoQBCh9jb20uZ29vZ2xlLmNsb3VkLnRhbGVudC52NGJldGExQhZDb21wbGV0",
            "aW9uU2VydmljZVByb3RvUAFaQWdvb2dsZS5nb2xhbmcub3JnL2dlbnByb3Rv",
            "L2dvb2dsZWFwaXMvY2xvdWQvdGFsZW50L3Y0YmV0YTE7dGFsZW50ogIDQ1RT",
            "YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Cloud.Talent.V4Beta1.CommonReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Talent.V4Beta1.CompleteQueryRequest), global::Google.Cloud.Talent.V4Beta1.CompleteQueryRequest.Parser, new[]{ "Parent", "Query", "LanguageCodes", "PageSize", "Company", "Scope", "Type" }, null, new[]{ typeof(global::Google.Cloud.Talent.V4Beta1.CompleteQueryRequest.Types.CompletionScope), typeof(global::Google.Cloud.Talent.V4Beta1.CompleteQueryRequest.Types.CompletionType) }, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Talent.V4Beta1.CompleteQueryResponse), global::Google.Cloud.Talent.V4Beta1.CompleteQueryResponse.Parser, new[]{ "CompletionResults", "Metadata" }, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Talent.V4Beta1.CompleteQueryResponse.Types.CompletionResult), global::Google.Cloud.Talent.V4Beta1.CompleteQueryResponse.Types.CompletionResult.Parser, new[]{ "Suggestion", "Type", "ImageUri" }, null, null, null)})
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Input only.
  ///
  /// Auto-complete parameters.
  /// </summary>
  public sealed partial class CompleteQueryRequest : pb::IMessage<CompleteQueryRequest> {
    private static readonly pb::MessageParser<CompleteQueryRequest> _parser = new pb::MessageParser<CompleteQueryRequest>(() => new CompleteQueryRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CompleteQueryRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Talent.V4Beta1.CompletionServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CompleteQueryRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CompleteQueryRequest(CompleteQueryRequest other) : this() {
      parent_ = other.parent_;
      query_ = other.query_;
      languageCodes_ = other.languageCodes_.Clone();
      pageSize_ = other.pageSize_;
      company_ = other.company_;
      scope_ = other.scope_;
      type_ = other.type_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CompleteQueryRequest Clone() {
      return new CompleteQueryRequest(this);
    }

    /// <summary>Field number for the "parent" field.</summary>
    public const int ParentFieldNumber = 1;
    private string parent_ = "";
    /// <summary>
    /// Required.
    ///
    /// Resource name of tenant the completion is performed within.
    ///
    /// The format is "projects/{project_id}/tenants/{tenant_id}", for example,
    /// "projects/api-test-project/tenant/foo".
    ///
    /// Tenant id is optional and the default tenant is used if unspecified, for
    /// example, "projects/api-test-project".
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Parent {
      get { return parent_; }
      set {
        parent_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "query" field.</summary>
    public const int QueryFieldNumber = 2;
    private string query_ = "";
    /// <summary>
    /// Required.
    ///
    /// The query used to generate suggestions.
    ///
    /// The maximum number of allowed characters is 255.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Query {
      get { return query_; }
      set {
        query_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "language_codes" field.</summary>
    public const int LanguageCodesFieldNumber = 3;
    private static readonly pb::FieldCodec<string> _repeated_languageCodes_codec
        = pb::FieldCodec.ForString(26);
    private readonly pbc::RepeatedField<string> languageCodes_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// Optional.
    ///
    /// The list of languages of the query. This is
    /// the BCP-47 language code, such as "en-US" or "sr-Latn".
    /// For more information, see
    /// [Tags for Identifying Languages](https://tools.ietf.org/html/bcp47).
    ///
    /// For
    /// [CompletionType.JOB_TITLE][google.cloud.talent.v4beta1.CompleteQueryRequest.CompletionType.JOB_TITLE]
    /// type, only open jobs with the same
    /// [language_codes][google.cloud.talent.v4beta1.CompleteQueryRequest.language_codes]
    /// are returned.
    ///
    /// For
    /// [CompletionType.COMPANY_NAME][google.cloud.talent.v4beta1.CompleteQueryRequest.CompletionType.COMPANY_NAME]
    /// type, only companies having open jobs with the same
    /// [language_codes][google.cloud.talent.v4beta1.CompleteQueryRequest.language_codes]
    /// are returned.
    ///
    /// For
    /// [CompletionType.COMBINED][google.cloud.talent.v4beta1.CompleteQueryRequest.CompletionType.COMBINED]
    /// type, only open jobs with the same
    /// [language_codes][google.cloud.talent.v4beta1.CompleteQueryRequest.language_codes]
    /// or companies having open jobs with the same
    /// [language_codes][google.cloud.talent.v4beta1.CompleteQueryRequest.language_codes]
    /// are returned.
    ///
    /// The maximum number of allowed characters is 255.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> LanguageCodes {
      get { return languageCodes_; }
    }

    /// <summary>Field number for the "page_size" field.</summary>
    public const int PageSizeFieldNumber = 4;
    private int pageSize_;
    /// <summary>
    /// Required.
    ///
    /// Completion result count.
    ///
    /// The maximum allowed page size is 10.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int PageSize {
      get { return pageSize_; }
      set {
        pageSize_ = value;
      }
    }

    /// <summary>Field number for the "company" field.</summary>
    public const int CompanyFieldNumber = 5;
    private string company_ = "";
    /// <summary>
    /// Optional.
    ///
    /// If provided, restricts completion to specified company.
    ///
    /// The format is
    /// "projects/{project_id}/tenants/{tenant_id}/companies/{company_id}", for
    /// example, "projects/api-test-project/tenants/foo/companies/bar".
    ///
    /// Tenant id is optional and the default tenant is used if unspecified, for
    /// example, "projects/api-test-project/companies/bar".
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Company {
      get { return company_; }
      set {
        company_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "scope" field.</summary>
    public const int ScopeFieldNumber = 6;
    private global::Google.Cloud.Talent.V4Beta1.CompleteQueryRequest.Types.CompletionScope scope_ = 0;
    /// <summary>
    /// Optional.
    ///
    /// The scope of the completion. The defaults is
    /// [CompletionScope.PUBLIC][google.cloud.talent.v4beta1.CompleteQueryRequest.CompletionScope.PUBLIC].
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.Talent.V4Beta1.CompleteQueryRequest.Types.CompletionScope Scope {
      get { return scope_; }
      set {
        scope_ = value;
      }
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 7;
    private global::Google.Cloud.Talent.V4Beta1.CompleteQueryRequest.Types.CompletionType type_ = 0;
    /// <summary>
    /// Optional.
    ///
    /// The completion topic. The default is
    /// [CompletionType.COMBINED][google.cloud.talent.v4beta1.CompleteQueryRequest.CompletionType.COMBINED].
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.Talent.V4Beta1.CompleteQueryRequest.Types.CompletionType Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CompleteQueryRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CompleteQueryRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Parent != other.Parent) return false;
      if (Query != other.Query) return false;
      if(!languageCodes_.Equals(other.languageCodes_)) return false;
      if (PageSize != other.PageSize) return false;
      if (Company != other.Company) return false;
      if (Scope != other.Scope) return false;
      if (Type != other.Type) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Parent.Length != 0) hash ^= Parent.GetHashCode();
      if (Query.Length != 0) hash ^= Query.GetHashCode();
      hash ^= languageCodes_.GetHashCode();
      if (PageSize != 0) hash ^= PageSize.GetHashCode();
      if (Company.Length != 0) hash ^= Company.GetHashCode();
      if (Scope != 0) hash ^= Scope.GetHashCode();
      if (Type != 0) hash ^= Type.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Parent.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Parent);
      }
      if (Query.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Query);
      }
      languageCodes_.WriteTo(output, _repeated_languageCodes_codec);
      if (PageSize != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(PageSize);
      }
      if (Company.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Company);
      }
      if (Scope != 0) {
        output.WriteRawTag(48);
        output.WriteEnum((int) Scope);
      }
      if (Type != 0) {
        output.WriteRawTag(56);
        output.WriteEnum((int) Type);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Parent.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Parent);
      }
      if (Query.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Query);
      }
      size += languageCodes_.CalculateSize(_repeated_languageCodes_codec);
      if (PageSize != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(PageSize);
      }
      if (Company.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Company);
      }
      if (Scope != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Scope);
      }
      if (Type != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CompleteQueryRequest other) {
      if (other == null) {
        return;
      }
      if (other.Parent.Length != 0) {
        Parent = other.Parent;
      }
      if (other.Query.Length != 0) {
        Query = other.Query;
      }
      languageCodes_.Add(other.languageCodes_);
      if (other.PageSize != 0) {
        PageSize = other.PageSize;
      }
      if (other.Company.Length != 0) {
        Company = other.Company;
      }
      if (other.Scope != 0) {
        Scope = other.Scope;
      }
      if (other.Type != 0) {
        Type = other.Type;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Parent = input.ReadString();
            break;
          }
          case 18: {
            Query = input.ReadString();
            break;
          }
          case 26: {
            languageCodes_.AddEntriesFrom(input, _repeated_languageCodes_codec);
            break;
          }
          case 32: {
            PageSize = input.ReadInt32();
            break;
          }
          case 42: {
            Company = input.ReadString();
            break;
          }
          case 48: {
            scope_ = (global::Google.Cloud.Talent.V4Beta1.CompleteQueryRequest.Types.CompletionScope) input.ReadEnum();
            break;
          }
          case 56: {
            type_ = (global::Google.Cloud.Talent.V4Beta1.CompleteQueryRequest.Types.CompletionType) input.ReadEnum();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the CompleteQueryRequest message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enum to specify the scope of completion.
      /// </summary>
      public enum CompletionScope {
        /// <summary>
        /// Default value.
        /// </summary>
        [pbr::OriginalName("COMPLETION_SCOPE_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Suggestions are based only on the data provided by the client.
        /// </summary>
        [pbr::OriginalName("TENANT")] Tenant = 1,
        /// <summary>
        /// Suggestions are based on all jobs data in the system that's visible to
        /// the client
        /// </summary>
        [pbr::OriginalName("PUBLIC")] Public = 2,
      }

      /// <summary>
      /// Enum to specify auto-completion topics.
      /// </summary>
      public enum CompletionType {
        /// <summary>
        /// Default value.
        /// </summary>
        [pbr::OriginalName("COMPLETION_TYPE_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Only suggest job titles.
        /// </summary>
        [pbr::OriginalName("JOB_TITLE")] JobTitle = 1,
        /// <summary>
        /// Only suggest company names.
        /// </summary>
        [pbr::OriginalName("COMPANY_NAME")] CompanyName = 2,
        /// <summary>
        /// Suggest both job titles and company names.
        /// </summary>
        [pbr::OriginalName("COMBINED")] Combined = 3,
      }

    }
    #endregion

  }

  /// <summary>
  /// Output only.
  ///
  /// Response of auto-complete query.
  /// </summary>
  public sealed partial class CompleteQueryResponse : pb::IMessage<CompleteQueryResponse> {
    private static readonly pb::MessageParser<CompleteQueryResponse> _parser = new pb::MessageParser<CompleteQueryResponse>(() => new CompleteQueryResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CompleteQueryResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Talent.V4Beta1.CompletionServiceReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CompleteQueryResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CompleteQueryResponse(CompleteQueryResponse other) : this() {
      completionResults_ = other.completionResults_.Clone();
      metadata_ = other.metadata_ != null ? other.metadata_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CompleteQueryResponse Clone() {
      return new CompleteQueryResponse(this);
    }

    /// <summary>Field number for the "completion_results" field.</summary>
    public const int CompletionResultsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Google.Cloud.Talent.V4Beta1.CompleteQueryResponse.Types.CompletionResult> _repeated_completionResults_codec
        = pb::FieldCodec.ForMessage(10, global::Google.Cloud.Talent.V4Beta1.CompleteQueryResponse.Types.CompletionResult.Parser);
    private readonly pbc::RepeatedField<global::Google.Cloud.Talent.V4Beta1.CompleteQueryResponse.Types.CompletionResult> completionResults_ = new pbc::RepeatedField<global::Google.Cloud.Talent.V4Beta1.CompleteQueryResponse.Types.CompletionResult>();
    /// <summary>
    /// Results of the matching job/company candidates.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Google.Cloud.Talent.V4Beta1.CompleteQueryResponse.Types.CompletionResult> CompletionResults {
      get { return completionResults_; }
    }

    /// <summary>Field number for the "metadata" field.</summary>
    public const int MetadataFieldNumber = 2;
    private global::Google.Cloud.Talent.V4Beta1.ResponseMetadata metadata_;
    /// <summary>
    /// Additional information for the API invocation, such as the request
    /// tracking id.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.Talent.V4Beta1.ResponseMetadata Metadata {
      get { return metadata_; }
      set {
        metadata_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CompleteQueryResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CompleteQueryResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!completionResults_.Equals(other.completionResults_)) return false;
      if (!object.Equals(Metadata, other.Metadata)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= completionResults_.GetHashCode();
      if (metadata_ != null) hash ^= Metadata.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      completionResults_.WriteTo(output, _repeated_completionResults_codec);
      if (metadata_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Metadata);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += completionResults_.CalculateSize(_repeated_completionResults_codec);
      if (metadata_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Metadata);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CompleteQueryResponse other) {
      if (other == null) {
        return;
      }
      completionResults_.Add(other.completionResults_);
      if (other.metadata_ != null) {
        if (metadata_ == null) {
          metadata_ = new global::Google.Cloud.Talent.V4Beta1.ResponseMetadata();
        }
        Metadata.MergeFrom(other.Metadata);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            completionResults_.AddEntriesFrom(input, _repeated_completionResults_codec);
            break;
          }
          case 18: {
            if (metadata_ == null) {
              metadata_ = new global::Google.Cloud.Talent.V4Beta1.ResponseMetadata();
            }
            input.ReadMessage(metadata_);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the CompleteQueryResponse message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Output only.
      ///
      /// Resource that represents completion results.
      /// </summary>
      public sealed partial class CompletionResult : pb::IMessage<CompletionResult> {
        private static readonly pb::MessageParser<CompletionResult> _parser = new pb::MessageParser<CompletionResult>(() => new CompletionResult());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<CompletionResult> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Google.Cloud.Talent.V4Beta1.CompleteQueryResponse.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public CompletionResult() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public CompletionResult(CompletionResult other) : this() {
          suggestion_ = other.suggestion_;
          type_ = other.type_;
          imageUri_ = other.imageUri_;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public CompletionResult Clone() {
          return new CompletionResult(this);
        }

        /// <summary>Field number for the "suggestion" field.</summary>
        public const int SuggestionFieldNumber = 1;
        private string suggestion_ = "";
        /// <summary>
        /// The suggestion for the query.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string Suggestion {
          get { return suggestion_; }
          set {
            suggestion_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "type" field.</summary>
        public const int TypeFieldNumber = 2;
        private global::Google.Cloud.Talent.V4Beta1.CompleteQueryRequest.Types.CompletionType type_ = 0;
        /// <summary>
        /// The completion topic.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public global::Google.Cloud.Talent.V4Beta1.CompleteQueryRequest.Types.CompletionType Type {
          get { return type_; }
          set {
            type_ = value;
          }
        }

        /// <summary>Field number for the "image_uri" field.</summary>
        public const int ImageUriFieldNumber = 3;
        private string imageUri_ = "";
        /// <summary>
        /// The URI of the company image for
        /// [COMPANY_NAME][google.cloud.talent.v4beta1.CompleteQueryRequest.CompletionType.COMPANY_NAME].
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string ImageUri {
          get { return imageUri_; }
          set {
            imageUri_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as CompletionResult);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(CompletionResult other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (Suggestion != other.Suggestion) return false;
          if (Type != other.Type) return false;
          if (ImageUri != other.ImageUri) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          if (Suggestion.Length != 0) hash ^= Suggestion.GetHashCode();
          if (Type != 0) hash ^= Type.GetHashCode();
          if (ImageUri.Length != 0) hash ^= ImageUri.GetHashCode();
          if (_unknownFields != null) {
            hash ^= _unknownFields.GetHashCode();
          }
          return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override string ToString() {
          return pb::JsonFormatter.ToDiagnosticString(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void WriteTo(pb::CodedOutputStream output) {
          if (Suggestion.Length != 0) {
            output.WriteRawTag(10);
            output.WriteString(Suggestion);
          }
          if (Type != 0) {
            output.WriteRawTag(16);
            output.WriteEnum((int) Type);
          }
          if (ImageUri.Length != 0) {
            output.WriteRawTag(26);
            output.WriteString(ImageUri);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          if (Suggestion.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(Suggestion);
          }
          if (Type != 0) {
            size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
          }
          if (ImageUri.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(ImageUri);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(CompletionResult other) {
          if (other == null) {
            return;
          }
          if (other.Suggestion.Length != 0) {
            Suggestion = other.Suggestion;
          }
          if (other.Type != 0) {
            Type = other.Type;
          }
          if (other.ImageUri.Length != 0) {
            ImageUri = other.ImageUri;
          }
          _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(pb::CodedInputStream input) {
          uint tag;
          while ((tag = input.ReadTag()) != 0) {
            switch(tag) {
              default:
                _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
                break;
              case 10: {
                Suggestion = input.ReadString();
                break;
              }
              case 16: {
                type_ = (global::Google.Cloud.Talent.V4Beta1.CompleteQueryRequest.Types.CompletionType) input.ReadEnum();
                break;
              }
              case 26: {
                ImageUri = input.ReadString();
                break;
              }
            }
          }
        }

      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
