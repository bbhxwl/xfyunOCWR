using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Iflytek.Speech.Aidl {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='ISpeechUnderstander.Default']"
	[global::Android.Runtime.Register ("com/iflytek/speech/aidl/ISpeechUnderstander$Default", DoNotGenerateAcw=true)]
	public partial class SpeechUnderstanderDefault : global::Java.Lang.Object, global::Com.Iflytek.Speech.Aidl.ISpeechUnderstander {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/speech/aidl/ISpeechUnderstander$Default", typeof (SpeechUnderstanderDefault));

		internal static IntPtr class_ref {
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
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected SpeechUnderstanderDefault (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='ISpeechUnderstander.Default']/constructor[@name='ISpeechUnderstander.Default' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SpeechUnderstanderDefault () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_isUnderstanding;
#pragma warning disable 0169
		static Delegate GetIsUnderstandingHandler ()
		{
			if (cb_isUnderstanding == null)
				cb_isUnderstanding = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsUnderstanding);
			return cb_isUnderstanding;
		}

		static bool n_IsUnderstanding (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.SpeechUnderstanderDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsUnderstanding;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsUnderstanding {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='ISpeechUnderstander.Default']/method[@name='isUnderstanding' and count(parameter)=0]"
			[Register ("isUnderstanding", "()Z", "GetIsUnderstandingHandler")]
			get {
				const string __id = "isUnderstanding.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_asBinder;
#pragma warning disable 0169
		static Delegate GetAsBinderHandler ()
		{
			if (cb_asBinder == null)
				cb_asBinder = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_AsBinder);
			return cb_asBinder;
		}

		static IntPtr n_AsBinder (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.SpeechUnderstanderDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='ISpeechUnderstander.Default']/method[@name='asBinder' and count(parameter)=0]"
		[Register ("asBinder", "()Landroid/os/IBinder;", "GetAsBinderHandler")]
		public virtual unsafe global::Android.OS.IBinder AsBinder ()
		{
			const string __id = "asBinder.()Landroid/os/IBinder;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_cancel_Lcom_iflytek_speech_SpeechUnderstanderListener_;
#pragma warning disable 0169
		static Delegate GetCancel_Lcom_iflytek_speech_SpeechUnderstanderListener_Handler ()
		{
			if (cb_cancel_Lcom_iflytek_speech_SpeechUnderstanderListener_ == null)
				cb_cancel_Lcom_iflytek_speech_SpeechUnderstanderListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Cancel_Lcom_iflytek_speech_SpeechUnderstanderListener_);
			return cb_cancel_Lcom_iflytek_speech_SpeechUnderstanderListener_;
		}

		static void n_Cancel_Lcom_iflytek_speech_SpeechUnderstanderListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.SpeechUnderstanderDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Iflytek.Speech.ISpeechUnderstanderListener)global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.ISpeechUnderstanderListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Cancel (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='ISpeechUnderstander.Default']/method[@name='cancel' and count(parameter)=1 and parameter[1][@type='com.iflytek.speech.SpeechUnderstanderListener']]"
		[Register ("cancel", "(Lcom/iflytek/speech/SpeechUnderstanderListener;)V", "GetCancel_Lcom_iflytek_speech_SpeechUnderstanderListener_Handler")]
		public virtual unsafe void Cancel (global::Com.Iflytek.Speech.ISpeechUnderstanderListener p0)
		{
			const string __id = "cancel.(Lcom/iflytek/speech/SpeechUnderstanderListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_startUnderstanding_Landroid_content_Intent_Lcom_iflytek_speech_SpeechUnderstanderListener_;
#pragma warning disable 0169
		static Delegate GetStartUnderstanding_Landroid_content_Intent_Lcom_iflytek_speech_SpeechUnderstanderListener_Handler ()
		{
			if (cb_startUnderstanding_Landroid_content_Intent_Lcom_iflytek_speech_SpeechUnderstanderListener_ == null)
				cb_startUnderstanding_Landroid_content_Intent_Lcom_iflytek_speech_SpeechUnderstanderListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_StartUnderstanding_Landroid_content_Intent_Lcom_iflytek_speech_SpeechUnderstanderListener_);
			return cb_startUnderstanding_Landroid_content_Intent_Lcom_iflytek_speech_SpeechUnderstanderListener_;
		}

		static void n_StartUnderstanding_Landroid_content_Intent_Lcom_iflytek_speech_SpeechUnderstanderListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.SpeechUnderstanderDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Com.Iflytek.Speech.ISpeechUnderstanderListener)global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.ISpeechUnderstanderListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.StartUnderstanding (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='ISpeechUnderstander.Default']/method[@name='startUnderstanding' and count(parameter)=2 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='com.iflytek.speech.SpeechUnderstanderListener']]"
		[Register ("startUnderstanding", "(Landroid/content/Intent;Lcom/iflytek/speech/SpeechUnderstanderListener;)V", "GetStartUnderstanding_Landroid_content_Intent_Lcom_iflytek_speech_SpeechUnderstanderListener_Handler")]
		public virtual unsafe void StartUnderstanding (global::Android.Content.Intent p0, global::Com.Iflytek.Speech.ISpeechUnderstanderListener p1)
		{
			const string __id = "startUnderstanding.(Landroid/content/Intent;Lcom/iflytek/speech/SpeechUnderstanderListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		static Delegate cb_stopUnderstanding_Lcom_iflytek_speech_SpeechUnderstanderListener_;
#pragma warning disable 0169
		static Delegate GetStopUnderstanding_Lcom_iflytek_speech_SpeechUnderstanderListener_Handler ()
		{
			if (cb_stopUnderstanding_Lcom_iflytek_speech_SpeechUnderstanderListener_ == null)
				cb_stopUnderstanding_Lcom_iflytek_speech_SpeechUnderstanderListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_StopUnderstanding_Lcom_iflytek_speech_SpeechUnderstanderListener_);
			return cb_stopUnderstanding_Lcom_iflytek_speech_SpeechUnderstanderListener_;
		}

		static void n_StopUnderstanding_Lcom_iflytek_speech_SpeechUnderstanderListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.SpeechUnderstanderDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Iflytek.Speech.ISpeechUnderstanderListener)global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.ISpeechUnderstanderListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.StopUnderstanding (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='ISpeechUnderstander.Default']/method[@name='stopUnderstanding' and count(parameter)=1 and parameter[1][@type='com.iflytek.speech.SpeechUnderstanderListener']]"
		[Register ("stopUnderstanding", "(Lcom/iflytek/speech/SpeechUnderstanderListener;)V", "GetStopUnderstanding_Lcom_iflytek_speech_SpeechUnderstanderListener_Handler")]
		public virtual unsafe void StopUnderstanding (global::Com.Iflytek.Speech.ISpeechUnderstanderListener p0)
		{
			const string __id = "stopUnderstanding.(Lcom/iflytek/speech/SpeechUnderstanderListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_writeAudio_Landroid_content_Intent_arrayBII;
#pragma warning disable 0169
		static Delegate GetWriteAudio_Landroid_content_Intent_arrayBIIHandler ()
		{
			if (cb_writeAudio_Landroid_content_Intent_arrayBII == null)
				cb_writeAudio_Landroid_content_Intent_arrayBII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLII_V) n_WriteAudio_Landroid_content_Intent_arrayBII);
			return cb_writeAudio_Landroid_content_Intent_arrayBII;
		}

		static void n_WriteAudio_Landroid_content_Intent_arrayBII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, int p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.SpeechUnderstanderDefault> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.WriteAudio (p0, p1, p2, p3);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='ISpeechUnderstander.Default']/method[@name='writeAudio' and count(parameter)=4 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("writeAudio", "(Landroid/content/Intent;[BII)V", "GetWriteAudio_Landroid_content_Intent_arrayBIIHandler")]
		public virtual unsafe void WriteAudio (global::Android.Content.Intent p0, byte[] p1, int p2, int p3)
		{
			const string __id = "writeAudio.(Landroid/content/Intent;[BII)V";
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

	}

	// Metadata.xml XPath class reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='ISpeechUnderstander.Stub']"
	[global::Android.Runtime.Register ("com/iflytek/speech/aidl/ISpeechUnderstander$Stub", DoNotGenerateAcw=true)]
	public abstract partial class SpeechUnderstanderStub : global::Android.OS.Binder, global::Com.Iflytek.Speech.Aidl.ISpeechUnderstander {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/speech/aidl/ISpeechUnderstander$Stub", typeof (SpeechUnderstanderStub));

		internal static IntPtr class_ref {
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
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected SpeechUnderstanderStub (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='ISpeechUnderstander.Stub']/constructor[@name='ISpeechUnderstander.Stub' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SpeechUnderstanderStub () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		public static unsafe global::Com.Iflytek.Speech.Aidl.ISpeechUnderstander DefaultImpl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='ISpeechUnderstander.Stub']/method[@name='getDefaultImpl' and count(parameter)=0]"
			[Register ("getDefaultImpl", "()Lcom/iflytek/speech/aidl/ISpeechUnderstander;", "")]
			get {
				const string __id = "getDefaultImpl.()Lcom/iflytek/speech/aidl/ISpeechUnderstander;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.ISpeechUnderstander> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_asBinder;
#pragma warning disable 0169
		static Delegate GetAsBinderHandler ()
		{
			if (cb_asBinder == null)
				cb_asBinder = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_AsBinder);
			return cb_asBinder;
		}

		static IntPtr n_AsBinder (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.SpeechUnderstanderStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='ISpeechUnderstander.Stub']/method[@name='asBinder' and count(parameter)=0]"
		[Register ("asBinder", "()Landroid/os/IBinder;", "GetAsBinderHandler")]
		public virtual unsafe global::Android.OS.IBinder AsBinder ()
		{
			const string __id = "asBinder.()Landroid/os/IBinder;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='ISpeechUnderstander.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
		[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/iflytek/speech/aidl/ISpeechUnderstander;", "")]
		public static unsafe global::Com.Iflytek.Speech.Aidl.ISpeechUnderstander AsInterface (global::Android.OS.IBinder p0)
		{
			const string __id = "asInterface.(Landroid/os/IBinder;)Lcom/iflytek/speech/aidl/ISpeechUnderstander;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.ISpeechUnderstander> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
		static Delegate GetOnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_IHandler ()
		{
			if (cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I == null)
				cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPILLI_Z) n_OnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I);
			return cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I;
		}

		static bool n_OnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2, int p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.SpeechUnderstanderStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTransact (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='ISpeechUnderstander.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
		[Register ("onTransact", "(ILandroid/os/Parcel;Landroid/os/Parcel;I)Z", "GetOnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_IHandler")]
		public virtual unsafe bool OnTransact (int p0, global::Android.OS.Parcel p1, global::Android.OS.Parcel p2, int p3)
		{
			const string __id = "onTransact.(ILandroid/os/Parcel;Landroid/os/Parcel;I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				__args [3] = new JniArgumentValue (p3);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='ISpeechUnderstander.Stub']/method[@name='setDefaultImpl' and count(parameter)=1 and parameter[1][@type='com.iflytek.speech.aidl.ISpeechUnderstander']]"
		[Register ("setDefaultImpl", "(Lcom/iflytek/speech/aidl/ISpeechUnderstander;)Z", "")]
		public static unsafe bool SetDefaultImpl (global::Com.Iflytek.Speech.Aidl.ISpeechUnderstander p0)
		{
			const string __id = "setDefaultImpl.(Lcom/iflytek/speech/aidl/ISpeechUnderstander;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_cancel_Lcom_iflytek_speech_SpeechUnderstanderListener_;
#pragma warning disable 0169
		static Delegate GetCancel_Lcom_iflytek_speech_SpeechUnderstanderListener_Handler ()
		{
			if (cb_cancel_Lcom_iflytek_speech_SpeechUnderstanderListener_ == null)
				cb_cancel_Lcom_iflytek_speech_SpeechUnderstanderListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Cancel_Lcom_iflytek_speech_SpeechUnderstanderListener_);
			return cb_cancel_Lcom_iflytek_speech_SpeechUnderstanderListener_;
		}

		static void n_Cancel_Lcom_iflytek_speech_SpeechUnderstanderListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.SpeechUnderstanderStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Iflytek.Speech.ISpeechUnderstanderListener)global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.ISpeechUnderstanderListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Cancel (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/interface[@name='ISpeechUnderstander']/method[@name='cancel' and count(parameter)=1 and parameter[1][@type='com.iflytek.speech.SpeechUnderstanderListener']]"
		[Register ("cancel", "(Lcom/iflytek/speech/SpeechUnderstanderListener;)V", "GetCancel_Lcom_iflytek_speech_SpeechUnderstanderListener_Handler")]
		public abstract void Cancel (global::Com.Iflytek.Speech.ISpeechUnderstanderListener p0);

		static Delegate cb_startUnderstanding_Landroid_content_Intent_Lcom_iflytek_speech_SpeechUnderstanderListener_;
#pragma warning disable 0169
		static Delegate GetStartUnderstanding_Landroid_content_Intent_Lcom_iflytek_speech_SpeechUnderstanderListener_Handler ()
		{
			if (cb_startUnderstanding_Landroid_content_Intent_Lcom_iflytek_speech_SpeechUnderstanderListener_ == null)
				cb_startUnderstanding_Landroid_content_Intent_Lcom_iflytek_speech_SpeechUnderstanderListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_StartUnderstanding_Landroid_content_Intent_Lcom_iflytek_speech_SpeechUnderstanderListener_);
			return cb_startUnderstanding_Landroid_content_Intent_Lcom_iflytek_speech_SpeechUnderstanderListener_;
		}

		static void n_StartUnderstanding_Landroid_content_Intent_Lcom_iflytek_speech_SpeechUnderstanderListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.SpeechUnderstanderStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Com.Iflytek.Speech.ISpeechUnderstanderListener)global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.ISpeechUnderstanderListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.StartUnderstanding (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/interface[@name='ISpeechUnderstander']/method[@name='startUnderstanding' and count(parameter)=2 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='com.iflytek.speech.SpeechUnderstanderListener']]"
		[Register ("startUnderstanding", "(Landroid/content/Intent;Lcom/iflytek/speech/SpeechUnderstanderListener;)V", "GetStartUnderstanding_Landroid_content_Intent_Lcom_iflytek_speech_SpeechUnderstanderListener_Handler")]
		public abstract void StartUnderstanding (global::Android.Content.Intent p0, global::Com.Iflytek.Speech.ISpeechUnderstanderListener p1);

		static Delegate cb_stopUnderstanding_Lcom_iflytek_speech_SpeechUnderstanderListener_;
#pragma warning disable 0169
		static Delegate GetStopUnderstanding_Lcom_iflytek_speech_SpeechUnderstanderListener_Handler ()
		{
			if (cb_stopUnderstanding_Lcom_iflytek_speech_SpeechUnderstanderListener_ == null)
				cb_stopUnderstanding_Lcom_iflytek_speech_SpeechUnderstanderListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_StopUnderstanding_Lcom_iflytek_speech_SpeechUnderstanderListener_);
			return cb_stopUnderstanding_Lcom_iflytek_speech_SpeechUnderstanderListener_;
		}

		static void n_StopUnderstanding_Lcom_iflytek_speech_SpeechUnderstanderListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.SpeechUnderstanderStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Iflytek.Speech.ISpeechUnderstanderListener)global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.ISpeechUnderstanderListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.StopUnderstanding (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/interface[@name='ISpeechUnderstander']/method[@name='stopUnderstanding' and count(parameter)=1 and parameter[1][@type='com.iflytek.speech.SpeechUnderstanderListener']]"
		[Register ("stopUnderstanding", "(Lcom/iflytek/speech/SpeechUnderstanderListener;)V", "GetStopUnderstanding_Lcom_iflytek_speech_SpeechUnderstanderListener_Handler")]
		public abstract void StopUnderstanding (global::Com.Iflytek.Speech.ISpeechUnderstanderListener p0);

		static Delegate cb_writeAudio_Landroid_content_Intent_arrayBII;
#pragma warning disable 0169
		static Delegate GetWriteAudio_Landroid_content_Intent_arrayBIIHandler ()
		{
			if (cb_writeAudio_Landroid_content_Intent_arrayBII == null)
				cb_writeAudio_Landroid_content_Intent_arrayBII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLII_V) n_WriteAudio_Landroid_content_Intent_arrayBII);
			return cb_writeAudio_Landroid_content_Intent_arrayBII;
		}

		static void n_WriteAudio_Landroid_content_Intent_arrayBII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, int p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.SpeechUnderstanderStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.WriteAudio (p0, p1, p2, p3);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/interface[@name='ISpeechUnderstander']/method[@name='writeAudio' and count(parameter)=4 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("writeAudio", "(Landroid/content/Intent;[BII)V", "GetWriteAudio_Landroid_content_Intent_arrayBIIHandler")]
		public abstract void WriteAudio (global::Android.Content.Intent p0, byte[] p1, int p2, int p3);

		static Delegate cb_isUnderstanding;
