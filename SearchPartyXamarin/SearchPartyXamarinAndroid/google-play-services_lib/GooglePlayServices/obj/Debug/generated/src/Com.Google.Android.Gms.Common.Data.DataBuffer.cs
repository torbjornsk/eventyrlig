using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Gms.Common.Data {

	[global::Android.Runtime.Register ("com/google/android/gms/common/data/DataBuffer", DoNotGenerateAcw=true)]
	public abstract partial class DataBuffer : global::Java.Lang.Object, global::Java.Lang.IIterable {


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
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/common/data/DataBuffer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DataBuffer); }
		}

		protected DataBuffer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_google_android_gms_common_data_DataHolder_;
		[Register (".ctor", "(Lcom/google/android/gms/common/data/DataHolder;)V", "")]
		public DataBuffer (global::Com.Google.Android.Gms.Common.Data.DataHolder p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (DataBuffer)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Lcom/google/android/gms/common/data/DataHolder;)V", new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor_Lcom_google_android_gms_common_data_DataHolder_ == IntPtr.Zero)
				id_ctor_Lcom_google_android_gms_common_data_DataHolder_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/google/android/gms/common/data/DataHolder;)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Lcom_google_android_gms_common_data_DataHolder_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getCount;
#pragma warning disable 0169
		static Delegate GetGetCountHandler ()
		{
			if (cb_getCount == null)
				cb_getCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCount);
			return cb_getCount;
		}

		static int n_GetCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Gms.Common.Data.DataBuffer __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Common.Data.DataBuffer> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Count;
		}
#pragma warning restore 0169

		static IntPtr id_getCount;
		public virtual int Count {
			[Register ("getCount", "()I", "GetGetCountHandler")]
			get {
				if (id_getCount == IntPtr.Zero)
					id_getCount = JNIEnv.GetMethodID (class_ref, "getCount", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getCount);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_getCount);
			}
		}

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Gms.Common.Data.DataBuffer __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Common.Data.DataBuffer> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		static IntPtr id_close;
		[Register ("close", "()V", "GetCloseHandler")]
		public virtual void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_close);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_close);
		}

		static Delegate cb_describeContents;
#pragma warning disable 0169
		static Delegate GetDescribeContentsHandler ()
		{
			if (cb_describeContents == null)
				cb_describeContents = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_DescribeContents);
			return cb_describeContents;
		}

		static int n_DescribeContents (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Gms.Common.Data.DataBuffer __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Common.Data.DataBuffer> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		[Register ("describeContents", "()I", "GetDescribeContentsHandler")]
		public virtual int DescribeContents ()
		{
			if (id_describeContents == IntPtr.Zero)
				id_describeContents = JNIEnv.GetMethodID (class_ref, "describeContents", "()I");

			if (GetType () == ThresholdType)
				return JNIEnv.CallIntMethod  (Handle, id_describeContents);
			else
				return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_describeContents);
		}

		static Delegate cb_get_I;
#pragma warning disable 0169
		static Delegate GetGet_IHandler ()
		{
			if (cb_get_I == null)
				cb_get_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_Get_I);
			return cb_get_I;
		}

		static IntPtr n_Get_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Google.Android.Gms.Common.Data.DataBuffer __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Common.Data.DataBuffer> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Get (p0));
		}
#pragma warning restore 0169

		[Register ("get", "(I)Ljava/lang/Object;", "GetGet_IHandler")]
		public abstract global::Java.Lang.Object Get (int p0);

		static Delegate cb_iterator;
#pragma warning disable 0169
		static Delegate GetIteratorHandler ()
		{
			if (cb_iterator == null)
				cb_iterator = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Iterator);
			return cb_iterator;
		}

		static IntPtr n_Iterator (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Gms.Common.Data.DataBuffer __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Common.Data.DataBuffer> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Iterator ());
		}
#pragma warning restore 0169

		static IntPtr id_iterator;
		[Register ("iterator", "()Ljava/util/Iterator;", "GetIteratorHandler")]
		public virtual global::Java.Util.IIterator Iterator ()
		{
			if (id_iterator == IntPtr.Zero)
				id_iterator = JNIEnv.GetMethodID (class_ref, "iterator", "()Ljava/util/Iterator;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Java.Util.IIterator> (JNIEnv.CallObjectMethod  (Handle, id_iterator), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Java.Util.IIterator> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_iterator), JniHandleOwnership.TransferLocalRef);
		}

	}

	[global::Android.Runtime.Register ("com/google/android/gms/common/data/DataBuffer", DoNotGenerateAcw=true)]
	internal partial class DataBufferInvoker : DataBuffer {

		public DataBufferInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (DataBufferInvoker); }
		}

		static IntPtr id_get_I;
		[Register ("get", "(I)Ljava/lang/Object;", "GetGet_IHandler")]
		public override global::Java.Lang.Object Get (int p0)
		{
			if (id_get_I == IntPtr.Zero)
				id_get_I = JNIEnv.GetMethodID (class_ref, "get", "(I)Ljava/lang/Object;");
			return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_get_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

	}

}
