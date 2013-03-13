using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Gms.Common.Data {

	[global::Android.Runtime.Register ("com/google/android/gms/common/data/DataBufferIterator", DoNotGenerateAcw=true)]
	public sealed partial class DataBufferIterator : global::Java.Lang.Object, global::Java.Util.IIterator {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/common/data/DataBufferIterator", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DataBufferIterator); }
		}

		internal DataBufferIterator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_google_android_gms_common_data_DataBuffer_;
		[Register (".ctor", "(Lcom/google/android/gms/common/data/DataBuffer;)V", "")]
		public DataBufferIterator (global::Com.Google.Android.Gms.Common.Data.DataBuffer p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (DataBufferIterator)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Lcom/google/android/gms/common/data/DataBuffer;)V", new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor_Lcom_google_android_gms_common_data_DataBuffer_ == IntPtr.Zero)
				id_ctor_Lcom_google_android_gms_common_data_DataBuffer_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/google/android/gms/common/data/DataBuffer;)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Lcom_google_android_gms_common_data_DataBuffer_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_hasNext;
		public bool HasNext {
			[Register ("hasNext", "()Z", "GetHasNextHandler")]
			get {
				if (id_hasNext == IntPtr.Zero)
					id_hasNext = JNIEnv.GetMethodID (class_ref, "hasNext", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_hasNext);
			}
		}

		static IntPtr id_next;
		[Register ("next", "()Ljava/lang/Object;", "")]
		public global::Java.Lang.Object Next ()
		{
			if (id_next == IntPtr.Zero)
				id_next = JNIEnv.GetMethodID (class_ref, "next", "()Ljava/lang/Object;");
			return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_next), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_remove;
		[Register ("remove", "()V", "")]
		public void Remove ()
		{
			if (id_remove == IntPtr.Zero)
				id_remove = JNIEnv.GetMethodID (class_ref, "remove", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_remove);
		}

	}
}
