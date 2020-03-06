namespace AntilopeGP.Configuration
{
	public class AntilopeWS
	{
		public string GetLastUpdateUrl => "https://antilope-gp.ovh/Vehicules/LastUpdate";

		public string GetVehiculesUrl => "https://antilope-gp.ovh/Vehicules";

		public int UpdatePollInterval => 2000;
	}
}
