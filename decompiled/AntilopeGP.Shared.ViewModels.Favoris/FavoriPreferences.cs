using Keolis.AntilopeGrandPublic.FrontendCommon.Model;
using System.Collections.Generic;

namespace AntilopeGP.Shared.ViewModels.Favoris
{
	public class FavoriPreferences
	{
		public string Name
		{
			get;
			set;
		}

		public Extent MapExtent
		{
			get;
			set;
		}

		public IEnumerable<LigneSens> Lignes
		{
			get;
			set;
		}
	}
}
