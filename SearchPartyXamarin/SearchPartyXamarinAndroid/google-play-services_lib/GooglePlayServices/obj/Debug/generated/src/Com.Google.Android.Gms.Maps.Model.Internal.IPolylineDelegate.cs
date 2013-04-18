using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Gms.Maps.Model.Internal {

	[Register ("com/google/android/gms/maps/model/internal/IPolylineDelegate", "", "Com.Google.Android.Gms.Maps.Model.Internal.IPolylineDelegateInvoker")]
	public partial interface IPolylineDelegate : global::Android.OS.IInterface {

		int Color {
			[Register ("getColor", "()I", "GetGetColorHandler:Com.Google.Android.Gms.Maps.Model.Internal.IPolylineDelegateInvoker, GooglePlayServices")] get;
			[Register ("setColor", "(I)V", "GetSetColor_IHandler:Com.Google.Android.Gms.Maps.Model.Internal.IPolylineDelegateInvoker, GooglePlayServices")] set;
		}

		bool Geodesic {
			[Register ("isGeodesic", "()Z", "GetIsGeodesicHandler:Com.Google.Android.Gms.Maps.Model.Internal.IPolylineDelegateInvoker, GooglePlayServices")] get;
			[Register ("setGeodesic", "(Z)V", "GetSetGeodesic_ZHandler:Com.Google.Android.Gms.Maps.Model.Internal.IPolylineDelegateInvoker, GooglePlayServices")] set;
		}

		string Id {
			[Register ("getId", "()Ljava/lang/String;", "GetGetIdHandler:Com.Google.Android.Gms.Maps.Model.Internal.IPolylineDelegateInvoker, GooglePlayServices")] get;
		}

		global::System.Collections.Generic.IList<global::Com.Google.Android.Gms.Maps.Model.LatLng> Points {
			[Register ("getPoints", "()Ljava/util/List;", "GetGetPointsHandler:Com.Google.Android.Gms.Maps.Model.Internal.IPolylineDelegateInvoker, GooglePlayServices")] get;
			[Register ("setPoints", "(Ljava/util/List;)V", "GetSetPoints_Ljava_util_List_Handler:Com.Google.Android.Gms.Maps.Model.Internal.IPolylineDelegateInvoker, GooglePlayServices")] set;
		}

		bool Visible {
			[Register ("isVisible", "()Z", "GetIsVisibleHandler:Com.Google.Android.Gms.Maps.Model.Internal.IPolylineDelegateInvoker, GooglePlayServices")] get;
			[Register ("setVisible", "(Z)V", "GetSetVisible_ZHandler:Com.Google.Android.Gms.Maps.Model.Internal.IPolylineDelegateInvoker, GooglePlayServices")] set;
		}

		float Width {
			[Register ("getWidth", "()F", "GetGetWidthHandler:Com.Google.Android.Gms.Maps.Model.Internal.IPolylineDelegateInvoker, GooglePlayServices")] get;
			[Register ("setWidth", "(F)V", "GetSetWidth_FHandler:Com.Google.Android.Gms.Maps.Model.Internal.IPolylineDelegateInvoker, GooglePlayServices")] set;
		}

		float ZIndex {
			[Register ("getZIndex", "()F", "GetGetZIndexHandler:Com.Google.Android.Gms.Maps.Model.Internal.IPolylineDelegateInvoker, GooglePlayServices")] get;
			[Register ("setZIndex", "(F)V", "GetSetZIndex_FHandler:Com.Google.Android.Gms.Maps.Model.Internal.IPolylineDelegateInvoker, GooglePlayServices")] set;
		}

		[Register ("equalsRemote", "(Lcom/google/android/gms/maps/model/internal/IPolylineDelegate;)Z", "GetEqualsRemote_Lcom_google_android_gms_maps_model_internal_IPolylineDelegate_Handler:Com.Google.Android.Gms.Maps.Model.Internal.IPolylineDelegateInvoker, GooglePlayServices")]
		bool EqualsRemote (global::Com.Google.Android.Gms.Maps.Model.Internal.IPolylineDelegate p0);

		[Register ("hashCodeRemote", "()I", "GetHashCodeRemoteHandler:Com.Google.Android.Gms.Maps.Model.Internal.IPolylineDelegateInvoker, GooglePlayServices")]
		int HashCodeRemote ();

		[Register ("remove", "()V", "GetRemoveHandler:Com.Google.Android.Gms.Maps.Model.Internal.IPolylineDelegateInvoker, GooglePlayServices")]
		void Remove ();

	}

	[global::Android.Runtime.Register ("com/google/android/gms/maps/model/internal/IPolylineDelegate", DoNotGenerateAcw=true)]
	internal class IPolylineDelegateInvoker : global::Java.Lang.Object, IPolylineDelegate {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/gms/maps/model/internal/IPolylineDelegate");
		IntPtr class_ref;

		public static IPolylineDelegate GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPolylineDelegate> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.android.gms.maps.model.internal.IPolylineDelegate"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPolylineDelegateInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IPolylineDelegateInvoker); }
		}

		static Delegate cb_getColor;
#pragma warning disable 0169
		static Delegate GetGetColorHandler ()
		{
			if (cb_getColor == null)
				cb_getColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetColor);
			return cb_getColor;
		}

		static int n_GetColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Gms.Maps.Model.Internal.IPolylineDelegate __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Maps.Model.Internal.IPolylineDelegate> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Color;
		}
