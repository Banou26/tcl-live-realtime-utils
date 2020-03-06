using System;

namespace AntilopeGP.Configuration
{
	public class Map
	{
		public Uri URL => new Uri("https://www.arcgis.com/home/item.html?id=c16a3fd0d0134c038bf8ab84e2080884");

		public double MinScale => 300000.0;

		public int VehiculeSymbolHeight => 80;

		public double VehiculesLayerMinScale => 200000.0;

		public string ArretsLayerId => "Arrets";

		public string LignesLayerId => "Lignes";

		public TimeSpan GraphicAnimationDuration => TimeSpan.FromSeconds(2.0);

		public double GraphicAnimationFPS => 30.0;

		public TimeSpan LiveDataTimeout => TimeSpan.FromSeconds(60.0);
	}
}
