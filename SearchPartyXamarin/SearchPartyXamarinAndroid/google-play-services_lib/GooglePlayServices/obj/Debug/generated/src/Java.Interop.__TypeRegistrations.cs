using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Java.Interop {

	partial class __TypeRegistrations {

		public static void RegisterPackages ()
		{
#if MONODROID_TIMING
			var start = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages start: " + (start - new DateTime (1970, 1, 1)).TotalMilliseconds);
#endif // def MONODROID_TIMING
			Java.Interop.TypeManager.RegisterPackages (
					new string[]{
						"com/google/android/gms/plus/model/moments",
						"com/google/android/gms/plus/model/people",
					},
					new Converter<string, Type>[]{
						lookup_com_google_android_gms_plus_model_moments_package,
						lookup_com_google_android_gms_plus_model_people_package,
					});
#if MONODROID_TIMING
			var end = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages time: " + (end - new DateTime (1970, 1, 1)).TotalMilliseconds + " [elapsed: " + (end - start).TotalMilliseconds + " ms]");
#endif // def MONODROID_TIMING
		}

		static Type Lookup (string[] mappings, string javaType)
		{
			string managedType = Java.Interop.TypeManager.LookupTypeMapping (mappings, javaType);
			if (managedType == null)
				return null;
			return Type.GetType (managedType);
		}

		static string[] package_com_google_android_gms_plus_model_moments_mappings;
		static Type lookup_com_google_android_gms_plus_model_moments_package (string klass)
		{
			if (package_com_google_android_gms_plus_model_moments_mappings == null) {
				package_com_google_android_gms_plus_model_moments_mappings = new string[]{
					"com/google/android/gms/plus/model/moments/ItemScope$Builder:Com.Google.Android.Gms.Plus.Model.Moments.ItemScopeBuilder",
					"com/google/android/gms/plus/model/moments/Moment$Builder:Com.Google.Android.Gms.Plus.Model.Moments.MomentBuilder",
				};
			}

			return Lookup (package_com_google_android_gms_plus_model_moments_mappings, klass);
		}

		static string[] package_com_google_android_gms_plus_model_people_mappings;
		static Type lookup_com_google_android_gms_plus_model_people_package (string klass)
		{
			if (package_com_google_android_gms_plus_model_people_mappings == null) {
				package_com_google_android_gms_plus_model_people_mappings = new string[]{
					"com/google/android/gms/plus/model/people/Person$Cover$Layout:Com.Google.Android.Gms.Plus.Model.People.PersonCoverLayout",
					"com/google/android/gms/plus/model/people/Person$Emails$Type:Com.Google.Android.Gms.Plus.Model.People.PersonEmailsType",
					"com/google/android/gms/plus/model/people/Person$Gender:Com.Google.Android.Gms.Plus.Model.People.PersonGender",
					"com/google/android/gms/plus/model/people/Person$ObjectType:Com.Google.Android.Gms.Plus.Model.People.PersonObjectType",
					"com/google/android/gms/plus/model/people/Person$Organizations$Type:Com.Google.Android.Gms.Plus.Model.People.PersonOrganizationsType",
					"com/google/android/gms/plus/model/people/Person$RelationshipStatus:Com.Google.Android.Gms.Plus.Model.People.PersonRelationshipStatus",
					"com/google/android/gms/plus/model/people/Person$Urls$Type:Com.Google.Android.Gms.Plus.Model.People.PersonUrlsType",
				};
			}

			return Lookup (package_com_google_android_gms_plus_model_people_mappings, klass);
		}
	}
}
