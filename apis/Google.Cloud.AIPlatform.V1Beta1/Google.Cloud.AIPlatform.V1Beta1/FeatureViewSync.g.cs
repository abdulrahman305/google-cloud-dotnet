// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/aiplatform/v1beta1/feature_view_sync.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.AIPlatform.V1Beta1 {

  /// <summary>Holder for reflection information generated from google/cloud/aiplatform/v1beta1/feature_view_sync.proto</summary>
  public static partial class FeatureViewSyncReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/aiplatform/v1beta1/feature_view_sync.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FeatureViewSyncReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjdnb29nbGUvY2xvdWQvYWlwbGF0Zm9ybS92MWJldGExL2ZlYXR1cmVfdmll",
            "d19zeW5jLnByb3RvEh9nb29nbGUuY2xvdWQuYWlwbGF0Zm9ybS52MWJldGEx",
            "Gh9nb29nbGUvYXBpL2ZpZWxkX2JlaGF2aW9yLnByb3RvGhlnb29nbGUvYXBp",
            "L3Jlc291cmNlLnByb3RvGh9nb29nbGUvcHJvdG9idWYvdGltZXN0YW1wLnBy",
            "b3RvGhdnb29nbGUvcnBjL3N0YXR1cy5wcm90bxoaZ29vZ2xlL3R5cGUvaW50",
            "ZXJ2YWwucHJvdG8izwQKD0ZlYXR1cmVWaWV3U3luYxIRCgRuYW1lGAEgASgJ",
            "QgPgQQgSNAoLY3JlYXRlX3RpbWUYAiABKAsyGi5nb29nbGUucHJvdG9idWYu",
            "VGltZXN0YW1wQgPgQQMSLAoIcnVuX3RpbWUYBSABKAsyFS5nb29nbGUudHlw",
            "ZS5JbnRlcnZhbEID4EEDEi0KDGZpbmFsX3N0YXR1cxgEIAEoCzISLmdvb2ds",
            "ZS5ycGMuU3RhdHVzQgPgQQMSVwoMc3luY19zdW1tYXJ5GAYgASgLMjwuZ29v",
            "Z2xlLmNsb3VkLmFpcGxhdGZvcm0udjFiZXRhMS5GZWF0dXJlVmlld1N5bmMu",
            "U3luY1N1bW1hcnlCA+BBAxIaCg1zYXRpc2ZpZXNfcHpzGAcgASgIQgPgQQMS",
            "GgoNc2F0aXNmaWVzX3B6aRgIIAEoCEID4EEDGj8KC1N5bmNTdW1tYXJ5EhcK",
            "CnJvd19zeW5jZWQYASABKANCA+BBAxIXCgp0b3RhbF9zbG90GAIgASgDQgPg",
            "QQM6wwHqQb8BCilhaXBsYXRmb3JtLmdvb2dsZWFwaXMuY29tL0ZlYXR1cmVW",
            "aWV3U3luYxKRAXByb2plY3RzL3twcm9qZWN0fS9sb2NhdGlvbnMve2xvY2F0",
            "aW9ufS9mZWF0dXJlT25saW5lU3RvcmVzL3tmZWF0dXJlX29ubGluZV9zdG9y",
            "ZX0vZmVhdHVyZVZpZXdzL3tmZWF0dXJlX3ZpZXd9L2ZlYXR1cmVWaWV3U3lu",
            "Y3MvZmVhdHVyZV92aWV3X3N5bmNC6wEKI2NvbS5nb29nbGUuY2xvdWQuYWlw",
            "bGF0Zm9ybS52MWJldGExQhRGZWF0dXJlVmlld1N5bmNQcm90b1ABWkNjbG91",
            "ZC5nb29nbGUuY29tL2dvL2FpcGxhdGZvcm0vYXBpdjFiZXRhMS9haXBsYXRm",
            "b3JtcGI7YWlwbGF0Zm9ybXBiqgIfR29vZ2xlLkNsb3VkLkFJUGxhdGZvcm0u",
            "VjFCZXRhMcoCH0dvb2dsZVxDbG91ZFxBSVBsYXRmb3JtXFYxYmV0YTHqAiJH",
            "b29nbGU6OkNsb3VkOjpBaXBsYXRmb3JtOjpWMWJldGExYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, global::Google.Rpc.StatusReflection.Descriptor, global::Google.Type.IntervalReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.AIPlatform.V1Beta1.FeatureViewSync), global::Google.Cloud.AIPlatform.V1Beta1.FeatureViewSync.Parser, new[]{ "Name", "CreateTime", "RunTime", "FinalStatus", "SyncSummary", "SatisfiesPzs", "SatisfiesPzi" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.AIPlatform.V1Beta1.FeatureViewSync.Types.SyncSummary), global::Google.Cloud.AIPlatform.V1Beta1.FeatureViewSync.Types.SyncSummary.Parser, new[]{ "RowSynced", "TotalSlot" }, null, null, null, null)})
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// FeatureViewSync is a representation of sync operation which copies data from
  /// data source to Feature View in Online Store.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class FeatureViewSync : pb::IMessage<FeatureViewSync>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FeatureViewSync> _parser = new pb::MessageParser<FeatureViewSync>(() => new FeatureViewSync());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FeatureViewSync> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.AIPlatform.V1Beta1.FeatureViewSyncReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FeatureViewSync() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FeatureViewSync(FeatureViewSync other) : this() {
      name_ = other.name_;
      createTime_ = other.createTime_ != null ? other.createTime_.Clone() : null;
      runTime_ = other.runTime_ != null ? other.runTime_.Clone() : null;
      finalStatus_ = other.finalStatus_ != null ? other.finalStatus_.Clone() : null;
      syncSummary_ = other.syncSummary_ != null ? other.syncSummary_.Clone() : null;
      satisfiesPzs_ = other.satisfiesPzs_;
      satisfiesPzi_ = other.satisfiesPzi_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FeatureViewSync Clone() {
      return new FeatureViewSync(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// Identifier. Name of the FeatureViewSync. Format:
    /// `projects/{project}/locations/{location}/featureOnlineStores/{feature_online_store}/featureViews/{feature_view}/featureViewSyncs/{feature_view_sync}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "create_time" field.</summary>
    public const int CreateTimeFieldNumber = 2;
    private global::Google.Protobuf.WellKnownTypes.Timestamp createTime_;
    /// <summary>
    /// Output only. Time when this FeatureViewSync is created. Creation of a
    /// FeatureViewSync means that the job is pending / waiting for sufficient
    /// resources but may not have started the actual data transfer yet.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp CreateTime {
      get { return createTime_; }
      set {
        createTime_ = value;
      }
    }

    /// <summary>Field number for the "run_time" field.</summary>
    public const int RunTimeFieldNumber = 5;
    private global::Google.Type.Interval runTime_;
    /// <summary>
    /// Output only. Time when this FeatureViewSync is finished.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Type.Interval RunTime {
      get { return runTime_; }
      set {
        runTime_ = value;
      }
    }

    /// <summary>Field number for the "final_status" field.</summary>
    public const int FinalStatusFieldNumber = 4;
    private global::Google.Rpc.Status finalStatus_;
    /// <summary>
    /// Output only. Final status of the FeatureViewSync.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Rpc.Status FinalStatus {
      get { return finalStatus_; }
      set {
        finalStatus_ = value;
      }
    }

    /// <summary>Field number for the "sync_summary" field.</summary>
    public const int SyncSummaryFieldNumber = 6;
    private global::Google.Cloud.AIPlatform.V1Beta1.FeatureViewSync.Types.SyncSummary syncSummary_;
    /// <summary>
    /// Output only. Summary of the sync job.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.AIPlatform.V1Beta1.FeatureViewSync.Types.SyncSummary SyncSummary {
      get { return syncSummary_; }
      set {
        syncSummary_ = value;
      }
    }

    /// <summary>Field number for the "satisfies_pzs" field.</summary>
    public const int SatisfiesPzsFieldNumber = 7;
    private bool satisfiesPzs_;
    /// <summary>
    /// Output only. Reserved for future use.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool SatisfiesPzs {
      get { return satisfiesPzs_; }
      set {
        satisfiesPzs_ = value;
      }
    }

    /// <summary>Field number for the "satisfies_pzi" field.</summary>
    public const int SatisfiesPziFieldNumber = 8;
    private bool satisfiesPzi_;
    /// <summary>
    /// Output only. Reserved for future use.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool SatisfiesPzi {
      get { return satisfiesPzi_; }
      set {
        satisfiesPzi_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FeatureViewSync);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FeatureViewSync other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (!object.Equals(CreateTime, other.CreateTime)) return false;
      if (!object.Equals(RunTime, other.RunTime)) return false;
      if (!object.Equals(FinalStatus, other.FinalStatus)) return false;
      if (!object.Equals(SyncSummary, other.SyncSummary)) return false;
      if (SatisfiesPzs != other.SatisfiesPzs) return false;
      if (SatisfiesPzi != other.SatisfiesPzi) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (createTime_ != null) hash ^= CreateTime.GetHashCode();
      if (runTime_ != null) hash ^= RunTime.GetHashCode();
      if (finalStatus_ != null) hash ^= FinalStatus.GetHashCode();
      if (syncSummary_ != null) hash ^= SyncSummary.GetHashCode();
      if (SatisfiesPzs != false) hash ^= SatisfiesPzs.GetHashCode();
      if (SatisfiesPzi != false) hash ^= SatisfiesPzi.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (createTime_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(CreateTime);
      }
      if (finalStatus_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(FinalStatus);
      }
      if (runTime_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(RunTime);
      }
      if (syncSummary_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(SyncSummary);
      }
      if (SatisfiesPzs != false) {
        output.WriteRawTag(56);
        output.WriteBool(SatisfiesPzs);
      }
      if (SatisfiesPzi != false) {
        output.WriteRawTag(64);
        output.WriteBool(SatisfiesPzi);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (createTime_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(CreateTime);
      }
      if (finalStatus_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(FinalStatus);
      }
      if (runTime_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(RunTime);
      }
      if (syncSummary_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(SyncSummary);
      }
      if (SatisfiesPzs != false) {
        output.WriteRawTag(56);
        output.WriteBool(SatisfiesPzs);
      }
      if (SatisfiesPzi != false) {
        output.WriteRawTag(64);
        output.WriteBool(SatisfiesPzi);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (createTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CreateTime);
      }
      if (runTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RunTime);
      }
      if (finalStatus_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(FinalStatus);
      }
      if (syncSummary_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SyncSummary);
      }
      if (SatisfiesPzs != false) {
        size += 1 + 1;
      }
      if (SatisfiesPzi != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(FeatureViewSync other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.createTime_ != null) {
        if (createTime_ == null) {
          CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        CreateTime.MergeFrom(other.CreateTime);
      }
      if (other.runTime_ != null) {
        if (runTime_ == null) {
          RunTime = new global::Google.Type.Interval();
        }
        RunTime.MergeFrom(other.RunTime);
      }
      if (other.finalStatus_ != null) {
        if (finalStatus_ == null) {
          FinalStatus = new global::Google.Rpc.Status();
        }
        FinalStatus.MergeFrom(other.FinalStatus);
      }
      if (other.syncSummary_ != null) {
        if (syncSummary_ == null) {
          SyncSummary = new global::Google.Cloud.AIPlatform.V1Beta1.FeatureViewSync.Types.SyncSummary();
        }
        SyncSummary.MergeFrom(other.SyncSummary);
      }
      if (other.SatisfiesPzs != false) {
        SatisfiesPzs = other.SatisfiesPzs;
      }
      if (other.SatisfiesPzi != false) {
        SatisfiesPzi = other.SatisfiesPzi;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 18: {
            if (createTime_ == null) {
              CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CreateTime);
            break;
          }
          case 34: {
            if (finalStatus_ == null) {
              FinalStatus = new global::Google.Rpc.Status();
            }
            input.ReadMessage(FinalStatus);
            break;
          }
          case 42: {
            if (runTime_ == null) {
              RunTime = new global::Google.Type.Interval();
            }
            input.ReadMessage(RunTime);
            break;
          }
          case 50: {
            if (syncSummary_ == null) {
              SyncSummary = new global::Google.Cloud.AIPlatform.V1Beta1.FeatureViewSync.Types.SyncSummary();
            }
            input.ReadMessage(SyncSummary);
            break;
          }
          case 56: {
            SatisfiesPzs = input.ReadBool();
            break;
          }
          case 64: {
            SatisfiesPzi = input.ReadBool();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 18: {
            if (createTime_ == null) {
              CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CreateTime);
            break;
          }
          case 34: {
            if (finalStatus_ == null) {
              FinalStatus = new global::Google.Rpc.Status();
            }
            input.ReadMessage(FinalStatus);
            break;
          }
          case 42: {
            if (runTime_ == null) {
              RunTime = new global::Google.Type.Interval();
            }
            input.ReadMessage(RunTime);
            break;
          }
          case 50: {
            if (syncSummary_ == null) {
              SyncSummary = new global::Google.Cloud.AIPlatform.V1Beta1.FeatureViewSync.Types.SyncSummary();
            }
            input.ReadMessage(SyncSummary);
            break;
          }
          case 56: {
            SatisfiesPzs = input.ReadBool();
            break;
          }
          case 64: {
            SatisfiesPzi = input.ReadBool();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the FeatureViewSync message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Summary from the Sync job. For continuous syncs, the summary is updated
      /// periodically. For batch syncs, it gets updated on completion of the sync.
      /// </summary>
      [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
      public sealed partial class SyncSummary : pb::IMessage<SyncSummary>
      #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          , pb::IBufferMessage
      #endif
      {
        private static readonly pb::MessageParser<SyncSummary> _parser = new pb::MessageParser<SyncSummary>(() => new SyncSummary());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pb::MessageParser<SyncSummary> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Google.Cloud.AIPlatform.V1Beta1.FeatureViewSync.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public SyncSummary() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public SyncSummary(SyncSummary other) : this() {
          rowSynced_ = other.rowSynced_;
          totalSlot_ = other.totalSlot_;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public SyncSummary Clone() {
          return new SyncSummary(this);
        }

        /// <summary>Field number for the "row_synced" field.</summary>
        public const int RowSyncedFieldNumber = 1;
        private long rowSynced_;
        /// <summary>
        /// Output only. Total number of rows synced.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public long RowSynced {
          get { return rowSynced_; }
          set {
            rowSynced_ = value;
          }
        }

        /// <summary>Field number for the "total_slot" field.</summary>
        public const int TotalSlotFieldNumber = 2;
        private long totalSlot_;
        /// <summary>
        /// Output only. BigQuery slot milliseconds consumed for the sync job.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public long TotalSlot {
          get { return totalSlot_; }
          set {
            totalSlot_ = value;
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override bool Equals(object other) {
          return Equals(other as SyncSummary);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool Equals(SyncSummary other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (RowSynced != other.RowSynced) return false;
          if (TotalSlot != other.TotalSlot) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override int GetHashCode() {
          int hash = 1;
          if (RowSynced != 0L) hash ^= RowSynced.GetHashCode();
          if (TotalSlot != 0L) hash ^= TotalSlot.GetHashCode();
          if (_unknownFields != null) {
            hash ^= _unknownFields.GetHashCode();
          }
          return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override string ToString() {
          return pb::JsonFormatter.ToDiagnosticString(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void WriteTo(pb::CodedOutputStream output) {
        #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          output.WriteRawMessage(this);
        #else
          if (RowSynced != 0L) {
            output.WriteRawTag(8);
            output.WriteInt64(RowSynced);
          }
          if (TotalSlot != 0L) {
            output.WriteRawTag(16);
            output.WriteInt64(TotalSlot);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        #endif
        }

        #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
          if (RowSynced != 0L) {
            output.WriteRawTag(8);
            output.WriteInt64(RowSynced);
          }
          if (TotalSlot != 0L) {
            output.WriteRawTag(16);
            output.WriteInt64(TotalSlot);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(ref output);
          }
        }
        #endif

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public int CalculateSize() {
          int size = 0;
          if (RowSynced != 0L) {
            size += 1 + pb::CodedOutputStream.ComputeInt64Size(RowSynced);
          }
          if (TotalSlot != 0L) {
            size += 1 + pb::CodedOutputStream.ComputeInt64Size(TotalSlot);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void MergeFrom(SyncSummary other) {
          if (other == null) {
            return;
          }
          if (other.RowSynced != 0L) {
            RowSynced = other.RowSynced;
          }
          if (other.TotalSlot != 0L) {
            TotalSlot = other.TotalSlot;
          }
          _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void MergeFrom(pb::CodedInputStream input) {
        #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          input.ReadRawMessage(this);
        #else
          uint tag;
          while ((tag = input.ReadTag()) != 0) {
            switch(tag) {
              default:
                _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
                break;
              case 8: {
                RowSynced = input.ReadInt64();
                break;
              }
              case 16: {
                TotalSlot = input.ReadInt64();
                break;
              }
            }
          }
        #endif
        }

        #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
          uint tag;
          while ((tag = input.ReadTag()) != 0) {
            switch(tag) {
              default:
                _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
                break;
              case 8: {
                RowSynced = input.ReadInt64();
                break;
              }
              case 16: {
                TotalSlot = input.ReadInt64();
                break;
              }
            }
          }
        }
        #endif

      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
