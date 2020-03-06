using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace AntilopeGP.Configuration
{
	public class Config
	{
		public DeviceInfo DeviceInfo
		{
			get;
			set;
		}

		public Map Map
		{
			get;
			set;
		}

		public AntilopeWS AntilopeWS
		{
			get;
			set;
		}

		public List<InfosLigne> Lignes
		{
			get;
			set;
		}

		public static Config GetCurrentConfig()
		{
			using (StreamReader streamReader = new StreamReader(typeof(Config).Assembly.GetManifestResourceStream("AntilopeGP.Shared.Configuration.Lignes.json")))
			{
				return new Config
				{
					DeviceInfo = new DeviceInfo(),
					Map = new Map(),
					AntilopeWS = new AntilopeWS(),
					Lignes = JsonConvert.DeserializeObject<List<InfosLigne>>(streamReader.ReadToEnd())
				};
			}
		}
	}
}
