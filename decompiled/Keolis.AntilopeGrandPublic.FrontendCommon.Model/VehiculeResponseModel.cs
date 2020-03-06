using Keolis.AntilopeGrandPublic.Common.Model;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace Keolis.AntilopeGrandPublic.FrontendCommon.Model
{
	public class VehiculeResponseModel
	{
		public IEnumerable<Vehicule> Vehicules
		{
			get;
			set;
		}

		public int Total
		{
			get;
			set;
		}

		[JsonIgnore]
		public bool LimitExceeded => Total > Vehicules?.Count();
	}
}