#pragma warning disable 0169
		static Delegate GetIsUnderstandingHandler ()
		{
			if (cb_isUnderstanding == null)
				cb_isUnderstanding = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsUnderstanding);
			return cb_isUnderstanding;
		}

		static bool n_IsUnderstanding (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.SpeechUnderstanderStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsUnderstanding;
		}
#pragma warning restore 0169

		public abstract bool IsUnderstanding {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='ISpeechUnderstander.Stub']/method[@name='isUnderstanding' and count(parameter)=0]"
			[Register ("isUnderstanding", "()Z", "GetIsUnderstandingHandler")]
			get; 
		}

	}

	[global::Android.Runtime.Register ("com/iflytek/speech/aidl/ISpeechUnderstander$Stub", DoNotGenerateAcw=true)]
	internal partial class SpeechUnderstanderStubInvoker : SpeechUnderstanderStub {
		public SpeechUnderstanderStubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/speech/aidl/ISpeechUnderstander$Stub", typeof (SpeechUnderstanderStubInvoker));

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		public override unsafe bool IsUnderstanding {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/class[@name='ISpeechUnderstander.Stub']/method[@name='isUnderstanding' and count(parameter)=0]"
			[Register ("isUnderstanding", "()Z", "GetIsUnderstandingHandler")]
			get {
				const string __id = "isUnderstanding.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/interface[@name='ISpeechUnderstander']/method[@name='cancel' and count(parameter)=1 and parameter[1][@type='com.iflytek.speech.SpeechUnderstanderListener']]"
		[Register ("cancel", "(Lcom/iflytek/speech/SpeechUnderstanderListener;)V", "GetCancel_Lcom_iflytek_speech_SpeechUnderstanderListener_Handler")]
		public override unsafe void Cancel (global::Com.Iflytek.Speech.ISpeechUnderstanderListener p0)
		{
			const string __id = "cancel.(Lcom/iflytek/speech/SpeechUnderstanderListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/interface[@name='ISpeechUnderstander']/method[@name='startUnderstanding' and count(parameter)=2 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='com.iflytek.speech.SpeechUnderstanderListener']]"
		[Register ("startUnderstanding", "(Landroid/content/Intent;Lcom/iflytek/speech/SpeechUnderstanderListener;)V", "GetStartUnderstanding_Landroid_content_Intent_Lcom_iflytek_speech_SpeechUnderstanderListener_Handler")]
		public override unsafe void StartUnderstanding (global::Android.Content.Intent p0, global::Com.Iflytek.Speech.ISpeechUnderstanderListener p1)
		{
			const string __id = "startUnderstanding.(Landroid/content/Intent;Lcom/iflytek/speech/SpeechUnderstanderListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/interface[@name='ISpeechUnderstander']/method[@name='stopUnderstanding' and count(parameter)=1 and parameter[1][@type='com.iflytek.speech.SpeechUnderstanderListener']]"
		[Register ("stopUnderstanding", "(Lcom/iflytek/speech/SpeechUnderstanderListener;)V", "GetStopUnderstanding_Lcom_iflytek_speech_SpeechUnderstanderListener_Handler")]
		public override unsafe void StopUnderstanding (global::Com.Iflytek.Speech.ISpeechUnderstanderListener p0)
		{
			const string __id = "stopUnderstanding.(Lcom/iflytek/speech/SpeechUnderstanderListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/interface[@name='ISpeechUnderstander']/method[@name='writeAudio' and count(parameter)=4 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("writeAudio", "(Landroid/content/Intent;[BII)V", "GetWriteAudio_Landroid_content_Intent_arrayBIIHandler")]
		public override unsafe void WriteAudio (global::Android.Content.Intent p0, byte[] p1, int p2, int p3)
		{
			const string __id = "writeAudio.(Landroid/content/Intent;[BII)V";
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.iflytek.speech.aidl']/interface[@name='ISpeechUnderstander']"
	[Register ("com/iflytek/speech/aidl/ISpeechUnderstander", "", "Com.Iflytek.Speech.Aidl.ISpeechUnderstanderInvoker")]
	public partial interface ISpeechUnderstander : global::Android.OS.IInterface {
		bool IsUnderstanding {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/interface[@name='ISpeechUnderstander']/method[@name='isUnderstanding' and count(parameter)=0]"
			[Register ("isUnderstanding", "()Z", "GetIsUnderstandingHandler:Com.Iflytek.Speech.Aidl.ISpeechUnderstanderInvoker, xfyunOCWR")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/interface[@name='ISpeechUnderstander']/method[@name='cancel' and count(parameter)=1 and parameter[1][@type='com.iflytek.speech.SpeechUnderstanderListener']]"
		[Register ("cancel", "(Lcom/iflytek/speech/SpeechUnderstanderListener;)V", "GetCancel_Lcom_iflytek_speech_SpeechUnderstanderListener_Handler:Com.Iflytek.Speech.Aidl.ISpeechUnderstanderInvoker, xfyunOCWR")]
		void Cancel (global::Com.Iflytek.Speech.ISpeechUnderstanderListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/interface[@name='ISpeechUnderstander']/method[@name='startUnderstanding' and count(parameter)=2 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='com.iflytek.speech.SpeechUnderstanderListener']]"
		[Register ("startUnderstanding", "(Landroid/content/Intent;Lcom/iflytek/speech/SpeechUnderstanderListener;)V", "GetStartUnderstanding_Landroid_content_Intent_Lcom_iflytek_speech_SpeechUnderstanderListener_Handler:Com.Iflytek.Speech.Aidl.ISpeechUnderstanderInvoker, xfyunOCWR")]
		void StartUnderstanding (global::Android.Content.Intent p0, global::Com.Iflytek.Speech.ISpeechUnderstanderListener p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/interface[@name='ISpeechUnderstander']/method[@name='stopUnderstanding' and count(parameter)=1 and parameter[1][@type='com.iflytek.speech.SpeechUnderstanderListener']]"
		[Register ("stopUnderstanding", "(Lcom/iflytek/speech/SpeechUnderstanderListener;)V", "GetStopUnderstanding_Lcom_iflytek_speech_SpeechUnderstanderListener_Handler:Com.Iflytek.Speech.Aidl.ISpeechUnderstanderInvoker, xfyunOCWR")]
		void StopUnderstanding (global::Com.Iflytek.Speech.ISpeechUnderstanderListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.iflytek.speech.aidl']/interface[@name='ISpeechUnderstander']/method[@name='writeAudio' and count(parameter)=4 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("writeAudio", "(Landroid/content/Intent;[BII)V", "GetWriteAudio_Landroid_content_Intent_arrayBIIHandler:Com.Iflytek.Speech.Aidl.ISpeechUnderstanderInvoker, xfyunOCWR")]
		void WriteAudio (global::Android.Content.Intent p0, byte[] p1, int p2, int p3);

	}

	[global::Android.Runtime.Register ("com/iflytek/speech/aidl/ISpeechUnderstander", DoNotGenerateAcw=true)]
	internal partial class ISpeechUnderstanderInvoker : global::Java.Lang.Object, ISpeechUnderstander {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/iflytek/speech/aidl/ISpeechUnderstander", typeof (ISpeechUnderstanderInvoker));

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

		public static ISpeechUnderstander GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISpeechUnderstander> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.", JNIEnv.GetClassNameFromInstance (handle), "com.iflytek.speech.aidl.ISpeechUnderstander"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISpeechUnderstanderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_isUnderstanding;
#pragma warning disable 0169
		static Delegate GetIsUnderstandingHandler ()
		{
			if (cb_isUnderstanding == null)
				cb_isUnderstanding = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsUnderstanding);
			return cb_isUnderstanding;
		}

		static bool n_IsUnderstanding (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.ISpeechUnderstander> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsUnderstanding;
		}
#pragma warning restore 0169

		IntPtr id_isUnderstanding;
		public unsafe bool IsUnderstanding {
			get {
				if (id_isUnderstanding == IntPtr.Zero)
					id_isUnderstanding = JNIEnv.GetMethodID (class_ref, "isUnderstanding", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isUnderstanding);
			}
		}

		static Delegate cb_cancel_Lcom_iflytek_speech_SpeechUnderstanderListener_;
#pragma warning disable 0169
		static Delegate GetCancel_Lcom_iflytek_speech_SpeechUnderstanderListener_Handler ()
		{
			if (cb_cancel_Lcom_iflytek_speech_SpeechUnderstanderListener_ == null)
				cb_cancel_Lcom_iflytek_speech_SpeechUnderstanderListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Cancel_Lcom_iflytek_speech_SpeechUnderstanderListener_);
			return cb_cancel_Lcom_iflytek_speech_SpeechUnderstanderListener_;
		}

		static void n_Cancel_Lcom_iflytek_speech_SpeechUnderstanderListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.ISpeechUnderstander> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Iflytek.Speech.ISpeechUnderstanderListener)global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.ISpeechUnderstanderListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Cancel (p0);
		}
#pragma warning restore 0169

		IntPtr id_cancel_Lcom_iflytek_speech_SpeechUnderstanderListener_;
		public unsafe void Cancel (global::Com.Iflytek.Speech.ISpeechUnderstanderListener p0)
		{
			if (id_cancel_Lcom_iflytek_speech_SpeechUnderstanderListener_ == IntPtr.Zero)
				id_cancel_Lcom_iflytek_speech_SpeechUnderstanderListener_ = JNIEnv.GetMethodID (class_ref, "cancel", "(Lcom/iflytek/speech/SpeechUnderstanderListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_cancel_Lcom_iflytek_speech_SpeechUnderstanderListener_, __args);
		}

		static Delegate cb_startUnderstanding_Landroid_content_Intent_Lcom_iflytek_speech_SpeechUnderstanderListener_;
#pragma warning disable 0169
		static Delegate GetStartUnderstanding_Landroid_content_Intent_Lcom_iflytek_speech_SpeechUnderstanderListener_Handler ()
		{
			if (cb_startUnderstanding_Landroid_content_Intent_Lcom_iflytek_speech_SpeechUnderstanderListener_ == null)
				cb_startUnderstanding_Landroid_content_Intent_Lcom_iflytek_speech_SpeechUnderstanderListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_StartUnderstanding_Landroid_content_Intent_Lcom_iflytek_speech_SpeechUnderstanderListener_);
			return cb_startUnderstanding_Landroid_content_Intent_Lcom_iflytek_speech_SpeechUnderstanderListener_;
		}

		static void n_StartUnderstanding_Landroid_content_Intent_Lcom_iflytek_speech_SpeechUnderstanderListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.ISpeechUnderstander> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Com.Iflytek.Speech.ISpeechUnderstanderListener)global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.ISpeechUnderstanderListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.StartUnderstanding (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_startUnderstanding_Landroid_content_Intent_Lcom_iflytek_speech_SpeechUnderstanderListener_;
		public unsafe void StartUnderstanding (global::Android.Content.Intent p0, global::Com.Iflytek.Speech.ISpeechUnderstanderListener p1)
		{
			if (id_startUnderstanding_Landroid_content_Intent_Lcom_iflytek_speech_SpeechUnderstanderListener_ == IntPtr.Zero)
				id_startUnderstanding_Landroid_content_Intent_Lcom_iflytek_speech_SpeechUnderstanderListener_ = JNIEnv.GetMethodID (class_ref, "startUnderstanding", "(Landroid/content/Intent;Lcom/iflytek/speech/SpeechUnderstanderListener;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_startUnderstanding_Landroid_content_Intent_Lcom_iflytek_speech_SpeechUnderstanderListener_, __args);
		}

		static Delegate cb_stopUnderstanding_Lcom_iflytek_speech_SpeechUnderstanderListener_;
#pragma warning disable 0169
		static Delegate GetStopUnderstanding_Lcom_iflytek_speech_SpeechUnderstanderListener_Handler ()
		{
			if (cb_stopUnderstanding_Lcom_iflytek_speech_SpeechUnderstanderListener_ == null)
				cb_stopUnderstanding_Lcom_iflytek_speech_SpeechUnderstanderListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_StopUnderstanding_Lcom_iflytek_speech_SpeechUnderstanderListener_);
			return cb_stopUnderstanding_Lcom_iflytek_speech_SpeechUnderstanderListener_;
		}

		static void n_StopUnderstanding_Lcom_iflytek_speech_SpeechUnderstanderListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.ISpeechUnderstander> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Iflytek.Speech.ISpeechUnderstanderListener)global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.ISpeechUnderstanderListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.StopUnderstanding (p0);
		}
#pragma warning restore 0169

		IntPtr id_stopUnderstanding_Lcom_iflytek_speech_SpeechUnderstanderListener_;
		public unsafe void StopUnderstanding (global::Com.Iflytek.Speech.ISpeechUnderstanderListener p0)
		{
			if (id_stopUnderstanding_Lcom_iflytek_speech_SpeechUnderstanderListener_ == IntPtr.Zero)
				id_stopUnderstanding_Lcom_iflytek_speech_SpeechUnderstanderListener_ = JNIEnv.GetMethodID (class_ref, "stopUnderstanding", "(Lcom/iflytek/speech/SpeechUnderstanderListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stopUnderstanding_Lcom_iflytek_speech_SpeechUnderstanderListener_, __args);
		}

		static Delegate cb_writeAudio_Landroid_content_Intent_arrayBII;
#pragma warning disable 0169
		static Delegate GetWriteAudio_Landroid_content_Intent_arrayBIIHandler ()
		{
			if (cb_writeAudio_Landroid_content_Intent_arrayBII == null)
				cb_writeAudio_Landroid_content_Intent_arrayBII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLII_V) n_WriteAudio_Landroid_content_Intent_arrayBII);
			return cb_writeAudio_Landroid_content_Intent_arrayBII;
		}

		static void n_WriteAudio_Landroid_content_Intent_arrayBII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, int p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.ISpeechUnderstander> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.WriteAudio (p0, p1, p2, p3);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		IntPtr id_writeAudio_Landroid_content_Intent_arrayBII;
		public unsafe void WriteAudio (global::Android.Content.Intent p0, byte[] p1, int p2, int p3)
		{
			if (id_writeAudio_Landroid_content_Intent_arrayBII == IntPtr.Zero)
				id_writeAudio_Landroid_content_Intent_arrayBII = JNIEnv.GetMethodID (class_ref, "writeAudio", "(Landroid/content/Intent;[BII)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeAudio_Landroid_content_Intent_arrayBII, __args);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_asBinder;
#pragma warning disable 0169
		static Delegate GetAsBinderHandler ()
		{
			if (cb_asBinder == null)
				cb_asBinder = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_AsBinder);
			return cb_asBinder;
		}

		static IntPtr n_AsBinder (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Iflytek.Speech.Aidl.ISpeechUnderstander> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		IntPtr id_asBinder;
		public unsafe global::Android.OS.IBinder AsBinder ()
		{
			if (id_asBinder == IntPtr.Zero)
				id_asBinder = JNIEnv.GetMethodID (class_ref, "asBinder", "()Landroid/os/IBinder;");
			return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asBinder), JniHandleOwnership.TransferLocalRef);
		}

	}
}
