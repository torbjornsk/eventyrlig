using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Provider;


namespace SearchPartyXamarinAndroid
{
	[Activity (Label = "SearchPartyXamarinAndroid", MainLauncher = true)]
	public class MainActivity : Activity
	{
		int count = 1;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.SearchMap);

			// Get our button from the layout resource,
			// and attach an event to it
			//Button button = FindViewById<Button> (Resource.Id.myButton);

			//button.Click += delegate {
			//	button.Text = string.Format ("{0} clicks!", count++);
			//};

			Button activityButton = FindViewById<Button> (Resource.Id.myActivityButton);

			activityButton.Click += delegate {
				var intent = new Intent (this, typeof(CameraActivity));
				StartActivity(intent);
			};
		}
	}
}


