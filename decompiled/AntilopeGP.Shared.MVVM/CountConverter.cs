using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Xamarin.Forms;

namespace AntilopeGP.Shared.MVVM
{
	public class CountConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			bool flag = false;
			if (value is IEnumerable<object>)
			{
				flag = value.As<IEnumerable<object>>().Any();
			}
			else if (value is int)
			{
				flag = (value.As<int>() > 0);
			}
			return (parameter.As<string>() == "TrueIfAny") ? flag : (!flag);
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotSupportedException();
		}
	}
}
