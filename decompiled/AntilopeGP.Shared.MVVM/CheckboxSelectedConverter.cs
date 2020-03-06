using System;
using System.Globalization;
using Xamarin.Forms;

namespace AntilopeGP.Shared.MVVM
{
	public class CheckboxSelectedConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (!value.As<bool>())
			{
				return "Assets/Checkbox.svg";
			}
			return "Assets/CheckboxCheckedRed.svg";
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotSupportedException();
		}
	}
}
