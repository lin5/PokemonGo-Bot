// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: POGOProtos/Networking/Platform/Responses/JoinEventResponse.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Networking.Platform.Responses {

  /// <summary>Holder for reflection information generated from POGOProtos/Networking/Platform/Responses/JoinEventResponse.proto</summary>
  public static partial class JoinEventResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Networking/Platform/Responses/JoinEventResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static JoinEventResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkBQT0dPUHJvdG9zL05ldHdvcmtpbmcvUGxhdGZvcm0vUmVzcG9uc2VzL0pv",
            "aW5FdmVudFJlc3BvbnNlLnByb3RvEihQT0dPUHJvdG9zLk5ldHdvcmtpbmcu",
            "UGxhdGZvcm0uUmVzcG9uc2VzIqoBChFKb2luRXZlbnRSZXNwb25zZRJSCgZz",
            "dGF0dXMYASABKA4yQi5QT0dPUHJvdG9zLk5ldHdvcmtpbmcuUGxhdGZvcm0u",
            "UmVzcG9uc2VzLkpvaW5FdmVudFJlc3BvbnNlLlN0YXR1cxIOCgZxcmNvZGUY",
            "BCABKAkiMQoGU3RhdHVzEg0KCVVOREVGSU5FRBAAEgsKB1NVQ0NFU1MQARIL",
            "CgdJTlZBTElEEAJiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Networking.Platform.Responses.JoinEventResponse), global::POGOProtos.Networking.Platform.Responses.JoinEventResponse.Parser, new[]{ "Status", "Qrcode" }, null, new[]{ typeof(global::POGOProtos.Networking.Platform.Responses.JoinEventResponse.Types.Status) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class JoinEventResponse : pb::IMessage<JoinEventResponse> {
    private static readonly pb::MessageParser<JoinEventResponse> _parser = new pb::MessageParser<JoinEventResponse>(() => new JoinEventResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<JoinEventResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Networking.Platform.Responses.JoinEventResponseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public JoinEventResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public JoinEventResponse(JoinEventResponse other) : this() {
      status_ = other.status_;
      qrcode_ = other.qrcode_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public JoinEventResponse Clone() {
      return new JoinEventResponse(this);
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 1;
    private global::POGOProtos.Networking.Platform.Responses.JoinEventResponse.Types.Status status_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Networking.Platform.Responses.JoinEventResponse.Types.Status Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "qrcode" field.</summary>
    public const int QrcodeFieldNumber = 4;
    private string qrcode_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Qrcode {
      get { return qrcode_; }
      set {
        qrcode_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as JoinEventResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(JoinEventResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Status != other.Status) return false;
      if (Qrcode != other.Qrcode) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Status != 0) hash ^= Status.GetHashCode();
      if (Qrcode.Length != 0) hash ^= Qrcode.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Status != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Status);
      }
      if (Qrcode.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Qrcode);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Status != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (Qrcode.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Qrcode);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(JoinEventResponse other) {
      if (other == null) {
        return;
      }
      if (other.Status != 0) {
        Status = other.Status;
      }
      if (other.Qrcode.Length != 0) {
        Qrcode = other.Qrcode;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            status_ = (global::POGOProtos.Networking.Platform.Responses.JoinEventResponse.Types.Status) input.ReadEnum();
            break;
          }
          case 34: {
            Qrcode = input.ReadString();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the JoinEventResponse message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum Status {
        [pbr::OriginalName("UNDEFINED")] Undefined = 0,
        [pbr::OriginalName("SUCCESS")] Success = 1,
        [pbr::OriginalName("INVALID")] Invalid = 2,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
