using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Gms.Maps.Internal {

	[Register ("com/google/android/gms/maps/internal/IUiSettingsDelegate", "", "Com.Google.Android.Gms.Maps.Internal.IUiSettingsDelegateInvoker")]
	public partial interface IUiSettingsDelegate : global::Android.OS.IInterface {

		bool CompassEnabled {
			[Register ("isCompassEnabled", "()Z", "GetIsCompassEnabledHandler:Com.Google.Android.Gms.Maps.Internal.IUiSettingsDelegateInvoker, GooglePlayServices")] get;
			[Register ("setCompassEnabled", "(Z)V", "GetSetCompassEnabled_ZHandler:Com.Google.Android.Gms.Maps.Internal.IUiSettingsDelegateInvoker, GooglePlayServices")] set;
		}

		bool MyLocationButtonEnabled {
			[Register ("isMyLocationButtonEnabled", "()Z", "GetIsMyLocationButtonEnabledHandler:Com.Google.Android.Gms.Maps.Internal.IUiSettingsDelegateInvoker, GooglePlayServices")] get;
			[Register ("setMyLocationButtonEnabled", "(Z)V", "GetSetMyLocationButtonEnabled_ZHandler:Com.Google.Android.Gms.Maps.Internal.IUiSettingsDelegateInvoker, GooglePlayServices")] set;
		}

		bool RotateGesturesEnabled {
			[Register ("isRotateGesturesEnabled", "()Z", "GetIsRotateGesturesEnabledHandler:Com.Google.Android.Gms.Maps.Internal.IUiSettingsDelegateInvoker, GooglePlayServices")] get;
			[Register ("setRotateGesturesEnabled", "(Z)V", "GetSetRotateGesturesEnabled_ZHandler:Com.Google.Android.Gms.Maps.Internal.IUiSettingsDelegateInvoker, GooglePlayServices")] set;
		}

		bool ScrollGesturesEnabled {
			[Register ("isScrollGesturesEnabled", "()Z", "GetIsScrollGesturesEnabledHandler:Com.Google.Android.Gms.Maps.Internal.IUiSettingsDelegateInvoker, GooglePlayServices")] get;
			[Register ("setScrollGesturesEnabled", "(Z)V", "GetSetScrollGesturesEnabled_ZHandler:Com.Google.Android.Gms.Maps.Internal.IUiSettingsDelegateInvoker, GooglePlayServices")] set;
		}

		bool TiltGesturesEnabled {
			[Register ("isTiltGesturesEnabled", "()Z", "GetIsTiltGesturesEnabledHandler:Com.Google.Android.Gms.Maps.Internal.IUiSettingsDelegateInvoker, GooglePlayServices")] get;
			[Register ("setTiltGesturesEnabled", "(Z)V", "GetSetTiltGesturesEnabled_ZHandler:Com.Google.Android.Gms.Maps.Internal.IUiSettingsDelegateInvoker, GooglePlayServices")] set;
		}

		bool ZoomControlsEnabled {
			[Register ("isZoomControlsEnabled", "()Z", "GetIsZoomControlsEnabledHandler:Com.Google.Android.Gms.Maps.Internal.IUiSettingsDelegateInvoker, GooglePlayServices")] get;
			[Register ("setZoomControlsEnabled", "(Z)V", "GetSetZoomControlsEnabled_ZHandler:Com.Google.Android.Gms.Maps.Internal.IUiSettingsDelegateInvoker, GooglePlayServices")] set;
		}

		bool ZoomGesturesEnabled {
			[Register ("isZoomGesturesEnabled", "()Z", "GetIsZoomGesturesEnabledHandler:Com.Google.Android.Gms.Maps.Internal.IUiSettingsDelegateInvoker, GooglePlayServices")] get;
			[Register ("setZoomGesturesEnabled", "(Z)V", "GetSetZoomGesturesEnabled_ZHandler:Com.Google.Android.Gms.Maps.Internal.IUiSettingsDelegateInvoker, GooglePlayServices")] set;
		}

		[Register ("setAllGesturesEnabled", "(Z)V", "GetSetAllGesturesEnabled_ZHandler:Com.Google.Android.Gms.Maps.Internal.IUiSettingsDelegateInvoker, GooglePlayServices")]
		void SetAllGesturesEnabled (bool p0);

	}

	[global::Android.Runtime.Register ("com/google/android/gms/maps/internal/IUiSettingsDelegate", DoNotGenerateAcw=true)]
	internal class IUiSettingsDelegateInvoker : global::Java.Lang.Object, IUiSettingsDelegate {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/gms/maps/internal/IUiSettingsDelegate");
		IntPtr class_ref;

		public static IUiSettingsDelegate GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IUiSettingsDelegate> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.android.gms.maps.internal.IUiSettingsDelegate"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IUiSettingsDelegateInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IUiSettingsDelegateInvoker); }
		}

		static Delegate cb_isCompassEnabled;
#pragma warning disable 0169
		static Delegate GetIsCompassEnabledHandler ()
		{
			if (cb_isCompassEnabled == null)
				cb_isCompassEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsCompassEnabled);
			return cb_isCompassEnabled;
		}

		static bool n_IsCompassEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Gms.Maps.Internal.IUiSettingsDelegate __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Maps.Internal.IUiSettingsDelegate> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CompassEnabled;
		}
