using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Gms.Common.Data {

	[global::Android.Runtime.Register ("com/google/android/gms/common/data/DataHolder", DoNotGenerateAcw=true)]
	public sealed partial class DataHolder : global::Java.Lang.Object {


		static IntPtr CREATOR_jfieldId;

		[Register ("CREATOR")]
		public static global::Com.Google.Android.Gms.Common.Data.DataHolderCreator Creator {
			get {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Lcom/google/android/gms/common/data/DataHolderCreator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Common.Data.DataHolderCreator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Lcom/google/android/gms/common/data/DataHolderCreator;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, CREATOR_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		[global::Android.Runtime.Register ("com/google/android/gms/common/data/DataHolder$Builder", DoNotGenerateAcw=true)]
		public partial class Builder : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/android/gms/common/data/DataHolder$Builder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Builder); }
			}

			protected Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
				global::Com.Google.Android.Gms.Common.Data.DataHolder.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Common.Data.DataHolder.Builder> (native__this, JniHandleOwnership.DoNotTransfer);
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

			static Delegate cb_build_I;
#pragma warning disable 0169
			static Delegate GetBuild_IHandler ()
			{
				if (cb_build_I == null)
					cb_build_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_Build_I);
				return cb_build_I;
			}

			static IntPtr n_Build_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Google.Android.Gms.Common.Data.DataHolder.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Common.Data.DataHolder.Builder> (native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build (p0));
			}
