using Esri.ArcGISRuntime;
using System;
using System.Globalization;
using Xamarin.Forms;

namespace AntilopeGP.Shared.MVVM
{
	public class LoadStatusConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (parameter.As<string>() == "Loaded")
			{
				return value.As<LoadStatus>() == LoadStatus.Loaded;
			}
			return value.As<LoadStatus>() != LoadStatus.Loaded;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotSupportedException();
		}
	}
}
