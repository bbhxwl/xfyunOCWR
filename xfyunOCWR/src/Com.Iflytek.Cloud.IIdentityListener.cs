using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Iflytek.Cloud.Binbin
{

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.iflytek.cloud']/interface[@name='IdentityListener']"
	[Register ("com/iflytek/cloud/IdentityListener", "", "Com.Iflytek.Cloud.IIdentityListenerInvoker")]
	public partial interface IIdentityListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/interface[@name='IdentityListener']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='com.iflytek.cloud.SpeechError']]"
		[Register ("onError", "(Lcom/iflytek/cloud/SpeechError;)V", "GetOnError_Lcom_iflytek_cloud_SpeechError_Handler:Com.Iflytek.Cloud.IIdentityListenerInvoker, xfyunOCWR")]
		void OnError (global::Com.Iflytek.Cloud.SpeechError p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/interface[@name='IdentityListener']/method[@name='onEvent' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='android.os.Bundle']]"
		[Register ("onEvent", "(IIILandroid/os/Bundle;)V", "GetOnEvent_IIILandroid_os_Bundle_Handler:Com.Iflytek.Cloud.IIdentityListenerInvoker, xfyunOCWR")]
		void OnEvent (int p0, int p1, int p2, global::Android.OS.Bundle p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.cloud']/interface[@name='IdentityListener']/method[@name='onResult' and count(parameter)=2 and parameter[1][@type='com.iflytek.cloud.IdentityResult'] and parameter[2][@type='boolean']]"
		[Register ("onResult", "(Lcom/iflytek/cloud/IdentityResult;Z)V", "GetOnResult_Lcom_iflytek_cloud_IdentityResult_ZHandler:Com.Iflytek.Cloud.IIdentityListenerInvoker, xfyunOCWR")]
		void OnResult (global::Com.Iflytek.Cloud.IdentityResult p0, bool p1);

	}

	[global::Android.Runtime.Register ("com/iflytek/cloud/IdentityListener", DoNotGenerateAcw=true)]
	internal partial class IIdentityListenerInvoker : global::Java.Lang.Object, IIdentityListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/cloud/IdentityListener", typeof (IIdentityListenerInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IIdentityListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IIdentityListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.", JNIEnv.GetClassNameFromInstance (handle), "com.iflytek.cloud.IdentityListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IIdentityListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onError_Lcom_iflytek_cloud_SpeechError_;
#pragma warning disable 0169
		static Delegate GetOnError_Lcom_iflytek_cloud_SpeechError_Handler ()
		{
			if (cb_onError_Lcom_iflytek_cloud_SpeechError_ == null)
				cb_onError_Lcom_iflytek_cloud_SpeechError_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnError_Lcom_iflytek_cloud_SpeechError_);
			return cb_onError_Lcom_iflytek_cloud_SpeechError_;
		}

		static void n_OnError_Lcom_iflytek_cloud_SpeechError_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Binbin.IIdentityListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.SpeechError> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnError (p0);
		}
#pragma warning restore 0169

		IntPtr id_onError_Lcom_iflytek_cloud_SpeechError_;
		public unsafe void OnError (global::Com.Iflytek.Cloud.SpeechError p0)
		{
			if (id_onError_Lcom_iflytek_cloud_SpeechError_ == IntPtr.Zero)
				id_onError_Lcom_iflytek_cloud_SpeechError_ = JNIEnv.GetMethodID (class_ref, "onError", "(Lcom/iflytek/cloud/SpeechError;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onError_Lcom_iflytek_cloud_SpeechError_, __args);
		}

		static Delegate cb_onEvent_IIILandroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetOnEvent_IIILandroid_os_Bundle_Handler ()
		{
			if (cb_onEvent_IIILandroid_os_Bundle_ == null)
				cb_onEvent_IIILandroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIIIL_V) n_OnEvent_IIILandroid_os_Bundle_);
			return cb_onEvent_IIILandroid_os_Bundle_;
		}

		static void n_OnEvent_IIILandroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Binbin.IIdentityListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p3 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.OnEvent (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_onEvent_IIILandroid_os_Bundle_;
		public unsafe void OnEvent (int p0, int p1, int p2, global::Android.OS.Bundle p3)
		{
			if (id_onEvent_IIILandroid_os_Bundle_ == IntPtr.Zero)
				id_onEvent_IIILandroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onEvent", "(IIILandroid/os/Bundle;)V");
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onEvent_IIILandroid_os_Bundle_, __args);
		}

		static Delegate cb_onResult_Lcom_iflytek_cloud_IdentityResult_Z;
