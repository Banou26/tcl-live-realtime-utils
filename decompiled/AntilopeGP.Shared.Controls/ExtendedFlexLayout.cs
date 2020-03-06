using System.Collections;
using Xamarin.Forms;

namespace AntilopeGP.Shared.Controls
{
	public class ExtendedFlexLayout : FlexLayout
	{
		public static readonly BindableProperty ItemsSourceProperty = BindableProperty.Create("ItemsSource", typeof(IEnumerable), typeof(ExtendedFlexLayout), null, BindingMode.OneWay, null, OnItemsSourceChanged);

		public static readonly BindableProperty ItemTemplateProperty = BindableProperty.Create("ItemTemplate", typeof(DataTemplate), typeof(ExtendedFlexLayout));

		public IEnumerable ItemsSource
		{
			get
			{
				return (IEnumerable)GetValue(ItemsSourceProperty);
			}
			set
			{
				SetValue(ItemsSourceProperty, value);
			}
		}

		public DataTemplate ItemTemplate
		{
			get
			{
				return (DataTemplate)GetValue(ItemTemplateProperty);
			}
			set
			{
				SetValue(ItemTemplateProperty, value);
			}
		}

		private static void OnItemsSourceChanged(BindableObject bindable, object oldVal, object newVal)
		{
			IEnumerable enumerable = newVal as IEnumerable;
			ExtendedFlexLayout extendedFlexLayout = (ExtendedFlexLayout)bindable;
			extendedFlexLayout.Children.Clear();
			if (enumerable != null)
			{
				foreach (object item in enumerable)
				{
					extendedFlexLayout.Children.Add(extendedFlexLayout.CreateChildView(item));
				}
			}
		}

		private View CreateChildView(object item)
		{
			ItemTemplate.SetValue(BindableObject.BindingContextProperty, item);
			return (View)ItemTemplate.CreateContent();
		}
	}
}