#pragma warning restore 0169

		static Delegate cb_setCompassEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetCompassEnabled_ZHandler ()
		{
			if (cb_setCompassEnabled_Z == null)
				cb_setCompassEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetCompassEnabled_Z);
			return cb_setCompassEnabled_Z;
		}

		static void n_SetCompassEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Google.Android.Gms.Maps.Internal.IUiSettingsDelegate __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Maps.Internal.IUiSettingsDelegate> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.CompassEnabled = p0;
		}
#pragma warning restore 0169

		IntPtr id_isCompassEnabled;
		IntPtr id_setCompassEnabled_Z;
		public bool CompassEnabled {
			get {
				if (id_isCompassEnabled == IntPtr.Zero)
					id_isCompassEnabled = JNIEnv.GetMethodID (class_ref, "isCompassEnabled", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isCompassEnabled);
			}
			set {
				if (id_setCompassEnabled_Z == IntPtr.Zero)
					id_setCompassEnabled_Z = JNIEnv.GetMethodID (class_ref, "setCompassEnabled", "(Z)V");
				JNIEnv.CallVoidMethod (Handle, id_setCompassEnabled_Z, new JValue (value));
			}
		}

		static Delegate cb_isMyLocationButtonEnabled;
#pragma warning disable 0169
		static Delegate GetIsMyLocationButtonEnabledHandler ()
		{
			if (cb_isMyLocationButtonEnabled == null)
				cb_isMyLocationButtonEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsMyLocationButtonEnabled);
			return cb_isMyLocationButtonEnabled;
		}

		static bool n_IsMyLocationButtonEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Gms.Maps.Internal.IUiSettingsDelegate __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Maps.Internal.IUiSettingsDelegate> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MyLocationButtonEnabled;
		}
#pragma warning restore 0169

		static Delegate cb_setMyLocationButtonEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetMyLocationButtonEnabled_ZHandler ()
		{
			if (cb_setMyLocationButtonEnabled_Z == null)
				cb_setMyLocationButtonEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetMyLocationButtonEnabled_Z);
			return cb_setMyLocationButtonEnabled_Z;
		}

		static void n_SetMyLocationButtonEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Google.Android.Gms.Maps.Internal.IUiSettingsDelegate __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Maps.Internal.IUiSettingsDelegate> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.MyLocationButtonEnabled = p0;
		}