#pragma warning disable 0169
		static Delegate GetOnResult_Lcom_iflytek_cloud_IdentityResult_ZHandler ()
		{
			if (cb_onResult_Lcom_iflytek_cloud_IdentityResult_Z == null)
				cb_onResult_Lcom_iflytek_cloud_IdentityResult_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZ_V) n_OnResult_Lcom_iflytek_cloud_IdentityResult_Z);
			return cb_onResult_Lcom_iflytek_cloud_IdentityResult_Z;
		}

		static void n_OnResult_Lcom_iflytek_cloud_IdentityResult_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.Binbin.IIdentityListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Cloud.IdentityResult> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnResult (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onResult_Lcom_iflytek_cloud_IdentityResult_Z;
		public unsafe void OnResult (global::Com.Iflytek.Cloud.IdentityResult p0, bool p1)
		{
			if (id_onResult_Lcom_iflytek_cloud_IdentityResult_Z == IntPtr.Zero)
				id_onResult_Lcom_iflytek_cloud_IdentityResult_Z = JNIEnv.GetMethodID (class_ref, "onResult", "(Lcom/iflytek/cloud/IdentityResult;Z)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onResult_Lcom_iflytek_cloud_IdentityResult_Z, __args);
		}

	}

	// event args for com.iflytek.cloud.IdentityListener.onError
	public partial class ErrorEventArgs : global::System.EventArgs {
		public ErrorEventArgs (global::Com.Iflytek.Cloud.SpeechError p0)
		{
			this.p0 = p0;
		}

		global::Com.Iflytek.Cloud.SpeechError p0;

		public global::Com.Iflytek.Cloud.SpeechError P0 {
			get { return p0; }
		}

	}

	// event args for com.iflytek.cloud.IdentityListener.onEvent
	public partial class EventEventArgs : global::System.EventArgs {
		public EventEventArgs (int p0, int p1, int p2, global::Android.OS.Bundle p3)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
			this.p3 = p3;
		}

		int p0;

		public int P0 {
			get { return p0; }
		}

		int p1;

		public int P1 {
			get { return p1; }
		}

		int p2;

		public int P2 {
			get { return p2; }
		}

		global::Android.OS.Bundle p3;

		public global::Android.OS.Bundle P3 {
			get { return p3; }
		}

	}

	// event args for com.iflytek.cloud.IdentityListener.onResult
	public partial class ResultEventArgs : global::System.EventArgs {
		public ResultEventArgs (global::Com.Iflytek.Cloud.IdentityResult p0, bool p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Com.Iflytek.Cloud.IdentityResult p0;

		public global::Com.Iflytek.Cloud.IdentityResult P0 {
			get { return p0; }
		}

		bool p1;

		public bool P1 {
			get { return p1; }
		}

	}

	[global::Android.Runtime.Register ("mono/com/iflytek/cloud/IdentityListenerImplementor")]
	internal sealed partial class IIdentityListenerImplementor : global::Java.Lang.Object, IIdentityListener {

		object sender;

		public IIdentityListenerImplementor (object sender) : base (global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/iflytek/cloud/IdentityListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

		#pragma warning disable 0649
		public EventHandler<ErrorEventArgs> OnErrorHandler;
		#pragma warning restore 0649

		public void OnError (global::Com.Iflytek.Cloud.SpeechError p0)
		{
			var __h = OnErrorHandler;
			if (__h != null)
				__h (sender, new ErrorEventArgs (p0));
		}

		#pragma warning disable 0649
		public EventHandler<EventEventArgs> OnEventHandler;
		#pragma warning restore 0649

		public void OnEvent (int p0, int p1, int p2, global::Android.OS.Bundle p3)
		{
			var __h = OnEventHandler;
			if (__h != null)
				__h (sender, new EventEventArgs (p0, p1, p2, p3));
		}

		#pragma warning disable 0649
		public EventHandler<ResultEventArgs> OnResultHandler;
		#pragma warning restore 0649

		public void OnResult (global::Com.Iflytek.Cloud.IdentityResult p0, bool p1)
		{
			var __h = OnResultHandler;
			if (__h != null)
				__h (sender, new ResultEventArgs (p0, p1));
		}

		internal static bool __IsEmpty (IIdentityListenerImplementor value)
		{
			return value.OnErrorHandler == null && value.OnEventHandler == null && value.OnResultHandler == null;
		}

	}
}
