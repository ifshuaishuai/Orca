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

public class RakNetListTableRow : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal RakNetListTableRow(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(RakNetListTableRow obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~RakNetListTableRow() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          SLikeNetPINVOKE.delete_RakNetListTableRow(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

    public Row this[int index]  
    {  
        get   
        {
            return Get((uint)index); // use indexto retrieve and return another value.    
        }  
        set   
        {
            Replace(value, value, (uint)index, "Not used", 0);// use index and value to set the value somewhere.   
        }  
    } 

  public RakNetListTableRow() : this(SLikeNetPINVOKE.new_RakNetListTableRow__SWIG_0(), true) {
  }

  public RakNetListTableRow(RakNetListTableRow original_copy) : this(SLikeNetPINVOKE.new_RakNetListTableRow__SWIG_1(RakNetListTableRow.getCPtr(original_copy)), true) {
    if (SLikeNetPINVOKE.SWIGPendingException.Pending) throw SLikeNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public RakNetListTableRow CopyData(RakNetListTableRow original_copy) {
    RakNetListTableRow ret = new RakNetListTableRow(SLikeNetPINVOKE.RakNetListTableRow_CopyData(swigCPtr, RakNetListTableRow.getCPtr(original_copy)), false);
    if (SLikeNetPINVOKE.SWIGPendingException.Pending) throw SLikeNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Row Get(uint position) {
    Row ret = new Row(SLikeNetPINVOKE.RakNetListTableRow_Get(swigCPtr, position), false);
    return ret;
  }

  public void Push(Row input, string file, uint line) {
    SLikeNetPINVOKE.RakNetListTableRow_Push(swigCPtr, Row.getCPtr(input), file, line);
    if (SLikeNetPINVOKE.SWIGPendingException.Pending) throw SLikeNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public Row Pop() {
    Row ret = new Row(SLikeNetPINVOKE.RakNetListTableRow_Pop(swigCPtr), false);
    return ret;
  }

  public void Insert(Row input, uint position, string file, uint line) {
    SLikeNetPINVOKE.RakNetListTableRow_Insert__SWIG_0(swigCPtr, Row.getCPtr(input), position, file, line);
    if (SLikeNetPINVOKE.SWIGPendingException.Pending) throw SLikeNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Insert(Row input, string file, uint line) {
    SLikeNetPINVOKE.RakNetListTableRow_Insert__SWIG_1(swigCPtr, Row.getCPtr(input), file, line);
    if (SLikeNetPINVOKE.SWIGPendingException.Pending) throw SLikeNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Replace(Row input, Row filler, uint position, string file, uint line) {
    SLikeNetPINVOKE.RakNetListTableRow_Replace__SWIG_0(swigCPtr, Row.getCPtr(input), Row.getCPtr(filler), position, file, line);
    if (SLikeNetPINVOKE.SWIGPendingException.Pending) throw SLikeNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Replace(Row input) {
    SLikeNetPINVOKE.RakNetListTableRow_Replace__SWIG_1(swigCPtr, Row.getCPtr(input));
    if (SLikeNetPINVOKE.SWIGPendingException.Pending) throw SLikeNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAtIndex(uint position) {
    SLikeNetPINVOKE.RakNetListTableRow_RemoveAtIndex(swigCPtr, position);
  }

  public void RemoveAtIndexFast(uint position) {
    SLikeNetPINVOKE.RakNetListTableRow_RemoveAtIndexFast(swigCPtr, position);
  }

  public void RemoveFromEnd(uint num) {
    SLikeNetPINVOKE.RakNetListTableRow_RemoveFromEnd__SWIG_0(swigCPtr, num);
  }

  public void RemoveFromEnd() {
    SLikeNetPINVOKE.RakNetListTableRow_RemoveFromEnd__SWIG_1(swigCPtr);
  }

  public uint Size() {
    uint ret = SLikeNetPINVOKE.RakNetListTableRow_Size(swigCPtr);
    return ret;
  }

  public void Clear(bool doNotDeallocateSmallBlocks, string file, uint line) {
    SLikeNetPINVOKE.RakNetListTableRow_Clear(swigCPtr, doNotDeallocateSmallBlocks, file, line);
  }

  public void Preallocate(uint countNeeded, string file, uint line) {
    SLikeNetPINVOKE.RakNetListTableRow_Preallocate(swigCPtr, countNeeded, file, line);
  }

  public void Compress(string file, uint line) {
    SLikeNetPINVOKE.RakNetListTableRow_Compress(swigCPtr, file, line);
  }

}

}