#pragma warning restore 0169

		IntPtr id_isMyLocationButtonEnabled;
		IntPtr id_setMyLocationButtonEnabled_Z;
		public bool MyLocationButtonEnabled {
			get {
				if (id_isMyLocationButtonEnabled == IntPtr.Zero)
					id_isMyLocationButtonEnabled = JNIEnv.GetMethodID (class_ref, "isMyLocationButtonEnabled", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isMyLocationButtonEnabled);
			}
			set {
				if (id_setMyLocationButtonEnabled_Z == IntPtr.Zero)
					id_setMyLocationButtonEnabled_Z = JNIEnv.GetMethodID (class_ref, "setMyLocationButtonEnabled", "(Z)V");
				JNIEnv.CallVoidMethod (Handle, id_setMyLocationButtonEnabled_Z, new JValue (value));
			}
		}

		static Delegate cb_isRotateGesturesEnabled;
#pragma warning disable 0169
		static Delegate GetIsRotateGesturesEnabledHandler ()
		{
			if (cb_isRotateGesturesEnabled == null)
				cb_isRotateGesturesEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsRotateGesturesEnabled);
			return cb_isRotateGesturesEnabled;
		}

		static bool n_IsRotateGesturesEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Gms.Maps.Internal.IUiSettingsDelegate __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Maps.Internal.IUiSettingsDelegate> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RotateGesturesEnabled;
		}
#pragma warning restore 0169

		static Delegate cb_setRotateGesturesEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetRotateGesturesEnabled_ZHandler ()
		{
			if (cb_setRotateGesturesEnabled_Z == null)
				cb_setRotateGesturesEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetRotateGesturesEnabled_Z);
			return cb_setRotateGesturesEnabled_Z;
		}

		static void n_SetRotateGesturesEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Google.Android.Gms.Maps.Internal.IUiSettingsDelegate __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Maps.Internal.IUiSettingsDelegate> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.RotateGesturesEnabled = p0;
		}
#pragma warning restore 0169

		IntPtr id_isRotateGesturesEnabled;
		IntPtr id_setRotateGesturesEnabled_Z;
		public bool RotateGesturesEnabled {
			get {
				if (id_isRotateGesturesEnabled == IntPtr.Zero)
					id_isRotateGesturesEnabled = JNIEnv.GetMethodID (class_ref, "isRotateGesturesEnabled", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isRotateGesturesEnabled);
			}
			set {
				if (id_setRotateGesturesEnabled_Z == IntPtr.Zero)
					id_setRotateGesturesEnabled_Z = JNIEnv.GetMethodID (class_ref, "setRotateGesturesEnabled", "(Z)V");
				JNIEnv.CallVoidMethod (Handle, id_setRotateGesturesEnabled_Z, new JValue (value));
			}
		}

		static Delegate cb_isScrollGesturesEnabled;
#pragma warning disable 0169
		static Delegate GetIsScrollGesturesEnabledHandler ()
		{
			if (cb_isScrollGesturesEnabled == null)
				cb_isScrollGesturesEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsScrollGesturesEnabled);
			return cb_isScrollGesturesEnabled;
		}

		static bool n_IsScrollGesturesEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Gms.Maps.Internal.IUiSettingsDelegate __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Maps.Internal.IUiSettingsDelegate> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ScrollGesturesEnabled;
		}
#pragma warning restore 0169

		static Delegate cb_setScrollGesturesEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetScrollGesturesEnabled_ZHandler ()
		{
			if (cb_setScrollGesturesEnabled_Z == null)
				cb_setScrollGesturesEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetScrollGesturesEnabled_Z);
			return cb_setScrollGesturesEnabled_Z;
		}

		static void n_SetScrollGesturesEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Google.Android.Gms.Maps.Internal.IUiSettingsDelegate __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Maps.Internal.IUiSettingsDelegate> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.ScrollGesturesEnabled = p0;
		}
