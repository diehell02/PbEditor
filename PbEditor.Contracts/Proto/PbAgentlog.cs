// Generated by protoc-gen-cs, Version=2.4.1.555, Culture=neutral, PublicKeyToken=17b3b1f090c3ea48.  DO NOT EDIT!
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.ProtocolBuffers;
using pbc = global::Google.ProtocolBuffers.Collections;
using pbd = global::Google.ProtocolBuffers.Descriptors;
using scg = global::System.Collections.Generic;
namespace BonreePB {
  
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class PbAgentlog {
  
    #region Extension registration
    public static void RegisterAllExtensions(pb::ExtensionRegistry registry) {
    }
    #endregion
    #region Static variables
    internal static pbd::MessageDescriptor internal__static_BonreePB_Agentlog__Descriptor;
    internal static pb::FieldAccess.FieldAccessorTable<global::BonreePB.Agentlog, global::BonreePB.Agentlog.Builder> internal__static_BonreePB_Agentlog__FieldAccessorTable;
    internal static pbd::MessageDescriptor internal__static_BonreePB_AgentlogReq__Descriptor;
    internal static pb::FieldAccess.FieldAccessorTable<global::BonreePB.AgentlogReq, global::BonreePB.AgentlogReq.Builder> internal__static_BonreePB_AgentlogReq__FieldAccessorTable;
    #endregion
    #region Descriptor
    public static pbd::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbd::FileDescriptor descriptor;
    
    static PbAgentlog() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFwYl9hZ2VudGxvZy5wcm90bxIIQm9ucmVlUEIaDnBiX2FnZW50LnByb3Rv", 
            "IkcKCEFnZW50bG9nEhEKCXRpbWVTdGFtcBgBIAEoBBITCgtlcnJvclN1bWFy", 
            "eRgCIAEoCRITCgtzdGFja1RyYWNlcxgDIAEoCSJfCgtBZ2VudGxvZ1JlcRIu", 
            "Cg1hZ2VudElkZW50aXR5GAEgASgLMhcuQm9ucmVlUEIuQWdlbnRJZGVudGl0", 
            "eRIgCgRsb2dzGAIgAygLMhIuQm9ucmVlUEIuQWdlbnRsb2dCGQoXY29tLmJv", 
            "bnJlZS5wcm90b2J1Zi5hcG1K7gQKBhIEAAAQAQoICgECEgMACBAKCAoBCBID", 
            "AQAwCgsKBAjnBwASAwEAMAoMCgUI5wcAAhIDAQcTCg0KBgjnBwACABIDAQcT", 
            "Cg4KBwjnBwACAAESAwEHEwoMCgUI5wcABxIDARYvCgkKAgMAEgMDBxcKHgoC", 
            "BAASBAYACgEaEmFnZW506ZSZ6K+v5L+h5oGvCgoKCgMEAAESAwYIEAogCgQE", 
            "AAIAEgMHBCoiE+mUmeivr+WPkeeUn+aXtumXtAoKDAoFBAACAAQSAwcEDAoM", 
            "CgUEAAIABRIDBw0TCgwKBQQAAgABEgMHFB0KDAoFBAACAAMSAwcoKQoaCgQE", 
            "AAIBEgMIBCoiDemUmeivr+amguimgQoKDAoFBAACAQQSAwgEDAoMCgUEAAIB", 
            "BRIDCA0TCgwKBQQAAgEBEgMIFB8KDAoFBAACAQMSAwgoKQoaCgQEAAICEgMJ", 
            "BCoiDemUmeivr+WghuagiAoKDAoFBAACAgQSAwkEDAoMCgUEAAICBRIDCQ0T", 
            "CgwKBQQAAgIBEgMJFB8KDAoFBAACAgMSAwkoKQofCgIEARIEDQAQARoT5LiK", 
            "5Lyg5pel5b+X6K+35rGCCgoKCgMEAQESAw0IEwocCgQEAQIAEgMOBC4iD2Fn", 
            "ZW50IGlkZW50aXR5CgoMCgUEAQIABBIDDgQMCgwKBQQBAgAGEgMODRoKDAoF", 
            "BAECAAESAw4bKAoMCgUEAQIAAxIDDiwtChQKBAQBAgESAw8ELiIH5pel5b+X", 
            "CgoMCgUEAQIBBBIDDwQMCgwKBQQBAgEGEgMPDRUKDAoFBAECAQESAw8WGgoM", 
          "CgUEAQIBAxIDDywt"));
      pbd::FileDescriptor.InternalDescriptorAssigner assigner = delegate(pbd::FileDescriptor root) {
        descriptor = root;
        internal__static_BonreePB_Agentlog__Descriptor = Descriptor.MessageTypes[0];
        internal__static_BonreePB_Agentlog__FieldAccessorTable = 
            new pb::FieldAccess.FieldAccessorTable<global::BonreePB.Agentlog, global::BonreePB.Agentlog.Builder>(internal__static_BonreePB_Agentlog__Descriptor,
                new string[] { "TimeStamp", "ErrorSumary", "StackTraces", });
        internal__static_BonreePB_AgentlogReq__Descriptor = Descriptor.MessageTypes[1];
        internal__static_BonreePB_AgentlogReq__FieldAccessorTable = 
            new pb::FieldAccess.FieldAccessorTable<global::BonreePB.AgentlogReq, global::BonreePB.AgentlogReq.Builder>(internal__static_BonreePB_AgentlogReq__Descriptor,
                new string[] { "AgentIdentity", "Logs", });
        pb::ExtensionRegistry registry = pb::ExtensionRegistry.CreateInstance();
        RegisterAllExtensions(registry);
        global::BonreePB.PbAgent.RegisterAllExtensions(registry);
        return registry;
      };
      pbd::FileDescriptor.InternalBuildGeneratedFileFrom(descriptorData,
          new pbd::FileDescriptor[] {
          global::BonreePB.PbAgent.Descriptor, 
          }, assigner);
    }
    #endregion
    
  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class Agentlog : pb::GeneratedMessage<Agentlog, Agentlog.Builder> {
    private Agentlog() { }
    private static readonly Agentlog defaultInstance = new Agentlog().MakeReadOnly();
    private static readonly string[] _agentlogFieldNames = new string[] { "errorSumary", "stackTraces", "timeStamp" };
    private static readonly uint[] _agentlogFieldTags = new uint[] { 18, 26, 8 };
    public static Agentlog DefaultInstance {
      get { return defaultInstance; }
    }
    
    public override Agentlog DefaultInstanceForType {
      get { return DefaultInstance; }
    }
    
    protected override Agentlog ThisMessage {
      get { return this; }
    }
    
    public static pbd::MessageDescriptor Descriptor {
      get { return global::BonreePB.PbAgentlog.internal__static_BonreePB_Agentlog__Descriptor; }
    }
    
    protected override pb::FieldAccess.FieldAccessorTable<Agentlog, Agentlog.Builder> InternalFieldAccessors {
      get { return global::BonreePB.PbAgentlog.internal__static_BonreePB_Agentlog__FieldAccessorTable; }
    }
    
    public const int TimeStampFieldNumber = 1;
    private bool hasTimeStamp;
    private ulong timeStamp_;
    public bool HasTimeStamp {
      get { return hasTimeStamp; }
    }
    [global::System.CLSCompliant(false)]
    public ulong TimeStamp {
      get { return timeStamp_; }
    }
    
    public const int ErrorSumaryFieldNumber = 2;
    private bool hasErrorSumary;
    private string errorSumary_ = "";
    public bool HasErrorSumary {
      get { return hasErrorSumary; }
    }
    public string ErrorSumary {
      get { return errorSumary_; }
    }
    
    public const int StackTracesFieldNumber = 3;
    private bool hasStackTraces;
    private string stackTraces_ = "";
    public bool HasStackTraces {
      get { return hasStackTraces; }
    }
    public string StackTraces {
      get { return stackTraces_; }
    }
    
    public override bool IsInitialized {
      get {
        return true;
      }
    }
    
    public override void WriteTo(pb::ICodedOutputStream output) {
      CalcSerializedSize();
      string[] field_names = _agentlogFieldNames;
      if (hasTimeStamp) {
        output.WriteUInt64(1, field_names[2], TimeStamp);
      }
      if (hasErrorSumary) {
        output.WriteString(2, field_names[0], ErrorSumary);
      }
      if (hasStackTraces) {
        output.WriteString(3, field_names[1], StackTraces);
      }
      UnknownFields.WriteTo(output);
    }
    
    private int memoizedSerializedSize = -1;
    public override int SerializedSize {
      get {
        int size = memoizedSerializedSize;
        if (size != -1) return size;
        return CalcSerializedSize();
      }
    }
    
    private int CalcSerializedSize() {
      int size = memoizedSerializedSize;
      if (size != -1) return size;
      
      size = 0;
      if (hasTimeStamp) {
        size += pb::CodedOutputStream.ComputeUInt64Size(1, TimeStamp);
      }
      if (hasErrorSumary) {
        size += pb::CodedOutputStream.ComputeStringSize(2, ErrorSumary);
      }
      if (hasStackTraces) {
        size += pb::CodedOutputStream.ComputeStringSize(3, StackTraces);
      }
      size += UnknownFields.SerializedSize;
      memoizedSerializedSize = size;
      return size;
    }
    public static Agentlog ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static Agentlog ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static Agentlog ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static Agentlog ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static Agentlog ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static Agentlog ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static Agentlog ParseDelimitedFrom(global::System.IO.Stream input) {
      return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }
    public static Agentlog ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }
    public static Agentlog ParseFrom(pb::ICodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static Agentlog ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    private Agentlog MakeReadOnly() {
      return this;
    }
    
    public static Builder CreateBuilder() { return new Builder(); }
    public override Builder ToBuilder() { return CreateBuilder(this); }
    public override Builder CreateBuilderForType() { return new Builder(); }
    public static Builder CreateBuilder(Agentlog prototype) {
      return new Builder(prototype);
    }
    
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class Builder : pb::GeneratedBuilder<Agentlog, Builder> {
      protected override Builder ThisBuilder {
        get { return this; }
      }
      public Builder() {
        result = DefaultInstance;
        resultIsReadOnly = true;
      }
      internal Builder(Agentlog cloneFrom) {
        result = cloneFrom;
        resultIsReadOnly = true;
      }
      
      private bool resultIsReadOnly;
      private Agentlog result;
      
      private Agentlog PrepareBuilder() {
        if (resultIsReadOnly) {
          Agentlog original = result;
          result = new Agentlog();
          resultIsReadOnly = false;
          MergeFrom(original);
        }
        return result;
      }
      
      public override bool IsInitialized {
        get { return result.IsInitialized; }
      }
      
      protected override Agentlog MessageBeingBuilt {
        get { return PrepareBuilder(); }
      }
      
      public override Builder Clear() {
        result = DefaultInstance;
        resultIsReadOnly = true;
        return this;
      }
      
      public override Builder Clone() {
        if (resultIsReadOnly) {
          return new Builder(result);
        } else {
          return new Builder().MergeFrom(result);
        }
      }
      
      public override pbd::MessageDescriptor DescriptorForType {
        get { return global::BonreePB.Agentlog.Descriptor; }
      }
      
      public override Agentlog DefaultInstanceForType {
        get { return global::BonreePB.Agentlog.DefaultInstance; }
      }
      
      public override Agentlog BuildPartial() {
        if (resultIsReadOnly) {
          return result;
        }
        resultIsReadOnly = true;
        return result.MakeReadOnly();
      }
      
      public override Builder MergeFrom(pb::IMessage other) {
        if (other is Agentlog) {
          return MergeFrom((Agentlog) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }
      
      public override Builder MergeFrom(Agentlog other) {
        if (other == global::BonreePB.Agentlog.DefaultInstance) return this;
        PrepareBuilder();
        if (other.HasTimeStamp) {
          TimeStamp = other.TimeStamp;
        }
        if (other.HasErrorSumary) {
          ErrorSumary = other.ErrorSumary;
        }
        if (other.HasStackTraces) {
          StackTraces = other.StackTraces;
        }
        this.MergeUnknownFields(other.UnknownFields);
        return this;
      }
      
      public override Builder MergeFrom(pb::ICodedInputStream input) {
        return MergeFrom(input, pb::ExtensionRegistry.Empty);
      }
      
      public override Builder MergeFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
        PrepareBuilder();
        pb::UnknownFieldSet.Builder unknownFields = null;
        uint tag;
        string field_name;
        while (input.ReadTag(out tag, out field_name)) {
          if(tag == 0 && field_name != null) {
            int field_ordinal = global::System.Array.BinarySearch(_agentlogFieldNames, field_name, global::System.StringComparer.Ordinal);
            if(field_ordinal >= 0)
              tag = _agentlogFieldTags[field_ordinal];
            else {
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
              continue;
            }
          }
          switch (tag) {
            case 0: {
              throw pb::InvalidProtocolBufferException.InvalidTag();
            }
            default: {
              if (pb::WireFormat.IsEndGroupTag(tag)) {
                if (unknownFields != null) {
                  this.UnknownFields = unknownFields.Build();
                }
                return this;
              }
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
              break;
            }
            case 8: {
              result.hasTimeStamp = input.ReadUInt64(ref result.timeStamp_);
              break;
            }
            case 18: {
              result.hasErrorSumary = input.ReadString(ref result.errorSumary_);
              break;
            }
            case 26: {
              result.hasStackTraces = input.ReadString(ref result.stackTraces_);
              break;
            }
          }
        }
        
        if (unknownFields != null) {
          this.UnknownFields = unknownFields.Build();
        }
        return this;
      }
      
      
      public bool HasTimeStamp {
        get { return result.hasTimeStamp; }
      }
      [global::System.CLSCompliant(false)]
      public ulong TimeStamp {
        get { return result.TimeStamp; }
        set { SetTimeStamp(value); }
      }
      [global::System.CLSCompliant(false)]
      public Builder SetTimeStamp(ulong value) {
        PrepareBuilder();
        result.hasTimeStamp = true;
        result.timeStamp_ = value;
        return this;
      }
      public Builder ClearTimeStamp() {
        PrepareBuilder();
        result.hasTimeStamp = false;
        result.timeStamp_ = 0UL;
        return this;
      }
      
      public bool HasErrorSumary {
        get { return result.hasErrorSumary; }
      }
      public string ErrorSumary {
        get { return result.ErrorSumary; }
        set { SetErrorSumary(value); }
      }
      public Builder SetErrorSumary(string value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.hasErrorSumary = true;
        result.errorSumary_ = value;
        return this;
      }
      public Builder ClearErrorSumary() {
        PrepareBuilder();
        result.hasErrorSumary = false;
        result.errorSumary_ = "";
        return this;
      }
      
      public bool HasStackTraces {
        get { return result.hasStackTraces; }
      }
      public string StackTraces {
        get { return result.StackTraces; }
        set { SetStackTraces(value); }
      }
      public Builder SetStackTraces(string value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.hasStackTraces = true;
        result.stackTraces_ = value;
        return this;
      }
      public Builder ClearStackTraces() {
        PrepareBuilder();
        result.hasStackTraces = false;
        result.stackTraces_ = "";
        return this;
      }
    }
    static Agentlog() {
      object.ReferenceEquals(global::BonreePB.PbAgentlog.Descriptor, null);
    }
  }
  
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class AgentlogReq : pb::GeneratedMessage<AgentlogReq, AgentlogReq.Builder> {
    private AgentlogReq() { }
    private static readonly AgentlogReq defaultInstance = new AgentlogReq().MakeReadOnly();
    private static readonly string[] _agentlogReqFieldNames = new string[] { "agentIdentity", "logs" };
    private static readonly uint[] _agentlogReqFieldTags = new uint[] { 10, 18 };
    public static AgentlogReq DefaultInstance {
      get { return defaultInstance; }
    }
    
    public override AgentlogReq DefaultInstanceForType {
      get { return DefaultInstance; }
    }
    
    protected override AgentlogReq ThisMessage {
      get { return this; }
    }
    
    public static pbd::MessageDescriptor Descriptor {
      get { return global::BonreePB.PbAgentlog.internal__static_BonreePB_AgentlogReq__Descriptor; }
    }
    
    protected override pb::FieldAccess.FieldAccessorTable<AgentlogReq, AgentlogReq.Builder> InternalFieldAccessors {
      get { return global::BonreePB.PbAgentlog.internal__static_BonreePB_AgentlogReq__FieldAccessorTable; }
    }
    
    public const int AgentIdentityFieldNumber = 1;
    private bool hasAgentIdentity;
    private global::BonreePB.AgentIdentity agentIdentity_;
    public bool HasAgentIdentity {
      get { return hasAgentIdentity; }
    }
    public global::BonreePB.AgentIdentity AgentIdentity {
      get { return agentIdentity_ ?? global::BonreePB.AgentIdentity.DefaultInstance; }
    }
    
    public const int LogsFieldNumber = 2;
    private pbc::PopsicleList<global::BonreePB.Agentlog> logs_ = new pbc::PopsicleList<global::BonreePB.Agentlog>();
    public scg::IList<global::BonreePB.Agentlog> LogsList {
      get { return logs_; }
    }
    public int LogsCount {
      get { return logs_.Count; }
    }
    public global::BonreePB.Agentlog GetLogs(int index) {
      return logs_[index];
    }
    
    public override bool IsInitialized {
      get {
        return true;
      }
    }
    
    public override void WriteTo(pb::ICodedOutputStream output) {
      CalcSerializedSize();
      string[] field_names = _agentlogReqFieldNames;
      if (hasAgentIdentity) {
        output.WriteMessage(1, field_names[0], AgentIdentity);
      }
      if (logs_.Count > 0) {
        output.WriteMessageArray(2, field_names[1], logs_);
      }
      UnknownFields.WriteTo(output);
    }
    
    private int memoizedSerializedSize = -1;
    public override int SerializedSize {
      get {
        int size = memoizedSerializedSize;
        if (size != -1) return size;
        return CalcSerializedSize();
      }
    }
    
    private int CalcSerializedSize() {
      int size = memoizedSerializedSize;
      if (size != -1) return size;
      
      size = 0;
      if (hasAgentIdentity) {
        size += pb::CodedOutputStream.ComputeMessageSize(1, AgentIdentity);
      }
      foreach (global::BonreePB.Agentlog element in LogsList) {
        size += pb::CodedOutputStream.ComputeMessageSize(2, element);
      }
      size += UnknownFields.SerializedSize;
      memoizedSerializedSize = size;
      return size;
    }
    public static AgentlogReq ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static AgentlogReq ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static AgentlogReq ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static AgentlogReq ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static AgentlogReq ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static AgentlogReq ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static AgentlogReq ParseDelimitedFrom(global::System.IO.Stream input) {
      return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }
    public static AgentlogReq ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }
    public static AgentlogReq ParseFrom(pb::ICodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static AgentlogReq ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    private AgentlogReq MakeReadOnly() {
      logs_.MakeReadOnly();
      return this;
    }
    
    public static Builder CreateBuilder() { return new Builder(); }
    public override Builder ToBuilder() { return CreateBuilder(this); }
    public override Builder CreateBuilderForType() { return new Builder(); }
    public static Builder CreateBuilder(AgentlogReq prototype) {
      return new Builder(prototype);
    }
    
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class Builder : pb::GeneratedBuilder<AgentlogReq, Builder> {
      protected override Builder ThisBuilder {
        get { return this; }
      }
      public Builder() {
        result = DefaultInstance;
        resultIsReadOnly = true;
      }
      internal Builder(AgentlogReq cloneFrom) {
        result = cloneFrom;
        resultIsReadOnly = true;
      }
      
      private bool resultIsReadOnly;
      private AgentlogReq result;
      
      private AgentlogReq PrepareBuilder() {
        if (resultIsReadOnly) {
          AgentlogReq original = result;
          result = new AgentlogReq();
          resultIsReadOnly = false;
          MergeFrom(original);
        }
        return result;
      }
      
      public override bool IsInitialized {
        get { return result.IsInitialized; }
      }
      
      protected override AgentlogReq MessageBeingBuilt {
        get { return PrepareBuilder(); }
      }
      
      public override Builder Clear() {
        result = DefaultInstance;
        resultIsReadOnly = true;
        return this;
      }
      
      public override Builder Clone() {
        if (resultIsReadOnly) {
          return new Builder(result);
        } else {
          return new Builder().MergeFrom(result);
        }
      }
      
      public override pbd::MessageDescriptor DescriptorForType {
        get { return global::BonreePB.AgentlogReq.Descriptor; }
      }
      
      public override AgentlogReq DefaultInstanceForType {
        get { return global::BonreePB.AgentlogReq.DefaultInstance; }
      }
      
      public override AgentlogReq BuildPartial() {
        if (resultIsReadOnly) {
          return result;
        }
        resultIsReadOnly = true;
        return result.MakeReadOnly();
      }
      
      public override Builder MergeFrom(pb::IMessage other) {
        if (other is AgentlogReq) {
          return MergeFrom((AgentlogReq) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }
      
      public override Builder MergeFrom(AgentlogReq other) {
        if (other == global::BonreePB.AgentlogReq.DefaultInstance) return this;
        PrepareBuilder();
        if (other.HasAgentIdentity) {
          MergeAgentIdentity(other.AgentIdentity);
        }
        if (other.logs_.Count != 0) {
          result.logs_.Add(other.logs_);
        }
        this.MergeUnknownFields(other.UnknownFields);
        return this;
      }
      
      public override Builder MergeFrom(pb::ICodedInputStream input) {
        return MergeFrom(input, pb::ExtensionRegistry.Empty);
      }
      
      public override Builder MergeFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
        PrepareBuilder();
        pb::UnknownFieldSet.Builder unknownFields = null;
        uint tag;
        string field_name;
        while (input.ReadTag(out tag, out field_name)) {
          if(tag == 0 && field_name != null) {
            int field_ordinal = global::System.Array.BinarySearch(_agentlogReqFieldNames, field_name, global::System.StringComparer.Ordinal);
            if(field_ordinal >= 0)
              tag = _agentlogReqFieldTags[field_ordinal];
            else {
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
              continue;
            }
          }
          switch (tag) {
            case 0: {
              throw pb::InvalidProtocolBufferException.InvalidTag();
            }
            default: {
              if (pb::WireFormat.IsEndGroupTag(tag)) {
                if (unknownFields != null) {
                  this.UnknownFields = unknownFields.Build();
                }
                return this;
              }
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
              break;
            }
            case 10: {
              global::BonreePB.AgentIdentity.Builder subBuilder = global::BonreePB.AgentIdentity.CreateBuilder();
              if (result.hasAgentIdentity) {
                subBuilder.MergeFrom(AgentIdentity);
              }
              input.ReadMessage(subBuilder, extensionRegistry);
              AgentIdentity = subBuilder.BuildPartial();
              break;
            }
            case 18: {
              input.ReadMessageArray(tag, field_name, result.logs_, global::BonreePB.Agentlog.DefaultInstance, extensionRegistry);
              break;
            }
          }
        }
        
        if (unknownFields != null) {
          this.UnknownFields = unknownFields.Build();
        }
        return this;
      }
      
      
      public bool HasAgentIdentity {
       get { return result.hasAgentIdentity; }
      }
      public global::BonreePB.AgentIdentity AgentIdentity {
        get { return result.AgentIdentity; }
        set { SetAgentIdentity(value); }
      }
      public Builder SetAgentIdentity(global::BonreePB.AgentIdentity value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.hasAgentIdentity = true;
        result.agentIdentity_ = value;
        return this;
      }
      public Builder SetAgentIdentity(global::BonreePB.AgentIdentity.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        PrepareBuilder();
        result.hasAgentIdentity = true;
        result.agentIdentity_ = builderForValue.Build();
        return this;
      }
      public Builder MergeAgentIdentity(global::BonreePB.AgentIdentity value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        if (result.hasAgentIdentity &&
            result.agentIdentity_ != global::BonreePB.AgentIdentity.DefaultInstance) {
            result.agentIdentity_ = global::BonreePB.AgentIdentity.CreateBuilder(result.agentIdentity_).MergeFrom(value).BuildPartial();
        } else {
          result.agentIdentity_ = value;
        }
        result.hasAgentIdentity = true;
        return this;
      }
      public Builder ClearAgentIdentity() {
        PrepareBuilder();
        result.hasAgentIdentity = false;
        result.agentIdentity_ = null;
        return this;
      }
      
      public pbc::IPopsicleList<global::BonreePB.Agentlog> LogsList {
        get { return PrepareBuilder().logs_; }
      }
      public int LogsCount {
        get { return result.LogsCount; }
      }
      public global::BonreePB.Agentlog GetLogs(int index) {
        return result.GetLogs(index);
      }
      public Builder SetLogs(int index, global::BonreePB.Agentlog value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.logs_[index] = value;
        return this;
      }
      public Builder SetLogs(int index, global::BonreePB.Agentlog.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        PrepareBuilder();
        result.logs_[index] = builderForValue.Build();
        return this;
      }
      public Builder AddLogs(global::BonreePB.Agentlog value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.logs_.Add(value);
        return this;
      }
      public Builder AddLogs(global::BonreePB.Agentlog.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        PrepareBuilder();
        result.logs_.Add(builderForValue.Build());
        return this;
      }
      public Builder AddRangeLogs(scg::IEnumerable<global::BonreePB.Agentlog> values) {
        PrepareBuilder();
        result.logs_.Add(values);
        return this;
      }
      public Builder ClearLogs() {
        PrepareBuilder();
        result.logs_.Clear();
        return this;
      }
    }
    static AgentlogReq() {
      object.ReferenceEquals(global::BonreePB.PbAgentlog.Descriptor, null);
    }
  }
  
  #endregion
  
}

#endregion Designer generated code