#pragma warning restore 0169

		static Delegate cb_setColor_I;
#pragma warning disable 0169
		static Delegate GetSetColor_IHandler ()
		{
			if (cb_setColor_I == null)
				cb_setColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetColor_I);
			return cb_setColor_I;
		}

		static void n_SetColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Google.Android.Gms.Maps.Model.Internal.IPolylineDelegate __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Maps.Model.Internal.IPolylineDelegate> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.Color = p0;
		}
#pragma warning restore 0169

		IntPtr id_getColor;
		IntPtr id_setColor_I;
		public int Color {
			get {
				if (id_getColor == IntPtr.Zero)
					id_getColor = JNIEnv.GetMethodID (class_ref, "getColor", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getColor);
			}
			set {
				if (id_setColor_I == IntPtr.Zero)
					id_setColor_I = JNIEnv.GetMethodID (class_ref, "setColor", "(I)V");
				JNIEnv.CallVoidMethod (Handle, id_setColor_I, new JValue (value));
			}
		}

		static Delegate cb_isGeodesic;
#pragma warning disable 0169
		static Delegate GetIsGeodesicHandler ()
		{
			if (cb_isGeodesic == null)
				cb_isGeodesic = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsGeodesic);
			return cb_isGeodesic;
		}

		static bool n_IsGeodesic (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Gms.Maps.Model.Internal.IPolylineDelegate __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Maps.Model.Internal.IPolylineDelegate> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Geodesic;
		}
#pragma warning restore 0169

		static Delegate cb_setGeodesic_Z;
#pragma warning disable 0169
		static Delegate GetSetGeodesic_ZHandler ()
		{
			if (cb_setGeodesic_Z == null)
				cb_setGeodesic_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetGeodesic_Z);
			return cb_setGeodesic_Z;
		}

		static void n_SetGeodesic_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Google.Android.Gms.Maps.Model.Internal.IPolylineDelegate __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Maps.Model.Internal.IPolylineDelegate> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.Geodesic = p0;
		}
#pragma warning restore 0169

		IntPtr id_isGeodesic;
		IntPtr id_setGeodesic_Z;
		public bool Geodesic {
			get {
				if (id_isGeodesic == IntPtr.Zero)
					id_isGeodesic = JNIEnv.GetMethodID (class_ref, "isGeodesic", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isGeodesic);
			}
			set {
				if (id_setGeodesic_Z == IntPtr.Zero)
					id_setGeodesic_Z = JNIEnv.GetMethodID (class_ref, "setGeodesic", "(Z)V");
				JNIEnv.CallVoidMethod (Handle, id_setGeodesic_Z, new JValue (value));
			}
		}

		static Delegate cb_getId;
#pragma warning disable 0169
		static Delegate GetGetIdHandler ()
		{
			if (cb_getId == null)
				cb_getId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetId);
			return cb_getId;
		}

		static IntPtr n_GetId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Gms.Maps.Model.Internal.IPolylineDelegate __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Maps.Model.Internal.IPolylineDelegate> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Id);
		}
