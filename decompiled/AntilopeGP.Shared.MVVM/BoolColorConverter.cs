using System;
using System.Globalization;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AntilopeGP.Shared.MVVM
{
	public class BoolColorConverter : IMarkupExtension, IValueConverter
	{
		public Color ColorWhenTrue
		{
			get;
			set;
		}

		public Color ColorWhenFalse
		{
			get;
			set;
		}

		public object ProvideValue(IServiceProvider serviceProvider)
		{
			return this;
		}

		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return value.As<bool>() ? ColorWhenTrue : ColorWhenFalse;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotSupportedException();
		}
	}
}
