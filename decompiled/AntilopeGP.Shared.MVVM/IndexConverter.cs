using System;
using System.Globalization;
using Xamarin.Forms;

namespace AntilopeGP.Shared.MVVM
{
	public class IndexConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return value.As<int>() == System.Convert.ToInt32(parameter);
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotSupportedException();
		}
	}
}
