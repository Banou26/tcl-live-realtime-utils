using System;
using System.Globalization;
using Xamarin.Forms;

namespace AntilopeGP.Shared.MVVM
{
	public class NinePlusConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (value.As<int>() <= 9)
			{
				return value.ToString();
			}
			return "9+";
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotSupportedException();
		}
	}
}