#pragma warning restore 0169

		IntPtr id_isScrollGesturesEnabled;
		IntPtr id_setScrollGesturesEnabled_Z;
		public bool ScrollGesturesEnabled {
			get {
				if (id_isScrollGesturesEnabled == IntPtr.Zero)
					id_isScrollGesturesEnabled = JNIEnv.GetMethodID (class_ref, "isScrollGesturesEnabled", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isScrollGesturesEnabled);
			}
			set {
				if (id_setScrollGesturesEnabled_Z == IntPtr.Zero)
					id_setScrollGesturesEnabled_Z = JNIEnv.GetMethodID (class_ref, "setScrollGesturesEnabled", "(Z)V");
				JNIEnv.CallVoidMethod (Handle, id_setScrollGesturesEnabled_Z, new JValue (value));
			}
		}

		static Delegate cb_isTiltGesturesEnabled;
#pragma warning disable 0169
		static Delegate GetIsTiltGesturesEnabledHandler ()
		{
			if (cb_isTiltGesturesEnabled == null)
				cb_isTiltGesturesEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsTiltGesturesEnabled);
			return cb_isTiltGesturesEnabled;
		}

		static bool n_IsTiltGesturesEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Gms.Maps.Internal.IUiSettingsDelegate __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Maps.Internal.IUiSettingsDelegate> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TiltGesturesEnabled;
		}
#pragma warning restore 0169

		static Delegate cb_setTiltGesturesEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetTiltGesturesEnabled_ZHandler ()
		{
			if (cb_setTiltGesturesEnabled_Z == null)
				cb_setTiltGesturesEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetTiltGesturesEnabled_Z);
			return cb_setTiltGesturesEnabled_Z;
		}

		static void n_SetTiltGesturesEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Google.Android.Gms.Maps.Internal.IUiSettingsDelegate __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Maps.Internal.IUiSettingsDelegate> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.TiltGesturesEnabled = p0;
		}
#pragma warning restore 0169

		IntPtr id_isTiltGesturesEnabled;
		IntPtr id_setTiltGesturesEnabled_Z;
		public bool TiltGesturesEnabled {
			get {
				if (id_isTiltGesturesEnabled == IntPtr.Zero)
					id_isTiltGesturesEnabled = JNIEnv.GetMethodID (class_ref, "isTiltGesturesEnabled", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isTiltGesturesEnabled);
			}
			set {
				if (id_setTiltGesturesEnabled_Z == IntPtr.Zero)
					id_setTiltGesturesEnabled_Z = JNIEnv.GetMethodID (class_ref, "setTiltGesturesEnabled", "(Z)V");
				JNIEnv.CallVoidMethod (Handle, id_setTiltGesturesEnabled_Z, new JValue (value));
			}
		}

		static Delegate cb_isZoomControlsEnabled;
#pragma warning disable 0169
		static Delegate GetIsZoomControlsEnabledHandler ()
		{
			if (cb_isZoomControlsEnabled == null)
				cb_isZoomControlsEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsZoomControlsEnabled);
			return cb_isZoomControlsEnabled;
		}

		static bool n_IsZoomControlsEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Gms.Maps.Internal.IUiSettingsDelegate __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Maps.Internal.IUiSettingsDelegate> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ZoomControlsEnabled;
		}
#pragma warning restore 0169

		static Delegate cb_setZoomControlsEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetZoomControlsEnabled_ZHandler ()
		{
			if (cb_setZoomControlsEnabled_Z == null)
				cb_setZoomControlsEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetZoomControlsEnabled_Z);
			return cb_setZoomControlsEnabled_Z;
		}

		static void n_SetZoomControlsEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Google.Android.Gms.Maps.Internal.IUiSettingsDelegate __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Maps.Internal.IUiSettingsDelegate> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.ZoomControlsEnabled = p0;
		}
#pragma warning restore 0169

		IntPtr id_isZoomControlsEnabled;
		IntPtr id_setZoomControlsEnabled_Z;
		public bool ZoomControlsEnabled {
			get {
				if (id_isZoomControlsEnabled == IntPtr.Zero)
					id_isZoomControlsEnabled = JNIEnv.GetMethodID (class_ref, "isZoomControlsEnabled", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isZoomControlsEnabled);
			}
			set {
				if (id_setZoomControlsEnabled_Z == IntPtr.Zero)
					id_setZoomControlsEnabled_Z = JNIEnv.GetMethodID (class_ref, "setZoomControlsEnabled", "(Z)V");
				JNIEnv.CallVoidMethod (Handle, id_setZoomControlsEnabled_Z, new JValue (value));
			}
		}

		static Delegate cb_isZoomGesturesEnabled;