#pragma warning restore 0169

		IntPtr id_getId;
		public string Id {
			get {
				if (id_getId == IntPtr.Zero)
					id_getId = JNIEnv.GetMethodID (class_ref, "getId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getPoints;
#pragma warning disable 0169
		static Delegate GetGetPointsHandler ()
		{
			if (cb_getPoints == null)
				cb_getPoints = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPoints);
			return cb_getPoints;
		}

		static IntPtr n_GetPoints (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Gms.Maps.Model.Internal.IPolylineDelegate __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Maps.Model.Internal.IPolylineDelegate> (native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Google.Android.Gms.Maps.Model.LatLng>.ToLocalJniHandle (__this.Points);
		}
#pragma warning restore 0169

		static Delegate cb_setPoints_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetPoints_Ljava_util_List_Handler ()
		{
			if (cb_setPoints_Ljava_util_List_ == null)
				cb_setPoints_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPoints_Ljava_util_List_);
			return cb_setPoints_Ljava_util_List_;
		}

		static void n_SetPoints_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Android.Gms.Maps.Model.Internal.IPolylineDelegate __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Maps.Model.Internal.IPolylineDelegate> (native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IList<Com.Google.Android.Gms.Maps.Model.LatLng> p0 = global::Android.Runtime.JavaList<global::Com.Google.Android.Gms.Maps.Model.LatLng>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Points = p0;
		}
#pragma warning restore 0169

		IntPtr id_getPoints;
		IntPtr id_setPoints_Ljava_util_List_;
		public global::System.Collections.Generic.IList<global::Com.Google.Android.Gms.Maps.Model.LatLng> Points {
			get {
				if (id_getPoints == IntPtr.Zero)
					id_getPoints = JNIEnv.GetMethodID (class_ref, "getPoints", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<global::Com.Google.Android.Gms.Maps.Model.LatLng>.FromJniHandle (JNIEnv.CallObjectMethod (Handle, id_getPoints), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setPoints_Ljava_util_List_ == IntPtr.Zero)
					id_setPoints_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setPoints", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList<global::Com.Google.Android.Gms.Maps.Model.LatLng>.ToLocalJniHandle (value);
				JNIEnv.CallVoidMethod (Handle, id_setPoints_Ljava_util_List_, new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_isVisible;
#pragma warning disable 0169
		static Delegate GetIsVisibleHandler ()
		{
			if (cb_isVisible == null)
				cb_isVisible = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsVisible);
			return cb_isVisible;
		}

		static bool n_IsVisible (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Gms.Maps.Model.Internal.IPolylineDelegate __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Maps.Model.Internal.IPolylineDelegate> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Visible;
		}
#pragma warning restore 0169

		static Delegate cb_setVisible_Z;
#pragma warning disable 0169
		static Delegate GetSetVisible_ZHandler ()
		{
			if (cb_setVisible_Z == null)
				cb_setVisible_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetVisible_Z);
			return cb_setVisible_Z;
		}

		static void n_SetVisible_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Google.Android.Gms.Maps.Model.Internal.IPolylineDelegate __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Maps.Model.Internal.IPolylineDelegate> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.Visible = p0;
		}
#pragma warning restore 0169

		IntPtr id_isVisible;
		IntPtr id_setVisible_Z;
		public bool Visible {
			get {
				if (id_isVisible == IntPtr.Zero)
					id_isVisible = JNIEnv.GetMethodID (class_ref, "isVisible", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isVisible);
			}
			set {
				if (id_setVisible_Z == IntPtr.Zero)
					id_setVisible_Z = JNIEnv.GetMethodID (class_ref, "setVisible", "(Z)V");
				JNIEnv.CallVoidMethod (Handle, id_setVisible_Z, new JValue (value));
			}
		}

		static Delegate cb_getWidth;
#pragma warning disable 0169
		static Delegate GetGetWidthHandler ()
		{
			if (cb_getWidth == null)
				cb_getWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetWidth);
			return cb_getWidth;
		}

		static float n_GetWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Gms.Maps.Model.Internal.IPolylineDelegate __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Maps.Model.Internal.IPolylineDelegate> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Width;
		}
#pragma warning restore 0169

		static Delegate cb_setWidth_F;
#pragma warning disable 0169
		static Delegate GetSetWidth_FHandler ()
		{
			if (cb_setWidth_F == null)
				cb_setWidth_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetWidth_F);
			return cb_setWidth_F;
		}

		static void n_SetWidth_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Google.Android.Gms.Maps.Model.Internal.IPolylineDelegate __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Maps.Model.Internal.IPolylineDelegate> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.Width = p0;
		}
#pragma warning restore 0169

		IntPtr id_getWidth;
		IntPtr id_setWidth_F;
		public float Width {
			get {
				if (id_getWidth == IntPtr.Zero)
					id_getWidth = JNIEnv.GetMethodID (class_ref, "getWidth", "()F");
				return JNIEnv.CallFloatMethod (Handle, id_getWidth);
			}
			set {
				if (id_setWidth_F == IntPtr.Zero)
					id_setWidth_F = JNIEnv.GetMethodID (class_ref, "setWidth", "(F)V");
				JNIEnv.CallVoidMethod (Handle, id_setWidth_F, new JValue (value));
			}
		}

		static Delegate cb_getZIndex;
#pragma warning disable 0169
		static Delegate GetGetZIndexHandler ()
		{
			if (cb_getZIndex == null)
				cb_getZIndex = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetZIndex);
			return cb_getZIndex;
		}

		static float n_GetZIndex (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Gms.Maps.Model.Internal.IPolylineDelegate __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Maps.Model.Internal.IPolylineDelegate> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ZIndex;
		}
#pragma warning restore 0169

		static Delegate cb_setZIndex_F;
