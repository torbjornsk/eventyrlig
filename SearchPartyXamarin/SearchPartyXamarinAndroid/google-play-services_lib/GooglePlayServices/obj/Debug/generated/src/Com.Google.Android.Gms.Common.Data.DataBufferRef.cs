using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Gms.Common.Data {

	[global::Android.Runtime.Register ("com/google/android/gms/common/data/DataBufferRef", DoNotGenerateAcw=true)]
	public abstract partial class DataBufferRef : global::Java.Lang.Object {


		static IntPtr mDataHolder_jfieldId;

		[Register ("mDataHolder")]
		protected global::Com.Google.Android.Gms.Common.Data.DataHolder MDataHolder {
			get {
				if (mDataHolder_jfieldId == IntPtr.Zero)
					mDataHolder_jfieldId = JNIEnv.GetFieldID (class_ref, "mDataHolder", "Lcom/google/android/gms/common/data/DataHolder;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mDataHolder_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Common.Data.DataHolder> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mDataHolder_jfieldId == IntPtr.Zero)
					mDataHolder_jfieldId = JNIEnv.GetFieldID (class_ref, "mDataHolder", "Lcom/google/android/gms/common/data/DataHolder;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mDataHolder_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mDataRow_jfieldId;

		[Register ("mDataRow")]
		protected int MDataRow {
			get {
				if (mDataRow_jfieldId == IntPtr.Zero)
					mDataRow_jfieldId = JNIEnv.GetFieldID (class_ref, "mDataRow", "I");
				return JNIEnv.GetIntField (Handle, mDataRow_jfieldId);
			}
			set {
				if (mDataRow_jfieldId == IntPtr.Zero)
					mDataRow_jfieldId = JNIEnv.GetFieldID (class_ref, "mDataRow", "I");
				JNIEnv.SetField (Handle, mDataRow_jfieldId, value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/common/data/DataBufferRef", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DataBufferRef); }
		}

		protected DataBufferRef (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_google_android_gms_common_data_DataHolder_I;
		[Register (".ctor", "(Lcom/google/android/gms/common/data/DataHolder;I)V", "")]
		public DataBufferRef (global::Com.Google.Android.Gms.Common.Data.DataHolder p0, int p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (DataBufferRef)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Lcom/google/android/gms/common/data/DataHolder;I)V", new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor_Lcom_google_android_gms_common_data_DataHolder_I == IntPtr.Zero)
				id_ctor_Lcom_google_android_gms_common_data_DataHolder_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/google/android/gms/common/data/DataHolder;I)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Lcom_google_android_gms_common_data_DataHolder_I, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_copyToBuffer_Ljava_lang_String_Landroid_database_CharArrayBuffer_;
#pragma warning disable 0169
		static Delegate GetCopyToBuffer_Ljava_lang_String_Landroid_database_CharArrayBuffer_Handler ()
		{
			if (cb_copyToBuffer_Ljava_lang_String_Landroid_database_CharArrayBuffer_ == null)
				cb_copyToBuffer_Ljava_lang_String_Landroid_database_CharArrayBuffer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_CopyToBuffer_Ljava_lang_String_Landroid_database_CharArrayBuffer_);
			return cb_copyToBuffer_Ljava_lang_String_Landroid_database_CharArrayBuffer_;
		}

		static void n_CopyToBuffer_Ljava_lang_String_Landroid_database_CharArrayBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Google.Android.Gms.Common.Data.DataBufferRef __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Common.Data.DataBufferRef> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Database.CharArrayBuffer p1 = global::Java.Lang.Object.GetObject<global::Android.Database.CharArrayBuffer> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.CopyToBuffer (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_copyToBuffer_Ljava_lang_String_Landroid_database_CharArrayBuffer_;
		[Register ("copyToBuffer", "(Ljava/lang/String;Landroid/database/CharArrayBuffer;)V", "GetCopyToBuffer_Ljava_lang_String_Landroid_database_CharArrayBuffer_Handler")]
		protected virtual void CopyToBuffer (string p0, global::Android.Database.CharArrayBuffer p1)
		{
			if (id_copyToBuffer_Ljava_lang_String_Landroid_database_CharArrayBuffer_ == IntPtr.Zero)
				id_copyToBuffer_Ljava_lang_String_Landroid_database_CharArrayBuffer_ = JNIEnv.GetMethodID (class_ref, "copyToBuffer", "(Ljava/lang/String;Landroid/database/CharArrayBuffer;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_copyToBuffer_Ljava_lang_String_Landroid_database_CharArrayBuffer_, new JValue (native_p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_copyToBuffer_Ljava_lang_String_Landroid_database_CharArrayBuffer_, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_getBoolean_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetBoolean_Ljava_lang_String_Handler ()
		{
			if (cb_getBoolean_Ljava_lang_String_ == null)
				cb_getBoolean_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_GetBoolean_Ljava_lang_String_);
			return cb_getBoolean_Ljava_lang_String_;
		}

		static bool n_GetBoolean_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Android.Gms.Common.Data.DataBufferRef __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Common.Data.DataBufferRef> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.GetBoolean (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getBoolean_Ljava_lang_String_;
		[Register ("getBoolean", "(Ljava/lang/String;)Z", "GetGetBoolean_Ljava_lang_String_Handler")]
		protected virtual bool GetBoolean (string p0)
		{
			if (id_getBoolean_Ljava_lang_String_ == IntPtr.Zero)
				id_getBoolean_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getBoolean", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_getBoolean_Ljava_lang_String_, new JValue (native_p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_getBoolean_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getByteArray_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetByteArray_Ljava_lang_String_Handler ()
		{
			if (cb_getByteArray_Ljava_lang_String_ == null)
				cb_getByteArray_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetByteArray_Ljava_lang_String_);
			return cb_getByteArray_Ljava_lang_String_;
		}

		static IntPtr n_GetByteArray_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Android.Gms.Common.Data.DataBufferRef __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Common.Data.DataBufferRef> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.GetByteArray (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getByteArray_Ljava_lang_String_;
		[Register ("getByteArray", "(Ljava/lang/String;)[B", "GetGetByteArray_Ljava_lang_String_Handler")]
		protected virtual byte[] GetByteArray (string p0)
		{
			if (id_getByteArray_Ljava_lang_String_ == IntPtr.Zero)
				id_getByteArray_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getByteArray", "(Ljava/lang/String;)[B");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			byte[] __ret;
			if (GetType () == ThresholdType)
				__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getByteArray_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			else
				__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getByteArray_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getInteger_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetInteger_Ljava_lang_String_Handler ()
		{
			if (cb_getInteger_Ljava_lang_String_ == null)
				cb_getInteger_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetInteger_Ljava_lang_String_);
			return cb_getInteger_Ljava_lang_String_;
		}

		static int n_GetInteger_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Android.Gms.Common.Data.DataBufferRef __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Common.Data.DataBufferRef> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetInteger (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getInteger_Ljava_lang_String_;
		[Register ("getInteger", "(Ljava/lang/String;)I", "GetGetInteger_Ljava_lang_String_Handler")]
		protected virtual int GetInteger (string p0)
		{
			if (id_getInteger_Ljava_lang_String_ == IntPtr.Zero)
				id_getInteger_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getInteger", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			int __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallIntMethod  (Handle, id_getInteger_Ljava_lang_String_, new JValue (native_p0));
			else
				__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_getInteger_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getLong_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetLong_Ljava_lang_String_Handler ()
		{
			if (cb_getLong_Ljava_lang_String_ == null)
				cb_getLong_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long>) n_GetLong_Ljava_lang_String_);
			return cb_getLong_Ljava_lang_String_;
		}

		static long n_GetLong_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Android.Gms.Common.Data.DataBufferRef __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Common.Data.DataBufferRef> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.GetLong (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getLong_Ljava_lang_String_;
		[Register ("getLong", "(Ljava/lang/String;)J", "GetGetLong_Ljava_lang_String_Handler")]
		protected virtual long GetLong (string p0)
		{
			if (id_getLong_Ljava_lang_String_ == IntPtr.Zero)
				id_getLong_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getLong", "(Ljava/lang/String;)J");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			long __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallLongMethod  (Handle, id_getLong_Ljava_lang_String_, new JValue (native_p0));
			else
				__ret = JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, id_getLong_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getString_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetString_Ljava_lang_String_Handler ()
		{
			if (cb_getString_Ljava_lang_String_ == null)
				cb_getString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetString_Ljava_lang_String_);
			return cb_getString_Ljava_lang_String_;
		}

		static IntPtr n_GetString_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Android.Gms.Common.Data.DataBufferRef __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Common.Data.DataBufferRef> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetString (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getString_Ljava_lang_String_;
		[Register ("getString", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetString_Ljava_lang_String_Handler")]
		protected virtual string GetString (string p0)
		{
			if (id_getString_Ljava_lang_String_ == IntPtr.Zero)
				id_getString_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getString", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			string __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getString_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getString_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_hasNull_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetHasNull_Ljava_lang_String_Handler ()
		{
			if (cb_hasNull_Ljava_lang_String_ == null)
				cb_hasNull_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_HasNull_Ljava_lang_String_);
			return cb_hasNull_Ljava_lang_String_;
		}

		static bool n_HasNull_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Android.Gms.Common.Data.DataBufferRef __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Common.Data.DataBufferRef> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.HasNull (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_hasNull_Ljava_lang_String_;
		[Register ("hasNull", "(Ljava/lang/String;)Z", "GetHasNull_Ljava_lang_String_Handler")]
		protected virtual bool HasNull (string p0)
		{
			if (id_hasNull_Ljava_lang_String_ == IntPtr.Zero)
				id_hasNull_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "hasNull", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_hasNull_Ljava_lang_String_, new JValue (native_p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_hasNull_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_parseUri_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetParseUri_Ljava_lang_String_Handler ()
		{
			if (cb_parseUri_Ljava_lang_String_ == null)
				cb_parseUri_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ParseUri_Ljava_lang_String_);
			return cb_parseUri_Ljava_lang_String_;
		}

		static IntPtr n_ParseUri_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Android.Gms.Common.Data.DataBufferRef __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Common.Data.DataBufferRef> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ParseUri (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_parseUri_Ljava_lang_String_;
		[Register ("parseUri", "(Ljava/lang/String;)Landroid/net/Uri;", "GetParseUri_Ljava_lang_String_Handler")]
		protected virtual global::Android.Net.Uri ParseUri (string p0)
		{
			if (id_parseUri_Ljava_lang_String_ == IntPtr.Zero)
				id_parseUri_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "parseUri", "(Ljava/lang/String;)Landroid/net/Uri;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::Android.Net.Uri __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallObjectMethod  (Handle, id_parseUri_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_parseUri_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}

	[global::Android.Runtime.Register ("com/google/android/gms/common/data/DataBufferRef", DoNotGenerateAcw=true)]
	internal partial class DataBufferRefInvoker : DataBufferRef {

		public DataBufferRefInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (DataBufferRefInvoker); }
		}

	}

}
