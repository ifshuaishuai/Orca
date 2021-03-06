/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.12
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace SLNet {

using System;
using System.Runtime.InteropServices;

public class FullyConnectedMesh2 : PluginInterface2 {
  private HandleRef swigCPtr;

  internal FullyConnectedMesh2(IntPtr cPtr, bool cMemoryOwn) : base(SLikeNetPINVOKE.FullyConnectedMesh2_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(FullyConnectedMesh2 obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~FullyConnectedMesh2() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          SLikeNetPINVOKE.delete_FullyConnectedMesh2(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public static FullyConnectedMesh2 GetInstance() {
    IntPtr cPtr = SLikeNetPINVOKE.FullyConnectedMesh2_GetInstance();
    FullyConnectedMesh2 ret = (cPtr == IntPtr.Zero) ? null : new FullyConnectedMesh2(cPtr, false);
    return ret;
  }

  public static void DestroyInstance(FullyConnectedMesh2 i) {
    SLikeNetPINVOKE.FullyConnectedMesh2_DestroyInstance(FullyConnectedMesh2.getCPtr(i));
  }

  public FullyConnectedMesh2() : this(SLikeNetPINVOKE.new_FullyConnectedMesh2(), true) {
  }

  public void SetConnectOnNewRemoteConnection(bool attemptConnection, RakString pw) {
    SLikeNetPINVOKE.FullyConnectedMesh2_SetConnectOnNewRemoteConnection(swigCPtr, attemptConnection, RakString.getCPtr(pw));
    if (SLikeNetPINVOKE.SWIGPendingException.Pending) throw SLikeNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public RakNetGUID GetConnectedHost() {
    RakNetGUID ret = new RakNetGUID(SLikeNetPINVOKE.FullyConnectedMesh2_GetConnectedHost(swigCPtr), true);
    return ret;
  }

  public SystemAddress GetConnectedHostAddr() {
    SystemAddress ret = new SystemAddress(SLikeNetPINVOKE.FullyConnectedMesh2_GetConnectedHostAddr(swigCPtr), true);
    return ret;
  }

  public RakNetGUID GetHostSystem() {
    RakNetGUID ret = new RakNetGUID(SLikeNetPINVOKE.FullyConnectedMesh2_GetHostSystem(swigCPtr), true);
    return ret;
  }

  public bool IsHostSystem() {
    bool ret = SLikeNetPINVOKE.FullyConnectedMesh2_IsHostSystem(swigCPtr);
    return ret;
  }

  public void GetHostOrder(RakNetListRakNetGUID hostList) {
    SLikeNetPINVOKE.FullyConnectedMesh2_GetHostOrder(swigCPtr, RakNetListRakNetGUID.getCPtr(hostList));
    if (SLikeNetPINVOKE.SWIGPendingException.Pending) throw SLikeNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool IsConnectedHost() {
    bool ret = SLikeNetPINVOKE.FullyConnectedMesh2_IsConnectedHost(swigCPtr);
    return ret;
  }

  public void SetAutoparticipateConnections(bool b) {
    SLikeNetPINVOKE.FullyConnectedMesh2_SetAutoparticipateConnections(swigCPtr, b);
  }

  public void ResetHostCalculation() {
    SLikeNetPINVOKE.FullyConnectedMesh2_ResetHostCalculation(swigCPtr);
  }

  public void AddParticipant(RakNetGUID rakNetGuid) {
    SLikeNetPINVOKE.FullyConnectedMesh2_AddParticipant(swigCPtr, RakNetGUID.getCPtr(rakNetGuid));
    if (SLikeNetPINVOKE.SWIGPendingException.Pending) throw SLikeNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public void GetParticipantList(RakNetListRakNetGUID participantList) {
    SLikeNetPINVOKE.FullyConnectedMesh2_GetParticipantList(swigCPtr, RakNetListRakNetGUID.getCPtr(participantList));
    if (SLikeNetPINVOKE.SWIGPendingException.Pending) throw SLikeNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool HasParticipant(RakNetGUID participantGuid) {
    bool ret = SLikeNetPINVOKE.FullyConnectedMesh2_HasParticipant(swigCPtr, RakNetGUID.getCPtr(participantGuid));
    if (SLikeNetPINVOKE.SWIGPendingException.Pending) throw SLikeNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void ConnectToRemoteNewIncomingConnections(Packet packet) {
    SLikeNetPINVOKE.FullyConnectedMesh2_ConnectToRemoteNewIncomingConnections(swigCPtr, Packet.getCPtr(packet));
  }

  public void Clear() {
    SLikeNetPINVOKE.FullyConnectedMesh2_Clear(swigCPtr);
  }

  public uint GetParticipantCount() {
    uint ret = SLikeNetPINVOKE.FullyConnectedMesh2_GetParticipantCount__SWIG_0(swigCPtr);
    return ret;
  }

  public void GetParticipantCount(SWIGTYPE_p_unsigned_int participantListSize) {
    SLikeNetPINVOKE.FullyConnectedMesh2_GetParticipantCount__SWIG_1(swigCPtr, SWIGTYPE_p_unsigned_int.getCPtr(participantListSize));
  }

  public virtual void StartVerifiedJoin(RakNetGUID client) {
    SLikeNetPINVOKE.FullyConnectedMesh2_StartVerifiedJoin(swigCPtr, RakNetGUID.getCPtr(client));
    if (SLikeNetPINVOKE.SWIGPendingException.Pending) throw SLikeNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void RespondOnVerifiedJoinCapable(Packet packet, bool accept, BitStream additionalData) {
    SLikeNetPINVOKE.FullyConnectedMesh2_RespondOnVerifiedJoinCapable(swigCPtr, Packet.getCPtr(packet), accept, BitStream.getCPtr(additionalData));
  }

  public virtual void GetVerifiedJoinRequiredProcessingList(RakNetGUID host, RakNetListSystemAddress addresses, RakNetListRakNetGUID guids, SWIGTYPE_p_DataStructures__ListT_SLNet__BitStream_p_t userData) {
    SLikeNetPINVOKE.FullyConnectedMesh2_GetVerifiedJoinRequiredProcessingList(swigCPtr, RakNetGUID.getCPtr(host), RakNetListSystemAddress.getCPtr(addresses), RakNetListRakNetGUID.getCPtr(guids), SWIGTYPE_p_DataStructures__ListT_SLNet__BitStream_p_t.getCPtr(userData));
    if (SLikeNetPINVOKE.SWIGPendingException.Pending) throw SLikeNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void GetVerifiedJoinAcceptedAdditionalData(Packet packet, SWIGTYPE_p_bool thisSystemAccepted, RakNetListRakNetGUID systemsAccepted, BitStream additionalData) {
    SLikeNetPINVOKE.FullyConnectedMesh2_GetVerifiedJoinAcceptedAdditionalData(swigCPtr, Packet.getCPtr(packet), SWIGTYPE_p_bool.getCPtr(thisSystemAccepted), RakNetListRakNetGUID.getCPtr(systemsAccepted), BitStream.getCPtr(additionalData));
    if (SLikeNetPINVOKE.SWIGPendingException.Pending) throw SLikeNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void GetVerifiedJoinRejectedAdditionalData(Packet packet, BitStream additionalData) {
    SLikeNetPINVOKE.FullyConnectedMesh2_GetVerifiedJoinRejectedAdditionalData(swigCPtr, Packet.getCPtr(packet), BitStream.getCPtr(additionalData));
  }

  public virtual void WriteVJCUserData(BitStream bsOut) {
    SLikeNetPINVOKE.FullyConnectedMesh2_WriteVJCUserData(swigCPtr, BitStream.getCPtr(bsOut));
  }

  public static void SkipToVJCUserData(BitStream bsIn) {
    SLikeNetPINVOKE.FullyConnectedMesh2_SkipToVJCUserData(BitStream.getCPtr(bsIn));
  }

  public virtual void WriteVJSUserData(BitStream bsOut, RakNetGUID userGuid) {
    SLikeNetPINVOKE.FullyConnectedMesh2_WriteVJSUserData(swigCPtr, BitStream.getCPtr(bsOut), RakNetGUID.getCPtr(userGuid));
    if (SLikeNetPINVOKE.SWIGPendingException.Pending) throw SLikeNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public uint GetTotalConnectionCount() {
    uint ret = SLikeNetPINVOKE.FullyConnectedMesh2_GetTotalConnectionCount(swigCPtr);
    return ret;
  }

  public enum JoinInProgressState {
    JIPS_PROCESSING,
    JIPS_FAILED,
    JIPS_CONNECTED,
    JIPS_UNNECESSARY
  }

}

}