#pragma warning restore 0169

			static IntPtr id_build_I;
			[Register ("build", "(I)Lcom/google/android/gms/common/data/DataHolder;", "GetBuild_IHandler")]
			public virtual global::Com.Google.Android.Gms.Common.Data.DataHolder Build (int p0)
			{
				if (id_build_I == IntPtr.Zero)
					id_build_I = JNIEnv.GetMethodID (class_ref, "build", "(I)Lcom/google/android/gms/common/data/DataHolder;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Common.Data.DataHolder> (JNIEnv.CallObjectMethod  (Handle, id_build_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Common.Data.DataHolder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_build_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_build_ILandroid_os_Bundle_;
#pragma warning disable 0169
			static Delegate GetBuild_ILandroid_os_Bundle_Handler ()
			{
				if (cb_build_ILandroid_os_Bundle_ == null)
					cb_build_ILandroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_Build_ILandroid_os_Bundle_);
				return cb_build_ILandroid_os_Bundle_;
			}

			static IntPtr n_Build_ILandroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
			{
				global::Com.Google.Android.Gms.Common.Data.DataHolder.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Common.Data.DataHolder.Builder> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Build (p0, p1));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_build_ILandroid_os_Bundle_;
			[Register ("build", "(ILandroid/os/Bundle;)Lcom/google/android/gms/common/data/DataHolder;", "GetBuild_ILandroid_os_Bundle_Handler")]
			public virtual global::Com.Google.Android.Gms.Common.Data.DataHolder Build (int p0, global::Android.OS.Bundle p1)
			{
				if (id_build_ILandroid_os_Bundle_ == IntPtr.Zero)
					id_build_ILandroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "build", "(ILandroid/os/Bundle;)Lcom/google/android/gms/common/data/DataHolder;");

				global::Com.Google.Android.Gms.Common.Data.DataHolder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Common.Data.DataHolder> (JNIEnv.CallObjectMethod  (Handle, id_build_ILandroid_os_Bundle_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Common.Data.DataHolder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_build_ILandroid_os_Bundle_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static Delegate cb_sort_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSort_Ljava_lang_String_Handler ()
			{
				if (cb_sort_Ljava_lang_String_ == null)
					cb_sort_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Sort_Ljava_lang_String_);
				return cb_sort_Ljava_lang_String_;
			}

			static IntPtr n_Sort_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Google.Android.Gms.Common.Data.DataHolder.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Common.Data.DataHolder.Builder> (native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Sort (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_sort_Ljava_lang_String_;
			[Register ("sort", "(Ljava/lang/String;)Lcom/google/android/gms/common/data/DataHolder$Builder;", "GetSort_Ljava_lang_String_Handler")]
			public virtual global::Com.Google.Android.Gms.Common.Data.DataHolder.Builder Sort (string p0)
			{
				if (id_sort_Ljava_lang_String_ == IntPtr.Zero)
					id_sort_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "sort", "(Ljava/lang/String;)Lcom/google/android/gms/common/data/DataHolder$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);

				global::Com.Google.Android.Gms.Common.Data.DataHolder.Builder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Common.Data.DataHolder.Builder> (JNIEnv.CallObjectMethod  (Handle, id_sort_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Common.Data.DataHolder.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_sort_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static Delegate cb_withRow_Landroid_content_ContentValues_;
#pragma warning disable 0169
			static Delegate GetWithRow_Landroid_content_ContentValues_Handler ()
			{
				if (cb_withRow_Landroid_content_ContentValues_ == null)
					cb_withRow_Landroid_content_ContentValues_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithRow_Landroid_content_ContentValues_);
				return cb_withRow_Landroid_content_ContentValues_;
			}

			static IntPtr n_WithRow_Landroid_content_ContentValues_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Google.Android.Gms.Common.Data.DataHolder.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Common.Data.DataHolder.Builder> (native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Content.ContentValues p0 = global::Java.Lang.Object.GetObject<global::Android.Content.ContentValues> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithRow (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_withRow_Landroid_content_ContentValues_;
			[Register ("withRow", "(Landroid/content/ContentValues;)Lcom/google/android/gms/common/data/DataHolder$Builder;", "GetWithRow_Landroid_content_ContentValues_Handler")]
			public virtual global::Com.Google.Android.Gms.Common.Data.DataHolder.Builder WithRow (global::Android.Content.ContentValues p0)
			{
				if (id_withRow_Landroid_content_ContentValues_ == IntPtr.Zero)
					id_withRow_Landroid_content_ContentValues_ = JNIEnv.GetMethodID (class_ref, "withRow", "(Landroid/content/ContentValues;)Lcom/google/android/gms/common/data/DataHolder$Builder;");

				global::Com.Google.Android.Gms.Common.Data.DataHolder.Builder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Common.Data.DataHolder.Builder> (JNIEnv.CallObjectMethod  (Handle, id_withRow_Landroid_content_ContentValues_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Common.Data.DataHolder.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_withRow_Landroid_content_ContentValues_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static Delegate cb_withRow_Ljava_util_HashMap_;
#pragma warning disable 0169
			static Delegate GetWithRow_Ljava_util_HashMap_Handler ()
			{
				if (cb_withRow_Ljava_util_HashMap_ == null)
					cb_withRow_Ljava_util_HashMap_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithRow_Ljava_util_HashMap_);
				return cb_withRow_Ljava_util_HashMap_;
			}

			static IntPtr n_WithRow_Ljava_util_HashMap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Google.Android.Gms.Common.Data.DataHolder.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Common.Data.DataHolder.Builder> (native__this, JniHandleOwnership.DoNotTransfer);
				System.Collections.Generic.IDictionary<string, Java.Lang.Object> p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithRow (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_withRow_Ljava_util_HashMap_;
			[Register ("withRow", "(Ljava/util/HashMap;)Lcom/google/android/gms/common/data/DataHolder$Builder;", "GetWithRow_Ljava_util_HashMap_Handler")]
			public virtual global::Com.Google.Android.Gms.Common.Data.DataHolder.Builder WithRow (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0)
			{
				if (id_withRow_Ljava_util_HashMap_ == IntPtr.Zero)
					id_withRow_Ljava_util_HashMap_ = JNIEnv.GetMethodID (class_ref, "withRow", "(Ljava/util/HashMap;)Lcom/google/android/gms/common/data/DataHolder$Builder;");
				IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);

				global::Com.Google.Android.Gms.Common.Data.DataHolder.Builder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Common.Data.DataHolder.Builder> (JNIEnv.CallObjectMethod  (Handle, id_withRow_Ljava_util_HashMap_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Common.Data.DataHolder.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_withRow_Ljava_util_HashMap_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/common/data/DataHolder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DataHolder); }
		}

		internal DataHolder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_database_AbstractWindowedCursor_ILandroid_os_Bundle_;
		[Register (".ctor", "(Landroid/database/AbstractWindowedCursor;ILandroid/os/Bundle;)V", "")]
		public DataHolder (global::Android.Database.AbstractWindowedCursor p0, int p1, global::Android.OS.Bundle p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (DataHolder)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Landroid/database/AbstractWindowedCursor;ILandroid/os/Bundle;)V", new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor_Landroid_database_AbstractWindowedCursor_ILandroid_os_Bundle_ == IntPtr.Zero)
				id_ctor_Landroid_database_AbstractWindowedCursor_ILandroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/database/AbstractWindowedCursor;ILandroid/os/Bundle;)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Landroid_database_AbstractWindowedCursor_ILandroid_os_Bundle_, new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_ctor_arrayLjava_lang_String_arrayLandroid_database_CursorWindow_ILandroid_os_Bundle_;
		[Register (".ctor", "([Ljava/lang/String;[Landroid/database/CursorWindow;ILandroid/os/Bundle;)V", "")]
		public DataHolder (string[] p0, global::Android.Database.CursorWindow[] p1, int p2, global::Android.OS.Bundle p3) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);;
			IntPtr native_p1 = JNIEnv.NewArray (p1);;
			if (GetType () != typeof (DataHolder)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "([Ljava/lang/String;[Landroid/database/CursorWindow;ILandroid/os/Bundle;)V", new JValue (native_p0), new JValue (native_p1), new JValue (p2), new JValue (p3)), JniHandleOwnership.TransferLocalRef);
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				return;
			}

			if (id_ctor_arrayLjava_lang_String_arrayLandroid_database_CursorWindow_ILandroid_os_Bundle_ == IntPtr.Zero)
				id_ctor_arrayLjava_lang_String_arrayLandroid_database_CursorWindow_ILandroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "<init>", "([Ljava/lang/String;[Landroid/database/CursorWindow;ILandroid/os/Bundle;)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_arrayLjava_lang_String_arrayLandroid_database_CursorWindow_ILandroid_os_Bundle_, new JValue (native_p0), new JValue (native_p1), new JValue (p2), new JValue (p3)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_getCount;
		public int Count {
			[Register ("getCount", "()I", "GetGetCountHandler")]
			get {
				if (id_getCount == IntPtr.Zero)
					id_getCount = JNIEnv.GetMethodID (class_ref, "getCount", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getCount);
			}
		}

		static IntPtr id_isClosed;
		public bool IsClosed {
			[Register ("isClosed", "()Z", "GetIsClosedHandler")]
			get {
				if (id_isClosed == IntPtr.Zero)
					id_isClosed = JNIEnv.GetMethodID (class_ref, "isClosed", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isClosed);
			}
		}

		static IntPtr id_getStatusCode;
		public int StatusCode {
			[Register ("getStatusCode", "()I", "GetGetStatusCodeHandler")]
			get {
				if (id_getStatusCode == IntPtr.Zero)
					id_getStatusCode = JNIEnv.GetMethodID (class_ref, "getStatusCode", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getStatusCode);
			}
		}

		static IntPtr id_aS;
		[Register ("aS", "()Landroid/os/Bundle;", "")]
		public global::Android.OS.Bundle AS ()
		{
			if (id_aS == IntPtr.Zero)
				id_aS = JNIEnv.GetMethodID (class_ref, "aS", "()Landroid/os/Bundle;");
			return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod  (Handle, id_aS), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_builder_arrayLjava_lang_String_;
		[Register ("builder", "([Ljava/lang/String;)Lcom/google/android/gms/common/data/DataHolder$Builder;", "")]
		public static global::Com.Google.Android.Gms.Common.Data.DataHolder.Builder InvokeBuilder (string[] p0)
		{
			if (id_builder_arrayLjava_lang_String_ == IntPtr.Zero)
				id_builder_arrayLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "builder", "([Ljava/lang/String;)Lcom/google/android/gms/common/data/DataHolder$Builder;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			global::Com.Google.Android.Gms.Common.Data.DataHolder.Builder __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Common.Data.DataHolder.Builder> (JNIEnv.CallStaticObjectMethod  (class_ref, id_builder_arrayLjava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_builder_arrayLjava_lang_String_Ljava_lang_String_;
		[Register ("builder", "([Ljava/lang/String;Ljava/lang/String;)Lcom/google/android/gms/common/data/DataHolder$Builder;", "")]
		public static global::Com.Google.Android.Gms.Common.Data.DataHolder.Builder InvokeBuilder (string[] p0, string p1)
		{
			if (id_builder_arrayLjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_builder_arrayLjava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "builder", "([Ljava/lang/String;Ljava/lang/String;)Lcom/google/android/gms/common/data/DataHolder$Builder;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			global::Com.Google.Android.Gms.Common.Data.DataHolder.Builder __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Common.Data.DataHolder.Builder> (JNIEnv.CallStaticObjectMethod  (class_ref, id_builder_arrayLjava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_close;
		[Register ("close", "()V", "")]
		public void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_close);
		}

		static IntPtr id_copyToBuffer_Ljava_lang_String_IILandroid_database_CharArrayBuffer_;
		[Register ("copyToBuffer", "(Ljava/lang/String;IILandroid/database/CharArrayBuffer;)V", "")]
		public void CopyToBuffer (string p0, int p1, int p2, global::Android.Database.CharArrayBuffer p3)
		{
			if (id_copyToBuffer_Ljava_lang_String_IILandroid_database_CharArrayBuffer_ == IntPtr.Zero)
				id_copyToBuffer_Ljava_lang_String_IILandroid_database_CharArrayBuffer_ = JNIEnv.GetMethodID (class_ref, "copyToBuffer", "(Ljava/lang/String;IILandroid/database/CharArrayBuffer;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallVoidMethod  (Handle, id_copyToBuffer_Ljava_lang_String_IILandroid_database_CharArrayBuffer_, new JValue (native_p0), new JValue (p1), new JValue (p2), new JValue (p3));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_describeContents;
		[Register ("describeContents", "()I", "")]
		public int DescribeContents ()
		{
			if (id_describeContents == IntPtr.Zero)
				id_describeContents = JNIEnv.GetMethodID (class_ref, "describeContents", "()I");
			return JNIEnv.CallIntMethod  (Handle, id_describeContents);
		}

		static IntPtr id_empty_I;
		[Register ("empty", "(I)Lcom/google/android/gms/common/data/DataHolder;", "")]
		public static global::Com.Google.Android.Gms.Common.Data.DataHolder Empty (int p0)
		{
			if (id_empty_I == IntPtr.Zero)
				id_empty_I = JNIEnv.GetStaticMethodID (class_ref, "empty", "(I)Lcom/google/android/gms/common/data/DataHolder;");
			return global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Common.Data.DataHolder> (JNIEnv.CallStaticObjectMethod  (class_ref, id_empty_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_empty_ILandroid_os_Bundle_;
		[Register ("empty", "(ILandroid/os/Bundle;)Lcom/google/android/gms/common/data/DataHolder;", "")]
		public static global::Com.Google.Android.Gms.Common.Data.DataHolder Empty (int p0, global::Android.OS.Bundle p1)
		{
			if (id_empty_ILandroid_os_Bundle_ == IntPtr.Zero)
				id_empty_ILandroid_os_Bundle_ = JNIEnv.GetStaticMethodID (class_ref, "empty", "(ILandroid/os/Bundle;)Lcom/google/android/gms/common/data/DataHolder;");
			global::Com.Google.Android.Gms.Common.Data.DataHolder __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Common.Data.DataHolder> (JNIEnv.CallStaticObjectMethod  (class_ref, id_empty_ILandroid_os_Bundle_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_getBoolean_Ljava_lang_String_II;
		[Register ("getBoolean", "(Ljava/lang/String;II)Z", "")]
		public bool GetBoolean (string p0, int p1, int p2)
		{
			if (id_getBoolean_Ljava_lang_String_II == IntPtr.Zero)
				id_getBoolean_Ljava_lang_String_II = JNIEnv.GetMethodID (class_ref, "getBoolean", "(Ljava/lang/String;II)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_getBoolean_Ljava_lang_String_II, new JValue (native_p0), new JValue (p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_getByteArray_Ljava_lang_String_II;
		[Register ("getByteArray", "(Ljava/lang/String;II)[B", "")]
		public byte[] GetByteArray (string p0, int p1, int p2)
		{
			if (id_getByteArray_Ljava_lang_String_II == IntPtr.Zero)
				id_getByteArray_Ljava_lang_String_II = JNIEnv.GetMethodID (class_ref, "getByteArray", "(Ljava/lang/String;II)[B");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getByteArray_Ljava_lang_String_II, new JValue (native_p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_getInteger_Ljava_lang_String_II;
		[Register ("getInteger", "(Ljava/lang/String;II)I", "")]
		public int GetInteger (string p0, int p1, int p2)
		{
			if (id_getInteger_Ljava_lang_String_II == IntPtr.Zero)
				id_getInteger_Ljava_lang_String_II = JNIEnv.GetMethodID (class_ref, "getInteger", "(Ljava/lang/String;II)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			int __ret = JNIEnv.CallIntMethod  (Handle, id_getInteger_Ljava_lang_String_II, new JValue (native_p0), new JValue (p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_getLong_Ljava_lang_String_II;
		[Register ("getLong", "(Ljava/lang/String;II)J", "")]
		public long GetLong (string p0, int p1, int p2)
		{
			if (id_getLong_Ljava_lang_String_II == IntPtr.Zero)
				id_getLong_Ljava_lang_String_II = JNIEnv.GetMethodID (class_ref, "getLong", "(Ljava/lang/String;II)J");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			long __ret = JNIEnv.CallLongMethod  (Handle, id_getLong_Ljava_lang_String_II, new JValue (native_p0), new JValue (p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_getString_Ljava_lang_String_II;
		[Register ("getString", "(Ljava/lang/String;II)Ljava/lang/String;", "")]
		public string GetString (string p0, int p1, int p2)
		{
			if (id_getString_Ljava_lang_String_II == IntPtr.Zero)
				id_getString_Ljava_lang_String_II = JNIEnv.GetMethodID (class_ref, "getString", "(Ljava/lang/String;II)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getString_Ljava_lang_String_II, new JValue (native_p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_hasNull_Ljava_lang_String_II;
		[Register ("hasNull", "(Ljava/lang/String;II)Z", "")]
		public bool HasNull (string p0, int p1, int p2)
		{
			if (id_hasNull_Ljava_lang_String_II == IntPtr.Zero)
				id_hasNull_Ljava_lang_String_II = JNIEnv.GetMethodID (class_ref, "hasNull", "(Ljava/lang/String;II)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_hasNull_Ljava_lang_String_II, new JValue (native_p0), new JValue (p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_parseUri_Ljava_lang_String_II;
		[Register ("parseUri", "(Ljava/lang/String;II)Landroid/net/Uri;", "")]
		public global::Android.Net.Uri ParseUri (string p0, int p1, int p2)
		{
			if (id_parseUri_Ljava_lang_String_II == IntPtr.Zero)
				id_parseUri_Ljava_lang_String_II = JNIEnv.GetMethodID (class_ref, "parseUri", "(Ljava/lang/String;II)Landroid/net/Uri;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Android.Net.Uri __ret = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallObjectMethod  (Handle, id_parseUri_Ljava_lang_String_II, new JValue (native_p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_s_I;
		[Register ("s", "(I)I", "")]
		public int S (int p0)
		{
			if (id_s_I == IntPtr.Zero)
				id_s_I = JNIEnv.GetMethodID (class_ref, "s", "(I)I");
			return JNIEnv.CallIntMethod  (Handle, id_s_I, new JValue (p0));
		}

		static IntPtr id_validateContents;
		[Register ("validateContents", "()V", "")]
		public void ValidateContents ()
		{
			if (id_validateContents == IntPtr.Zero)
				id_validateContents = JNIEnv.GetMethodID (class_ref, "validateContents", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_validateContents);
		}

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "")]
		public void WriteToParcel (global::Android.OS.Parcel p0, int p1)
		{
			if (id_writeToParcel_Landroid_os_Parcel_I == IntPtr.Zero)
				id_writeToParcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "writeToParcel", "(Landroid/os/Parcel;I)V");
			JNIEnv.CallVoidMethod  (Handle, id_writeToParcel_Landroid_os_Parcel_I, new JValue (p0), new JValue (p1));
		}

	}
}
