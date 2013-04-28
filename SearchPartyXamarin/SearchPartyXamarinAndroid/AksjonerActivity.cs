
using System;
using System.Collections.Generic;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using SearchPartyXamarin.REST;

namespace SearchPartyXamarinAndroid
{
	[Activity (Label = "AksjonerActivity")]			
	public class AksjonerActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView(Resource.Layout.AksjonActivity);

			// Create your application here
			var aksjoner = AksjonerService.GetAksjoner();
			ListView listView = (ListView) FindViewById(Resource.Id.aksjonsListe);

			ArrayAdapter adapter = new ArrayAdapter<Aksjon>(this, Resource.Layout.AksjonItemView, aksjoner);

			listView.SetAdapter(adapter);
		}
	}
}

