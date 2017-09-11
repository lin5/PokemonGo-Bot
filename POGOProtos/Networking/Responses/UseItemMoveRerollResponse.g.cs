// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: POGOProtos/Networking/Responses/UseItemMoveRerollResponse.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Networking.Responses {

  /// <summary>Holder for reflection information generated from POGOProtos/Networking/Responses/UseItemMoveRerollResponse.proto</summary>
  public static partial class UseItemMoveRerollResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Networking/Responses/UseItemMoveRerollResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UseItemMoveRerollResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj9QT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVzcG9uc2VzL1VzZUl0ZW1Nb3Zl",
            "UmVyb2xsUmVzcG9uc2UucHJvdG8SH1BPR09Qcm90b3MuTmV0d29ya2luZy5S",
            "ZXNwb25zZXMaIVBPR09Qcm90b3MvRGF0YS9Qb2tlbW9uRGF0YS5wcm90byLB",
            "AgoZVXNlSXRlbU1vdmVSZXJvbGxSZXNwb25zZRJRCgZyZXN1bHQYASABKA4y",
            "QS5QT0dPUHJvdG9zLk5ldHdvcmtpbmcuUmVzcG9uc2VzLlVzZUl0ZW1Nb3Zl",
            "UmVyb2xsUmVzcG9uc2UuUmVzdWx0EjYKEHVwZ3JhZGVkX3Bva2Vtb24YAiAB",
            "KAsyHC5QT0dPUHJvdG9zLkRhdGEuUG9rZW1vbkRhdGEimAEKBlJlc3VsdBIJ",
            "CgVVTlNFVBAAEgsKB1NVQ0NFU1MQARIOCgpOT19QT0tFTU9OEAISEgoOTk9f",
            "T1RIRVJfTU9WRVMQAxINCglOT19QTEFZRVIQBBITCg9XUk9OR19JVEVNX1RZ",
            "UEUQBRIZChVJVEVNX05PVF9JTl9JTlZFTlRPUlkQBhITCg9JTlZBTElEX1BP",
            "S0VNT04QB2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::POGOProtos.Data.PokemonDataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Networking.Responses.UseItemMoveRerollResponse), global::POGOProtos.Networking.Responses.UseItemMoveRerollResponse.Parser, new[]{ "Result", "UpgradedPokemon" }, null, new[]{ typeof(global::POGOProtos.Networking.Responses.UseItemMoveRerollResponse.Types.Result) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class UseItemMoveRerollResponse : pb::IMessage<UseItemMoveRerollResponse> {
    private static readonly pb::MessageParser<UseItemMoveRerollResponse> _parser = new pb::MessageParser<UseItemMoveRerollResponse>(() => new UseItemMoveRerollResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<UseItemMoveRerollResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Networking.Responses.UseItemMoveRerollResponseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UseItemMoveRerollResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UseItemMoveRerollResponse(UseItemMoveRerollResponse other) : this() {
      result_ = other.result_;
      UpgradedPokemon = other.upgradedPokemon_ != null ? other.UpgradedPokemon.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UseItemMoveRerollResponse Clone() {
      return new UseItemMoveRerollResponse(this);
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 1;
    private global::POGOProtos.Networking.Responses.UseItemMoveRerollResponse.Types.Result result_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Networking.Responses.UseItemMoveRerollResponse.Types.Result Result {
      get { return result_; }
      set {
        result_ = value;
      }
    }

    /// <summary>Field number for the "upgraded_pokemon" field.</summary>
    public const int UpgradedPokemonFieldNumber = 2;
    private global::POGOProtos.Data.PokemonData upgradedPokemon_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Data.PokemonData UpgradedPokemon {
      get { return upgradedPokemon_; }
      set {
        upgradedPokemon_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as UseItemMoveRerollResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(UseItemMoveRerollResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Result != other.Result) return false;
      if (!object.Equals(UpgradedPokemon, other.UpgradedPokemon)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Result != 0) hash ^= Result.GetHashCode();
      if (upgradedPokemon_ != null) hash ^= UpgradedPokemon.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Result != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Result);
      }
      if (upgradedPokemon_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(UpgradedPokemon);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Result != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Result);
      }
      if (upgradedPokemon_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(UpgradedPokemon);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(UseItemMoveRerollResponse other) {
      if (other == null) {
        return;
      }
      if (other.Result != 0) {
        Result = other.Result;
      }
      if (other.upgradedPokemon_ != null) {
        if (upgradedPokemon_ == null) {
          upgradedPokemon_ = new global::POGOProtos.Data.PokemonData();
        }
        UpgradedPokemon.MergeFrom(other.UpgradedPokemon);
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
            result_ = (global::POGOProtos.Networking.Responses.UseItemMoveRerollResponse.Types.Result) input.ReadEnum();
            break;
          }
          case 18: {
            if (upgradedPokemon_ == null) {
              upgradedPokemon_ = new global::POGOProtos.Data.PokemonData();
            }
            input.ReadMessage(upgradedPokemon_);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the UseItemMoveRerollResponse message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum Result {
        [pbr::OriginalName("UNSET")] Unset = 0,
        [pbr::OriginalName("SUCCESS")] Success = 1,
        [pbr::OriginalName("NO_POKEMON")] NoPokemon = 2,
        [pbr::OriginalName("NO_OTHER_MOVES")] NoOtherMoves = 3,
        [pbr::OriginalName("NO_PLAYER")] NoPlayer = 4,
        [pbr::OriginalName("WRONG_ITEM_TYPE")] WrongItemType = 5,
        [pbr::OriginalName("ITEM_NOT_IN_INVENTORY")] ItemNotInInventory = 6,
        [pbr::OriginalName("INVALID_POKEMON")] InvalidPokemon = 7,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code