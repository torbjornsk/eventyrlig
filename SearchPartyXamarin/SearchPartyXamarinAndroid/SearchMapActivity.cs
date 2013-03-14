using System;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Provider;
//using Android.GoogleMaps;
//using Android.Support.V4.App;

namespace SearchPartyXamarinAndroid
{
	[Activity (Label = "SearchMapActivity")]			
	public class SearchMapActivity : /*Map*/Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			//SetContentView (Resource.Layout.SearchMap);                     
		}
		/*
		protected override bool IsRouteDisplayed {
			get {
				return false;              }
		}
		*/
	}
}