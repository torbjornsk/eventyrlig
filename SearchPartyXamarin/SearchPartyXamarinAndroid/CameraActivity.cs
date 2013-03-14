
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
using Android.Provider;

namespace SearchPartyXamarinAndroid
{
	[Activity (Label = "CameraActivity")]			
	public class CameraActivity : Activity
	{

		Java.IO.File _file;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Create your application here

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Camera);
			
			// Get our button from the layout resource,
			// and attach an event to it
			Button activityButton = FindViewById<Button> (Resource.Id.myActivityButton);
			
			activityButton.Click += delegate {
				Finish();
				// var intent = new Intent (this, typeof(MainActivity));
				// StartActivity (intent);
			};

			Button cameraButton = FindViewById<Button> (Resource.Id.myCameraButton);

			cameraButton.Click += delegate {
				
				var intent = new Intent (MediaStore.ActionImageCapture);
				
				//int matchDefaultOnly = 65536;
				Android.Content.PM.PackageInfoFlags matchDefaultOnly = Android.Content.PM.PackageInfoFlags.MatchDefaultOnly;
				//Android.Content.PM.PackageInfoFlags
				var availableActivities = this.PackageManager.QueryIntentActivities (intent,
				                                                                     matchDefaultOnly);
				
				if (availableActivities != null && availableActivities.Count > 0) {              
					var dir = new Java.IO.File (
						Android.OS.Environment.GetExternalStoragePublicDirectory (
						Android.OS.Environment.DirectoryPictures), "CameraAppDemo");     
					
					if (!dir.Exists ()) {
						dir.Mkdirs ();  
					}   
					
					_file = new Java.IO.File (dir, String.Format ("myPhoto{0}.jpg", Guid.NewGuid ()));     
					
					intent.PutExtra (MediaStore.ExtraOutput,
					                 Android.Net.Uri.FromFile (_file));                    
					StartActivityForResult (intent, 0);
				}
			};
		}

		protected override void OnActivityResult (int requestCode, Result resultCode,
		                                          Android.Content.Intent data)
		{
			base.OnActivityResult (requestCode, resultCode, data);
			var imageView = FindViewById<ImageView> (Resource.Id.imageView1);
			
			// make it available in the gallery
			var mediaScanIntent =
				new Intent (Intent.ActionMediaScannerScanFile);
			var contentUri = Android.Net.Uri.FromFile (_file);
			mediaScanIntent.SetData (contentUri);
			this.SendBroadcast (mediaScanIntent);             
			
			// display in ImageView
			var bitmap = MediaStore.Images.Media.GetBitmap (ContentResolver, contentUri);
			imageView.SetImageBitmap (bitmap);   
			bitmap.Dispose ();
		}
	}
}

