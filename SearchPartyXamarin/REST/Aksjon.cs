using System;

namespace SearchPartyXamarin.REST
{
	public class Aksjon
	{
		public Aksjon ()
		{

		}

		public string Tittel { get; set; }
		public string Beskrivelse { get; set; }

		public override string ToString ()
		{
			return string.Format ("{0}:\n{1}", Tittel, Beskrivelse);
		}
	}
}

