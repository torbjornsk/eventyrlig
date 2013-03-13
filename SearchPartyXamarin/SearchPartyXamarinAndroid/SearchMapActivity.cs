using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.GoogleMaps;
using Android.Support.V4.App;

namespace SearchPartyXamarinAndroid
{
	[Activity (Label = "SearchMapActivity")]			
	public class SearchMapActivity : MapActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.SearchMap);                     
		}
		
		protected override bool IsRouteDisplayed {
			get {
				return false;              }
		}
	}
}

