using System;
using System.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace SearchPartyXamarin.REST
{
	public class AksjonerService
	{

		public static List<Aksjon> GetAksjoner() 
		{
			string url = "http://searchparty.azurewebsites.net/api/aksjoner";
			var httpRequest = (HttpWebRequest)HttpWebRequest.Create (new Uri (url));

			var response = (HttpWebResponse) httpRequest.GetResponse();
			var stream = response.GetResponseStream();
			var jsonArray = (JsonArray)JsonArray.Load(stream);
			var aksjoner = (from obj in jsonArray
			                select new Aksjon { Tittel = obj["beskrivelse"], Beskrivelse = obj["beskrivelse_lang"] }).ToList();

			return aksjoner;

		}
	}
}

