// Generated by protoc-gen-cs, Version=2.4.1.555, Culture=neutral, PublicKeyToken=17b3b1f090c3ea48.  DO NOT EDIT!
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.ProtocolBuffers;
using pbc = global::Google.ProtocolBuffers.Collections;
using pbd = global::Google.ProtocolBuffers.Descriptors;
using scg = global::System.Collections.Generic;
namespace BonreePB {
  
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class PbAgent {
  
    #region Extension registration
    public static void RegisterAllExtensions(pb::ExtensionRegistry registry) {
    }
    #endregion
    #region Static variables
    internal static pbd::MessageDescriptor internal__static_BonreePB_AgentIdentity__Descriptor;
    internal static pb::FieldAccess.FieldAccessorTable<global::BonreePB.AgentIdentity, global::BonreePB.AgentIdentity.Builder> internal__static_BonreePB_AgentIdentity__FieldAccessorTable;
    #endregion
    #region Descriptor
    public static pbd::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbd::FileDescriptor descriptor;
    
    static PbAgent() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg5wYl9hZ2VudC5wcm90bxIIQm9ucmVlUEIijwIKDUFnZW50SWRlbnRpdHkS", 
            "EwoLYWNjb3VudEdVSUQYASABKAkSDwoHYXBwR1VJRBgCIAEoCRITCgtjbHVz", 
            "dGVyR1VJRBgDIAEoCRIQCgh0aWVyR1VJRBgEIAEoCRIQCghub2RlR1VJRBgF", 
            "IAEoCRIRCglhZ2VudEdVSUQYBiABKAkSEQoJYWNjb3VudElEGAcgASgNEg0K", 
            "BWFwcElEGAggASgNEhEKCWNsdXN0ZXJJRBgJIAEoDRIOCgZ0aWVySUQYCiAB", 
            "KA0SDgoGbm9kZUlEGAsgASgNEg8KB2FnZW50SUQYDCABKA0SJgoJYWdlbnRU", 
            "eXBlGA0gASgOMhMuQm9ucmVlUEIuQWdlbnRUeXBlKmwKCUFnZW50VHlwZRIP", 
            "CgtBR0VOVF9ET05FVBABEg4KCkFHRU5UX0pBVkEQAhINCglBR0VOVF9QSFAQ", 
            "AxIQCgxBR0VOVF9QWVRIT04QBBIQCgxBR0VOVF9OT0RFSlMQBRILCgdBR0VO", 
            "VF9DEAZCGQoXY29tLmJvbnJlZS5wcm90b2J1Zi5hcG1KhQ0KBhIEAAAbAQoI", 
            "CgECEgMACBAKCAoBCBIDAQAwCgsKBAjnBwASAwEAMAoMCgUI5wcAAhIDAQcT", 
            "Cg0KBgjnBwACABIDAQcTCg4KBwjnBwACAAESAwEHEwoMCgUI5wcABxIDARYv", 
            "CgoKAgUAEgQDAAoBCgoKAwUAARIDAwUOCgsKBAUAAgASAwQEFgoMCgUFAAIA", 
            "ARIDBAQPCgwKBQUAAgACEgMEFBUKCwoEBQACARIDBQQWCgwKBQUAAgEBEgMF", 
            "BA4KDAoFBQACAQISAwUUFQoLCgQFAAICEgMGBBYKDAoFBQACAgESAwYEDQoM", 
            "CgUFAAICAhIDBhQVCgsKBAUAAgMSAwcEFgoMCgUFAAIDARIDBwQQCgwKBQUA", 
            "AgMCEgMHFBUKCwoEBQACBBIDCAQWCgwKBQUAAgQBEgMIBBAKDAoFBQACBAIS", 
            "AwgUFQoLCgQFAAIFEgMJBBYKDAoFBQACBQESAwkECwoMCgUFAAIFAhIDCRQV", 
            "ChkKAgQAEgQNABsBGg1BZ2VudCDkv6Hmga8KCgoKAwQAARIDDQgVChcKBAQA", 
            "AgASAw4EOiIK5Lqn5ZOBa2V5CgoMCgUEAAIABBIDDgQMCgwKBQQAAgAFEgMO", 
            "DRMKDAoFBAACAAESAw4UHwoMCgUEAAIAAxIDDjg5Ci4KBAQAAgESAw8EOiIh", 
            "5bqU55SoZ3VpZO+8jOeUsWNvbnRyb2xsZXLov5Tlm54KCgwKBQQAAgEEEgMP", 
            "BAwKDAoFBAACAQUSAw8NEwoMCgUEAAIBARIDDxQbCgwKBQQAAgEDEgMPODkK", 
            "LgoEBAACAhIDEAQ6IiHpm4bnvqRndWlk77yM55SxY29udHJvbGxlcui/lOWb", 
            "ngoKDAoFBAACAgQSAxAEDAoMCgUEAAICBRIDEA0TCgwKBQQAAgIBEgMQFB8K", 
            "DAoFBAACAgMSAxA4OQoxCgQEAAIDEgMRBDoiJOWuueWZqOmbhmd1aWTvvIzm", 
            "nIljb250cm9sbGVy6L+U5ZueCgoMCgUEAAIDBBIDEQQMCgwKBQQAAgMFEgMR", 
            "DRMKDAoFBAACAwESAxEUHAoMCgUEAAIDAxIDETg5ChcKBAQAAgQSAxIEOiIK", 
            "bm9kZSBndWlkCgoMCgUEAAIEBBIDEgQMCgwKBQQAAgQFEgMSDRMKDAoFBAAC", 
            "BAESAxIUHAoMCgUEAAIEAxIDEjg5ChgKBAQAAgUSAxMEOiILYWdlbnQgZ3Vp", 
            "ZAoKDAoFBAACBQQSAxMEDAoMCgUEAAIFBRIDEw0TCgwKBQQAAgUBEgMTFB0K", 
            "DAoFBAACBQMSAxM4OQotCgQEAAIGEgMUBDoiIOeUsWNvbnRyb2xsZXLmoLnm", 
            "ja5HVUlE5aGr5LiKaWQKCgwKBQQAAgYEEgMUBAwKDAoFBAACBgUSAxQNEwoM", 
            "CgUEAAIGARIDFBQdCgwKBQQAAgYDEgMUODkKLQoEBAACBxIDFQQ6IiDnlLFj", 
            "b250cm9sbGVy5qC55o2uR1VJROWhq+S4imlkCgoMCgUEAAIHBBIDFQQMCgwK", 
            "BQQAAgcFEgMVDRMKDAoFBAACBwESAxUUGQoMCgUEAAIHAxIDFTg5Ci0KBAQA", 
            "AggSAxYEOiIg55SxY29udHJvbGxlcuagueaNrkdVSUTloavkuIppZAoKDAoF", 
            "BAACCAQSAxYEDAoMCgUEAAIIBRIDFg0TCgwKBQQAAggBEgMWFB0KDAoFBAAC", 
            "CAMSAxY4OQotCgQEAAIJEgMXBDsiIOeUsWNvbnRyb2xsZXLmoLnmja5HVUlE", 
            "5aGr5LiKaWQKCgwKBQQAAgkEEgMXBAwKDAoFBAACCQUSAxcNEwoMCgUEAAIJ", 
            "ARIDFxQaCgwKBQQAAgkDEgMXODoKLQoEBAACChIDGAQ7IiDnlLFjb250cm9s", 
            "bGVy5qC55o2uR1VJROWhq+S4imlkCgoMCgUEAAIKBBIDGAQMCgwKBQQAAgoF", 
            "EgMYDRMKDAoFBAACCgESAxgUGgoMCgUEAAIKAxIDGDg6Ci0KBAQAAgsSAxkE", 
            "OyIg55SxY29udHJvbGxlcuagueaNrkdVSUTloavkuIppZAoKDAoFBAACCwQS", 
            "AxkEDAoMCgUEAAILBRIDGQ0TCgwKBQQAAgsBEgMZFBsKDAoFBAACCwMSAxk4", 
            "OgoZCgQEAAIMEgMaBDsiDGFnZW5057G75Z6LCgoMCgUEAAIMBBIDGgQMCgwK", 
          "BQQAAgwGEgMaDRYKDAoFBAACDAESAxoXIAoMCgUEAAIMAxIDGjg6"));
      pbd::FileDescriptor.InternalDescriptorAssigner assigner = delegate(pbd::FileDescriptor root) {
        descriptor = root;
        internal__static_BonreePB_AgentIdentity__Descriptor = Descriptor.MessageTypes[0];
        internal__static_BonreePB_AgentIdentity__FieldAccessorTable = 
            new pb::FieldAccess.FieldAccessorTable<global::BonreePB.AgentIdentity, global::BonreePB.AgentIdentity.Builder>(internal__static_BonreePB_AgentIdentity__Descriptor,
                new string[] { "AccountGUID", "AppGUID", "ClusterGUID", "TierGUID", "NodeGUID", "AgentGUID", "AccountID", "AppID", "ClusterID", "TierID", "NodeID", "AgentID", "AgentType", });
        pb::ExtensionRegistry registry = pb::ExtensionRegistry.CreateInstance();
        RegisterAllExtensions(registry);
        return registry;
      };
      pbd::FileDescriptor.InternalBuildGeneratedFileFrom(descriptorData,
          new pbd::FileDescriptor[] {
          }, assigner);
    }
    #endregion
    
  }
  #region Enums
  public enum AgentType {
    AGENT_DONET = 1,
    AGENT_JAVA = 2,
    AGENT_PHP = 3,
    AGENT_PYTHON = 4,
    AGENT_NODEJS = 5,
    AGENT_C = 6,
  }
  
  #endregion
  
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class AgentIdentity : pb::GeneratedMessage<AgentIdentity, AgentIdentity.Builder> {
    private AgentIdentity() { }
    private static readonly AgentIdentity defaultInstance = new AgentIdentity().MakeReadOnly();
    private static readonly string[] _agentIdentityFieldNames = new string[] { "accountGUID", "accountID", "agentGUID", "agentID", "agentType", "appGUID", "appID", "clusterGUID", "clusterID", "nodeGUID", "nodeID", "tierGUID", "tierID" };
    private static readonly uint[] _agentIdentityFieldTags = new uint[] { 10, 56, 50, 96, 104, 18, 64, 26, 72, 42, 88, 34, 80 };
    public static AgentIdentity DefaultInstance {
      get { return defaultInstance; }
    }
    
    public override AgentIdentity DefaultInstanceForType {
      get { return DefaultInstance; }
    }
    
    protected override AgentIdentity ThisMessage {
      get { return this; }
    }
    
    public static pbd::MessageDescriptor Descriptor {
      get { return global::BonreePB.PbAgent.internal__static_BonreePB_AgentIdentity__Descriptor; }
    }
    
    protected override pb::FieldAccess.FieldAccessorTable<AgentIdentity, AgentIdentity.Builder> InternalFieldAccessors {
      get { return global::BonreePB.PbAgent.internal__static_BonreePB_AgentIdentity__FieldAccessorTable; }
    }
    
    public const int AccountGUIDFieldNumber = 1;
    private bool hasAccountGUID;
    private string accountGUID_ = "";
    public bool HasAccountGUID {
      get { return hasAccountGUID; }
    }
    public string AccountGUID {
      get { return accountGUID_; }
    }
    
    public const int AppGUIDFieldNumber = 2;
    private bool hasAppGUID;
    private string appGUID_ = "";
    public bool HasAppGUID {
      get { return hasAppGUID; }
    }
    public string AppGUID {
      get { return appGUID_; }
    }
    
    public const int ClusterGUIDFieldNumber = 3;
    private bool hasClusterGUID;
    private string clusterGUID_ = "";
    public bool HasClusterGUID {
      get { return hasClusterGUID; }
    }
    public string ClusterGUID {
      get { return clusterGUID_; }
    }
    
    public const int TierGUIDFieldNumber = 4;
    private bool hasTierGUID;
    private string tierGUID_ = "";
    public bool HasTierGUID {
      get { return hasTierGUID; }
    }
    public string TierGUID {
      get { return tierGUID_; }
    }
    
    public const int NodeGUIDFieldNumber = 5;
    private bool hasNodeGUID;
    private string nodeGUID_ = "";
    public bool HasNodeGUID {
      get { return hasNodeGUID; }
    }
    public string NodeGUID {
      get { return nodeGUID_; }
    }
    
    public const int AgentGUIDFieldNumber = 6;
    private bool hasAgentGUID;
    private string agentGUID_ = "";
    public bool HasAgentGUID {
      get { return hasAgentGUID; }
    }
    public string AgentGUID {
      get { return agentGUID_; }
    }
    
    public const int AccountIDFieldNumber = 7;
    private bool hasAccountID;
    private uint accountID_;
    public bool HasAccountID {
      get { return hasAccountID; }
    }
    [global::System.CLSCompliant(false)]
    public uint AccountID {
      get { return accountID_; }
    }
    
    public const int AppIDFieldNumber = 8;
    private bool hasAppID;
    private uint appID_;
    public bool HasAppID {
      get { return hasAppID; }
    }
    [global::System.CLSCompliant(false)]
    public uint AppID {
      get { return appID_; }
    }
    
    public const int ClusterIDFieldNumber = 9;
    private bool hasClusterID;
    private uint clusterID_;
    public bool HasClusterID {
      get { return hasClusterID; }
    }
    [global::System.CLSCompliant(false)]
    public uint ClusterID {
      get { return clusterID_; }
    }
    
    public const int TierIDFieldNumber = 10;
    private bool hasTierID;
    private uint tierID_;
    public bool HasTierID {
      get { return hasTierID; }
    }
    [global::System.CLSCompliant(false)]
    public uint TierID {
      get { return tierID_; }
    }
    
    public const int NodeIDFieldNumber = 11;
    private bool hasNodeID;
    private uint nodeID_;
    public bool HasNodeID {
      get { return hasNodeID; }
    }
    [global::System.CLSCompliant(false)]
    public uint NodeID {
      get { return nodeID_; }
    }
    
    public const int AgentIDFieldNumber = 12;
    private bool hasAgentID;
    private uint agentID_;
    public bool HasAgentID {
      get { return hasAgentID; }
    }
    [global::System.CLSCompliant(false)]
    public uint AgentID {
      get { return agentID_; }
    }
    
    public const int AgentTypeFieldNumber = 13;
    private bool hasAgentType;
    private global::BonreePB.AgentType agentType_ = global::BonreePB.AgentType.AGENT_DONET;
    public bool HasAgentType {
      get { return hasAgentType; }
    }
    public global::BonreePB.AgentType AgentType {
      get { return agentType_; }
    }
    
    public override bool IsInitialized {
      get {
        return true;
      }
    }
    
    public override void WriteTo(pb::ICodedOutputStream output) {
      CalcSerializedSize();
      string[] field_names = _agentIdentityFieldNames;
      if (hasAccountGUID) {
        output.WriteString(1, field_names[0], AccountGUID);
      }
      if (hasAppGUID) {
        output.WriteString(2, field_names[5], AppGUID);
      }
      if (hasClusterGUID) {
        output.WriteString(3, field_names[7], ClusterGUID);
      }
      if (hasTierGUID) {
        output.WriteString(4, field_names[11], TierGUID);
      }
      if (hasNodeGUID) {
        output.WriteString(5, field_names[9], NodeGUID);
      }
      if (hasAgentGUID) {
        output.WriteString(6, field_names[2], AgentGUID);
      }
      if (hasAccountID) {
        output.WriteUInt32(7, field_names[1], AccountID);
      }
      if (hasAppID) {
        output.WriteUInt32(8, field_names[6], AppID);
      }
      if (hasClusterID) {
        output.WriteUInt32(9, field_names[8], ClusterID);
      }
      if (hasTierID) {
        output.WriteUInt32(10, field_names[12], TierID);
      }
      if (hasNodeID) {
        output.WriteUInt32(11, field_names[10], NodeID);
      }
      if (hasAgentID) {
        output.WriteUInt32(12, field_names[3], AgentID);
      }
      if (hasAgentType) {
        output.WriteEnum(13, field_names[4], (int) AgentType, AgentType);
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
      if (hasAccountGUID) {
        size += pb::CodedOutputStream.ComputeStringSize(1, AccountGUID);
      }
      if (hasAppGUID) {
        size += pb::CodedOutputStream.ComputeStringSize(2, AppGUID);
      }
      if (hasClusterGUID) {
        size += pb::CodedOutputStream.ComputeStringSize(3, ClusterGUID);
      }
      if (hasTierGUID) {
        size += pb::CodedOutputStream.ComputeStringSize(4, TierGUID);
      }
      if (hasNodeGUID) {
        size += pb::CodedOutputStream.ComputeStringSize(5, NodeGUID);
      }
      if (hasAgentGUID) {
        size += pb::CodedOutputStream.ComputeStringSize(6, AgentGUID);
      }
      if (hasAccountID) {
        size += pb::CodedOutputStream.ComputeUInt32Size(7, AccountID);
      }
      if (hasAppID) {
        size += pb::CodedOutputStream.ComputeUInt32Size(8, AppID);
      }
      if (hasClusterID) {
        size += pb::CodedOutputStream.ComputeUInt32Size(9, ClusterID);
      }
      if (hasTierID) {
        size += pb::CodedOutputStream.ComputeUInt32Size(10, TierID);
      }
      if (hasNodeID) {
        size += pb::CodedOutputStream.ComputeUInt32Size(11, NodeID);
      }
      if (hasAgentID) {
        size += pb::CodedOutputStream.ComputeUInt32Size(12, AgentID);
      }
      if (hasAgentType) {
        size += pb::CodedOutputStream.ComputeEnumSize(13, (int) AgentType);
      }
      size += UnknownFields.SerializedSize;
      memoizedSerializedSize = size;
      return size;
    }
    public static AgentIdentity ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static AgentIdentity ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static AgentIdentity ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static AgentIdentity ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static AgentIdentity ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static AgentIdentity ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static AgentIdentity ParseDelimitedFrom(global::System.IO.Stream input) {
      return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }
    public static AgentIdentity ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }
    public static AgentIdentity ParseFrom(pb::ICodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static AgentIdentity ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    private AgentIdentity MakeReadOnly() {
      return this;
    }
    
    public static Builder CreateBuilder() { return new Builder(); }
    public override Builder ToBuilder() { return CreateBuilder(this); }
    public override Builder CreateBuilderForType() { return new Builder(); }
    public static Builder CreateBuilder(AgentIdentity prototype) {
      return new Builder(prototype);
    }
    
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class Builder : pb::GeneratedBuilder<AgentIdentity, Builder> {
      protected override Builder ThisBuilder {
        get { return this; }
      }
      public Builder() {
        result = DefaultInstance;
        resultIsReadOnly = true;
      }
      internal Builder(AgentIdentity cloneFrom) {
        result = cloneFrom;
        resultIsReadOnly = true;
      }
      
      private bool resultIsReadOnly;
      private AgentIdentity result;
      
      private AgentIdentity PrepareBuilder() {
        if (resultIsReadOnly) {
          AgentIdentity original = result;
          result = new AgentIdentity();
          resultIsReadOnly = false;
          MergeFrom(original);
        }
        return result;
      }
      
      public override bool IsInitialized {
        get { return result.IsInitialized; }
      }
      
      protected override AgentIdentity MessageBeingBuilt {
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
        get { return global::BonreePB.AgentIdentity.Descriptor; }
      }
      
      public override AgentIdentity DefaultInstanceForType {
        get { return global::BonreePB.AgentIdentity.DefaultInstance; }
      }
      
      public override AgentIdentity BuildPartial() {
        if (resultIsReadOnly) {
          return result;
        }
        resultIsReadOnly = true;
        return result.MakeReadOnly();
      }
      
      public override Builder MergeFrom(pb::IMessage other) {
        if (other is AgentIdentity) {
          return MergeFrom((AgentIdentity) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }
      
      public override Builder MergeFrom(AgentIdentity other) {
        if (other == global::BonreePB.AgentIdentity.DefaultInstance) return this;
        PrepareBuilder();
        if (other.HasAccountGUID) {
          AccountGUID = other.AccountGUID;
        }
        if (other.HasAppGUID) {
          AppGUID = other.AppGUID;
        }
        if (other.HasClusterGUID) {
          ClusterGUID = other.ClusterGUID;
        }
        if (other.HasTierGUID) {
          TierGUID = other.TierGUID;
        }
        if (other.HasNodeGUID) {
          NodeGUID = other.NodeGUID;
        }
        if (other.HasAgentGUID) {
          AgentGUID = other.AgentGUID;
        }
        if (other.HasAccountID) {
          AccountID = other.AccountID;
        }
        if (other.HasAppID) {
          AppID = other.AppID;
        }
        if (other.HasClusterID) {
          ClusterID = other.ClusterID;
        }
        if (other.HasTierID) {
          TierID = other.TierID;
        }
        if (other.HasNodeID) {
          NodeID = other.NodeID;
        }
        if (other.HasAgentID) {
          AgentID = other.AgentID;
        }
        if (other.HasAgentType) {
          AgentType = other.AgentType;
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
            int field_ordinal = global::System.Array.BinarySearch(_agentIdentityFieldNames, field_name, global::System.StringComparer.Ordinal);
            if(field_ordinal >= 0)
              tag = _agentIdentityFieldTags[field_ordinal];
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
              result.hasAccountGUID = input.ReadString(ref result.accountGUID_);
              break;
            }
            case 18: {
              result.hasAppGUID = input.ReadString(ref result.appGUID_);
              break;
            }
            case 26: {
              result.hasClusterGUID = input.ReadString(ref result.clusterGUID_);
              break;
            }
            case 34: {
              result.hasTierGUID = input.ReadString(ref result.tierGUID_);
              break;
            }
            case 42: {
              result.hasNodeGUID = input.ReadString(ref result.nodeGUID_);
              break;
            }
            case 50: {
              result.hasAgentGUID = input.ReadString(ref result.agentGUID_);
              break;
            }
            case 56: {
              result.hasAccountID = input.ReadUInt32(ref result.accountID_);
              break;
            }
            case 64: {
              result.hasAppID = input.ReadUInt32(ref result.appID_);
              break;
            }
            case 72: {
              result.hasClusterID = input.ReadUInt32(ref result.clusterID_);
              break;
            }
            case 80: {
              result.hasTierID = input.ReadUInt32(ref result.tierID_);
              break;
            }
            case 88: {
              result.hasNodeID = input.ReadUInt32(ref result.nodeID_);
              break;
            }
            case 96: {
              result.hasAgentID = input.ReadUInt32(ref result.agentID_);
              break;
            }
            case 104: {
              object unknown;
              if(input.ReadEnum(ref result.agentType_, out unknown)) {
                result.hasAgentType = true;
              } else if(unknown is int) {
                if (unknownFields == null) {
                  unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
                }
                unknownFields.MergeVarintField(13, (ulong)(int)unknown);
              }
              break;
            }
          }
        }
        
        if (unknownFields != null) {
          this.UnknownFields = unknownFields.Build();
        }
        return this;
      }
      
      
      public bool HasAccountGUID {
        get { return result.hasAccountGUID; }
      }
      public string AccountGUID {
        get { return result.AccountGUID; }
        set { SetAccountGUID(value); }
      }
      public Builder SetAccountGUID(string value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.hasAccountGUID = true;
        result.accountGUID_ = value;
        return this;
      }
      public Builder ClearAccountGUID() {
        PrepareBuilder();
        result.hasAccountGUID = false;
        result.accountGUID_ = "";
        return this;
      }
      
      public bool HasAppGUID {
        get { return result.hasAppGUID; }
      }
      public string AppGUID {
        get { return result.AppGUID; }
        set { SetAppGUID(value); }
      }
      public Builder SetAppGUID(string value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.hasAppGUID = true;
        result.appGUID_ = value;
        return this;
      }
      public Builder ClearAppGUID() {
        PrepareBuilder();
        result.hasAppGUID = false;
        result.appGUID_ = "";
        return this;
      }
      
      public bool HasClusterGUID {
        get { return result.hasClusterGUID; }
      }
      public string ClusterGUID {
        get { return result.ClusterGUID; }
        set { SetClusterGUID(value); }
      }
      public Builder SetClusterGUID(string value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.hasClusterGUID = true;
        result.clusterGUID_ = value;
        return this;
      }
      public Builder ClearClusterGUID() {
        PrepareBuilder();
        result.hasClusterGUID = false;
        result.clusterGUID_ = "";
        return this;
      }
      
      public bool HasTierGUID {
        get { return result.hasTierGUID; }
      }
      public string TierGUID {
        get { return result.TierGUID; }
        set { SetTierGUID(value); }
      }
      public Builder SetTierGUID(string value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.hasTierGUID = true;
        result.tierGUID_ = value;
        return this;
      }
      public Builder ClearTierGUID() {
        PrepareBuilder();
        result.hasTierGUID = false;
        result.tierGUID_ = "";
        return this;
      }
      
      public bool HasNodeGUID {
        get { return result.hasNodeGUID; }
      }
      public string NodeGUID {
        get { return result.NodeGUID; }
        set { SetNodeGUID(value); }
      }
      public Builder SetNodeGUID(string value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.hasNodeGUID = true;
        result.nodeGUID_ = value;
        return this;
      }
      public Builder ClearNodeGUID() {
        PrepareBuilder();
        result.hasNodeGUID = false;
        result.nodeGUID_ = "";
        return this;
      }
      
      public bool HasAgentGUID {
        get { return result.hasAgentGUID; }
      }
      public string AgentGUID {
        get { return result.AgentGUID; }
        set { SetAgentGUID(value); }
      }
      public Builder SetAgentGUID(string value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.hasAgentGUID = true;
        result.agentGUID_ = value;
        return this;
      }
      public Builder ClearAgentGUID() {
        PrepareBuilder();
        result.hasAgentGUID = false;
        result.agentGUID_ = "";
        return this;
      }
      
      public bool HasAccountID {
        get { return result.hasAccountID; }
      }
      [global::System.CLSCompliant(false)]
      public uint AccountID {
        get { return result.AccountID; }
        set { SetAccountID(value); }
      }
      [global::System.CLSCompliant(false)]
      public Builder SetAccountID(uint value) {
        PrepareBuilder();
        result.hasAccountID = true;
        result.accountID_ = value;
        return this;
      }
      public Builder ClearAccountID() {
        PrepareBuilder();
        result.hasAccountID = false;
        result.accountID_ = 0;
        return this;
      }
      
      public bool HasAppID {
        get { return result.hasAppID; }
      }
      [global::System.CLSCompliant(false)]
      public uint AppID {
        get { return result.AppID; }
        set { SetAppID(value); }
      }
      [global::System.CLSCompliant(false)]
      public Builder SetAppID(uint value) {
        PrepareBuilder();
        result.hasAppID = true;
        result.appID_ = value;
        return this;
      }
      public Builder ClearAppID() {
        PrepareBuilder();
        result.hasAppID = false;
        result.appID_ = 0;
        return this;
      }
      
      public bool HasClusterID {
        get { return result.hasClusterID; }
      }
      [global::System.CLSCompliant(false)]
      public uint ClusterID {
        get { return result.ClusterID; }
        set { SetClusterID(value); }
      }
      [global::System.CLSCompliant(false)]
      public Builder SetClusterID(uint value) {
        PrepareBuilder();
        result.hasClusterID = true;
        result.clusterID_ = value;
        return this;
      }
      public Builder ClearClusterID() {
        PrepareBuilder();
        result.hasClusterID = false;
        result.clusterID_ = 0;
        return this;
      }
      
      public bool HasTierID {
        get { return result.hasTierID; }
      }
      [global::System.CLSCompliant(false)]
      public uint TierID {
        get { return result.TierID; }
        set { SetTierID(value); }
      }
      [global::System.CLSCompliant(false)]
      public Builder SetTierID(uint value) {
        PrepareBuilder();
        result.hasTierID = true;
        result.tierID_ = value;
        return this;
      }
      public Builder ClearTierID() {
        PrepareBuilder();
        result.hasTierID = false;
        result.tierID_ = 0;
        return this;
      }
      
      public bool HasNodeID {
        get { return result.hasNodeID; }
      }
      [global::System.CLSCompliant(false)]
      public uint NodeID {
        get { return result.NodeID; }
        set { SetNodeID(value); }
      }
      [global::System.CLSCompliant(false)]
      public Builder SetNodeID(uint value) {
        PrepareBuilder();
        result.hasNodeID = true;
        result.nodeID_ = value;
        return this;
      }
      public Builder ClearNodeID() {
        PrepareBuilder();
        result.hasNodeID = false;
        result.nodeID_ = 0;
        return this;
      }
      
      public bool HasAgentID {
        get { return result.hasAgentID; }
      }
      [global::System.CLSCompliant(false)]
      public uint AgentID {
        get { return result.AgentID; }
        set { SetAgentID(value); }
      }
      [global::System.CLSCompliant(false)]
      public Builder SetAgentID(uint value) {
        PrepareBuilder();
        result.hasAgentID = true;
        result.agentID_ = value;
        return this;
      }
      public Builder ClearAgentID() {
        PrepareBuilder();
        result.hasAgentID = false;
        result.agentID_ = 0;
        return this;
      }
      
      public bool HasAgentType {
       get { return result.hasAgentType; }
      }
      public global::BonreePB.AgentType AgentType {
        get { return result.AgentType; }
        set { SetAgentType(value); }
      }
      public Builder SetAgentType(global::BonreePB.AgentType value) {
        PrepareBuilder();
        result.hasAgentType = true;
        result.agentType_ = value;
        return this;
      }
      public Builder ClearAgentType() {
        PrepareBuilder();
        result.hasAgentType = false;
        result.agentType_ = global::BonreePB.AgentType.AGENT_DONET;
        return this;
      }
    }
    static AgentIdentity() {
      object.ReferenceEquals(global::BonreePB.PbAgent.Descriptor, null);
    }
  }
  
  #endregion
  
}

#endregion Designer generated code