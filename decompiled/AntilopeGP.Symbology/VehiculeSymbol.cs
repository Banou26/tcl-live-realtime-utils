using System.IO;

namespace AntilopeGP.Symbology
{
	public class VehiculeSymbol
	{
		public Stream Stream
		{
			get;
			set;
		}

		public int Width
		{
			get;
			set;
		}

		public int Height
		{
			get;
			set;
		}

		public double YOffsetFromCenter
		{
			get;
			set;
		}
	}
}