#pragma warning disable 0169
		static Delegate GetIsZoomGesturesEnabledHandler ()
		{
			if (cb_isZoomGesturesEnabled == null)
				cb_isZoomGesturesEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsZoomGesturesEnabled);
			return cb_isZoomGesturesEnabled;
		}

		static bool n_IsZoomGesturesEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Gms.Maps.Internal.IUiSettingsDelegate __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Maps.Internal.IUiSettingsDelegate> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ZoomGesturesEnabled;
		}
#pragma warning restore 0169

		static Delegate cb_setZoomGesturesEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetZoomGesturesEnabled_ZHandler ()
		{
			if (cb_setZoomGesturesEnabled_Z == null)
				cb_setZoomGesturesEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetZoomGesturesEnabled_Z);
			return cb_setZoomGesturesEnabled_Z;
		}

		static void n_SetZoomGesturesEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Google.Android.Gms.Maps.Internal.IUiSettingsDelegate __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Maps.Internal.IUiSettingsDelegate> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.ZoomGesturesEnabled = p0;
		}
#pragma warning restore 0169

		IntPtr id_isZoomGesturesEnabled;
		IntPtr id_setZoomGesturesEnabled_Z;
		public bool ZoomGesturesEnabled {
			get {
				if (id_isZoomGesturesEnabled == IntPtr.Zero)
					id_isZoomGesturesEnabled = JNIEnv.GetMethodID (class_ref, "isZoomGesturesEnabled", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isZoomGesturesEnabled);
			}
			set {
				if (id_setZoomGesturesEnabled_Z == IntPtr.Zero)
					id_setZoomGesturesEnabled_Z = JNIEnv.GetMethodID (class_ref, "setZoomGesturesEnabled", "(Z)V");
				JNIEnv.CallVoidMethod (Handle, id_setZoomGesturesEnabled_Z, new JValue (value));
			}
		}

		static Delegate cb_setAllGesturesEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetAllGesturesEnabled_ZHandler ()
		{
			if (cb_setAllGesturesEnabled_Z == null)
				cb_setAllGesturesEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetAllGesturesEnabled_Z);
			return cb_setAllGesturesEnabled_Z;
		}

		static void n_SetAllGesturesEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Google.Android.Gms.Maps.Internal.IUiSettingsDelegate __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Maps.Internal.IUiSettingsDelegate> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetAllGesturesEnabled (p0);
		}
#pragma warning restore 0169

		IntPtr id_setAllGesturesEnabled_Z;
		public void SetAllGesturesEnabled (bool p0)
		{
			if (id_setAllGesturesEnabled_Z == IntPtr.Zero)
				id_setAllGesturesEnabled_Z = JNIEnv.GetMethodID (class_ref, "setAllGesturesEnabled", "(Z)V");
			JNIEnv.CallVoidMethod (Handle, id_setAllGesturesEnabled_Z, new JValue (p0));
		}

		static Delegate cb_asBinder;
#pragma warning disable 0169
		static Delegate GetAsBinderHandler ()
		{
			if (cb_asBinder == null)
				cb_asBinder = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AsBinder);
			return cb_asBinder;
		}

		static IntPtr n_AsBinder (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Gms.Maps.Internal.IUiSettingsDelegate __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Maps.Internal.IUiSettingsDelegate> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		IntPtr id_asBinder;
		public global::Android.OS.IBinder AsBinder ()
		{
			if (id_asBinder == IntPtr.Zero)
				id_asBinder = JNIEnv.GetMethodID (class_ref, "asBinder", "()Landroid/os/IBinder;");
			return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallObjectMethod (Handle, id_asBinder), JniHandleOwnership.TransferLocalRef);
		}

	}

}
