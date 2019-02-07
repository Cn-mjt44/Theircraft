// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: protocol/theircraft.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from protocol/theircraft.proto</summary>
public static partial class TheircraftReflection {

  #region Descriptor
  /// <summary>File descriptor for protocol/theircraft.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static TheircraftReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "Chlwcm90b2NvbC90aGVpcmNyYWZ0LnByb3RvIhYKB1Rlc3RSZXESCwoDbXNn",
          "GAEgASgJIicKB1Rlc3RSZXMSDwoHUmV0Q29kZRgBIAEoBRILCgNtc2cYAiAB",
          "KAliBnByb3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::TestReq), global::TestReq.Parser, new[]{ "Msg" }, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::TestRes), global::TestRes.Parser, new[]{ "RetCode", "Msg" }, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class TestReq : pb::IMessage<TestReq> {
  private static readonly pb::MessageParser<TestReq> _parser = new pb::MessageParser<TestReq>(() => new TestReq());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<TestReq> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::TheircraftReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public TestReq() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public TestReq(TestReq other) : this() {
    msg_ = other.msg_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public TestReq Clone() {
    return new TestReq(this);
  }

  /// <summary>Field number for the "msg" field.</summary>
  public const int MsgFieldNumber = 1;
  private string msg_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Msg {
    get { return msg_; }
    set {
      msg_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as TestReq);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(TestReq other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Msg != other.Msg) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (Msg.Length != 0) hash ^= Msg.GetHashCode();
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
    if (Msg.Length != 0) {
      output.WriteRawTag(10);
      output.WriteString(Msg);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (Msg.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Msg);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(TestReq other) {
    if (other == null) {
      return;
    }
    if (other.Msg.Length != 0) {
      Msg = other.Msg;
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
          Msg = input.ReadString();
          break;
        }
      }
    }
  }

}

public sealed partial class TestRes : pb::IMessage<TestRes> {
  private static readonly pb::MessageParser<TestRes> _parser = new pb::MessageParser<TestRes>(() => new TestRes());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<TestRes> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::TheircraftReflection.Descriptor.MessageTypes[1]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public TestRes() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public TestRes(TestRes other) : this() {
    retCode_ = other.retCode_;
    msg_ = other.msg_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public TestRes Clone() {
    return new TestRes(this);
  }

  /// <summary>Field number for the "RetCode" field.</summary>
  public const int RetCodeFieldNumber = 1;
  private int retCode_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int RetCode {
    get { return retCode_; }
    set {
      retCode_ = value;
    }
  }

  /// <summary>Field number for the "msg" field.</summary>
  public const int MsgFieldNumber = 2;
  private string msg_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Msg {
    get { return msg_; }
    set {
      msg_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as TestRes);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(TestRes other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (RetCode != other.RetCode) return false;
    if (Msg != other.Msg) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (RetCode != 0) hash ^= RetCode.GetHashCode();
    if (Msg.Length != 0) hash ^= Msg.GetHashCode();
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
    if (RetCode != 0) {
      output.WriteRawTag(8);
      output.WriteInt32(RetCode);
    }
    if (Msg.Length != 0) {
      output.WriteRawTag(18);
      output.WriteString(Msg);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (RetCode != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(RetCode);
    }
    if (Msg.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Msg);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(TestRes other) {
    if (other == null) {
      return;
    }
    if (other.RetCode != 0) {
      RetCode = other.RetCode;
    }
    if (other.Msg.Length != 0) {
      Msg = other.Msg;
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
        case 8: {
          RetCode = input.ReadInt32();
          break;
        }
        case 18: {
          Msg = input.ReadString();
          break;
        }
      }
    }
  }

}

#endregion


#endregion Designer generated code
