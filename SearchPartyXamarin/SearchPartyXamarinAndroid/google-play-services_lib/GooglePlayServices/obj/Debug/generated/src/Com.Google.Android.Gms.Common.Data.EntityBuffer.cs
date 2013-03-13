using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Gms.Common.Data {

	[global::Android.Runtime.Register ("com/google/android/gms/common/data/EntityBuffer", DoNotGenerateAcw=true)]
	public abstract partial class EntityBuffer : global::Com.Google.Android.Gms.Common.Data.DataBuffer {

		protected EntityBuffer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}

	[global::Android.Runtime.Register ("com/google/android/gms/common/data/EntityBuffer", DoNotGenerateAcw=true)]
	internal partial class EntityBufferInvoker : EntityBuffer {

		public EntityBufferInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (EntityBufferInvoker); }
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
