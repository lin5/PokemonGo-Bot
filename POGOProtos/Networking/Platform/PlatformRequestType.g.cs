// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: POGOProtos/Networking/Platform/PlatformRequestType.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Networking.Platform {

  /// <summary>Holder for reflection information generated from POGOProtos/Networking/Platform/PlatformRequestType.proto</summary>
  public static partial class PlatformRequestTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Networking/Platform/PlatformRequestType.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PlatformRequestTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjhQT0dPUHJvdG9zL05ldHdvcmtpbmcvUGxhdGZvcm0vUGxhdGZvcm1SZXF1",
            "ZXN0VHlwZS5wcm90bxIeUE9HT1Byb3Rvcy5OZXR3b3JraW5nLlBsYXRmb3Jt",
            "Kq0BChNQbGF0Zm9ybVJlcXVlc3RUeXBlEhAKDE1FVEhPRF9VTlNFVBAAEhYK",
            "EkJVWV9JVEVNX1BPS0VDT0lOUxACEhQKEEJVWV9JVEVNX0FORFJPSUQQAxIQ",
            "CgxCVVlfSVRFTV9JT1MQBBITCg9HRVRfU1RPUkVfSVRFTVMQBRIcChhTRU5E",
            "X0VOQ1JZUFRFRF9TSUdOQVRVUkUQBhIRCg1VTktOT1dOX1BUUl84EAhiBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::POGOProtos.Networking.Platform.PlatformRequestType), }, null));
    }
    #endregion

  }
  #region Enums
  public enum PlatformRequestType {
    [pbr::OriginalName("METHOD_UNSET")] MethodUnset = 0,
    [pbr::OriginalName("BUY_ITEM_POKECOINS")] BuyItemPokecoins = 2,
    [pbr::OriginalName("BUY_ITEM_ANDROID")] BuyItemAndroid = 3,
    [pbr::OriginalName("BUY_ITEM_IOS")] BuyItemIos = 4,
    [pbr::OriginalName("GET_STORE_ITEMS")] GetStoreItems = 5,
    [pbr::OriginalName("SEND_ENCRYPTED_SIGNATURE")] SendEncryptedSignature = 6,
    [pbr::OriginalName("UNKNOWN_PTR_8")] UnknownPtr8 = 8,
  }

  #endregion

}

#endregion Designer generated code