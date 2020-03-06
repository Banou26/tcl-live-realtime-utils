using System.Collections.Generic;

namespace Keolis.AntilopeGrandPublic.FrontendCommon.Model
{
	public class VehiculeRequestModel
	{
		public IEnumerable<LigneSens> Lignes
		{
			get;
			set;
		}

		public Extent Extent
		{
			get;
			set;
		}
	}
}
