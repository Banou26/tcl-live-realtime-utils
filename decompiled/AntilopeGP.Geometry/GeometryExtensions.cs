using Esri.ArcGISRuntime.Geometry;
using Keolis.AntilopeGrandPublic.FrontendCommon.Model;

namespace AntilopeGP.Geometry
{
	public static class GeometryExtensions
	{
		public static Extent ToExtent(this Envelope envelope)
		{
			return new Extent
			{
				Xmin = envelope.XMin,
				Ymin = envelope.YMin,
				Xmax = envelope.XMax,
				Ymax = envelope.YMax
			};
		}

		public static Envelope ToEnvelope(this Extent extent, SpatialReference spatialReference)
		{
			return new Envelope(extent.Xmin, extent.Ymin, extent.Xmax, extent.Ymax, spatialReference);
		}
	}
}