#pragma warning disable 0169
		static Delegate GetSetZIndex_FHandler ()
		{
			if (cb_setZIndex_F == null)
				cb_setZIndex_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetZIndex_F);
			return cb_setZIndex_F;
		}

		static void n_SetZIndex_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Google.Android.Gms.Maps.Model.Internal.IPolylineDelegate __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Maps.Model.Internal.IPolylineDelegate> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.ZIndex = p0;
		}
#pragma warning restore 0169

		IntPtr id_getZIndex;
		IntPtr id_setZIndex_F;
		public float ZIndex {
			get {
				if (id_getZIndex == IntPtr.Zero)
					id_getZIndex = JNIEnv.GetMethodID (class_ref, "getZIndex", "()F");
				return JNIEnv.CallFloatMethod (Handle, id_getZIndex);
			}
			set {
				if (id_setZIndex_F == IntPtr.Zero)
					id_setZIndex_F = JNIEnv.GetMethodID (class_ref, "setZIndex", "(F)V");
				JNIEnv.CallVoidMethod (Handle, id_setZIndex_F, new JValue (value));
			}
		}

		static Delegate cb_equalsRemote_Lcom_google_android_gms_maps_model_internal_IPolylineDelegate_;
#pragma warning disable 0169
		static Delegate GetEqualsRemote_Lcom_google_android_gms_maps_model_internal_IPolylineDelegate_Handler ()
		{
			if (cb_equalsRemote_Lcom_google_android_gms_maps_model_internal_IPolylineDelegate_ == null)
				cb_equalsRemote_Lcom_google_android_gms_maps_model_internal_IPolylineDelegate_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_EqualsRemote_Lcom_google_android_gms_maps_model_internal_IPolylineDelegate_);
			return cb_equalsRemote_Lcom_google_android_gms_maps_model_internal_IPolylineDelegate_;
		}

		static bool n_EqualsRemote_Lcom_google_android_gms_maps_model_internal_IPolylineDelegate_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Android.Gms.Maps.Model.Internal.IPolylineDelegate __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Maps.Model.Internal.IPolylineDelegate> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Android.Gms.Maps.Model.Internal.IPolylineDelegate p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Maps.Model.Internal.IPolylineDelegate> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.EqualsRemote (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_equalsRemote_Lcom_google_android_gms_maps_model_internal_IPolylineDelegate_;
		public bool EqualsRemote (global::Com.Google.Android.Gms.Maps.Model.Internal.IPolylineDelegate p0)
		{
			if (id_equalsRemote_Lcom_google_android_gms_maps_model_internal_IPolylineDelegate_ == IntPtr.Zero)
				id_equalsRemote_Lcom_google_android_gms_maps_model_internal_IPolylineDelegate_ = JNIEnv.GetMethodID (class_ref, "equalsRemote", "(Lcom/google/android/gms/maps/model/internal/IPolylineDelegate;)Z");
			bool __ret = JNIEnv.CallBooleanMethod (Handle, id_equalsRemote_Lcom_google_android_gms_maps_model_internal_IPolylineDelegate_, new JValue (p0));
			return __ret;
		}

		static Delegate cb_hashCodeRemote;
#pragma warning disable 0169
		static Delegate GetHashCodeRemoteHandler ()
		{
			if (cb_hashCodeRemote == null)
				cb_hashCodeRemote = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_HashCodeRemote);
			return cb_hashCodeRemote;
		}

		static int n_HashCodeRemote (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Gms.Maps.Model.Internal.IPolylineDelegate __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Maps.Model.Internal.IPolylineDelegate> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HashCodeRemote ();
		}
#pragma warning restore 0169

		IntPtr id_hashCodeRemote;
		public int HashCodeRemote ()
		{
			if (id_hashCodeRemote == IntPtr.Zero)
				id_hashCodeRemote = JNIEnv.GetMethodID (class_ref, "hashCodeRemote", "()I");
			return JNIEnv.CallIntMethod (Handle, id_hashCodeRemote);
		}

		static Delegate cb_remove;
#pragma warning disable 0169
		static Delegate GetRemoveHandler ()
		{
			if (cb_remove == null)
				cb_remove = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Remove);
			return cb_remove;
		}

		static void n_Remove (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Gms.Maps.Model.Internal.IPolylineDelegate __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Maps.Model.Internal.IPolylineDelegate> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.Remove ();
		}
#pragma warning restore 0169

		IntPtr id_remove;
		public void Remove ()
		{
			if (id_remove == IntPtr.Zero)
				id_remove = JNIEnv.GetMethodID (class_ref, "remove", "()V");
			JNIEnv.CallVoidMethod (Handle, id_remove);
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
			global::Com.Google.Android.Gms.Maps.Model.Internal.IPolylineDelegate __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Maps.Model.Internal.IPolylineDelegate> (native__this, JniHandleOwnership.DoNotTransfer);
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
