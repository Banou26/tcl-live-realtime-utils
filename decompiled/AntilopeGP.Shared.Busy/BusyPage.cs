using Rg.Plugins.Popup.Pages;
using System;
using System.CodeDom.Compiler;
using System.Reflection;
using System.Runtime.CompilerServices;
using Telerik.XamarinForms.Primitives;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Xaml.Diagnostics;
using Xamarin.Forms.Xaml.Internals;

namespace AntilopeGP.Shared.Busy
{
	[XamlFilePath("Busy\\BusyPage.xaml")]
	public class BusyPage : PopupPage
	{
		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private PopupPage This;

		public string Message
		{
			[CompilerGenerated]
			get
			{
				return _003CMessage_003Ek__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!string.Equals(_003CMessage_003Ek__BackingField, value, StringComparison.Ordinal))
				{
					_003CMessage_003Ek__BackingField = value;
					OnPropertyChanged("Message");
				}
			}
		}

		public BusyPage()
		{
			InitializeComponent();
		}

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private void InitializeComponent()
		{
			if (ResourceLoader.CanProvideContentFor(new ResourceLoader.ResourceLoadingQuery
			{
				AssemblyName = typeof(BusyPage).GetTypeInfo().Assembly.GetName(),
				ResourcePath = "Busy/BusyPage.xaml",
				Instance = this
			}))
			{
				__InitComponentRuntime();
				return;
			}
			if (XamlLoader.XamlFileProvider != null && XamlLoader.XamlFileProvider(GetType()) != null)
			{
				__InitComponentRuntime();
				return;
			}
			ReferenceExtension referenceExtension = new ReferenceExtension();
			BindingExtension bindingExtension = new BindingExtension();
			Label label = new Label();
			RadBusyIndicator radBusyIndicator = new RadBusyIndicator();
			StackLayout stackLayout = new StackLayout();
			BusyPage busyPage;
			NameScope nameScope = (NameScope)(NameScope.GetNameScope(busyPage = this) ?? new NameScope());
			NameScope.SetNameScope(busyPage, nameScope);
			((INameScope)nameScope).RegisterName("This", (object)busyPage);
			if (busyPage.StyleId == null)
			{
				busyPage.StyleId = "This";
			}
			This = busyPage;
			busyPage.SetValue(VisualElement.BackgroundColorProperty, new Color(0.0, 0.0, 0.0, 0.501960813999176));
			busyPage.SetValue(PopupPage.CloseWhenBackgroundIsClickedProperty, false);
			stackLayout.SetValue(View.VerticalOptionsProperty, LayoutOptions.CenterAndExpand);
			stackLayout.SetValue(View.HorizontalOptionsProperty, LayoutOptions.CenterAndExpand);
			radBusyIndicator.SetValue(View.MarginProperty, new Thickness(10.0));
			radBusyIndicator.SetValue(RadBusyIndicator.AnimationContentHeightRequestProperty, 100.0);
			radBusyIndicator.SetValue(RadBusyIndicator.AnimationContentWidthRequestProperty, 100.0);
			radBusyIndicator.SetValue(RadBusyIndicator.AnimationTypeProperty, AnimationType.Animation8);
			radBusyIndicator.SetValue(RadBusyIndicator.AnimationContentColorProperty, Color.White);
			radBusyIndicator.SetValue(RadBusyIndicator.IsBusyProperty, true);
			referenceExtension.Name = "This";
			XamlServiceProvider xamlServiceProvider = new XamlServiceProvider();
			Type typeFromHandle = typeof(IProvideValueTarget);
			object[] array = new object[0 + 5];
			array[0] = bindingExtension;
			array[1] = label;
			array[2] = radBusyIndicator;
			array[3] = stackLayout;
			array[4] = busyPage;
			object service;
			xamlServiceProvider.Add(typeFromHandle, service = new SimpleValueTargetProvider(array, typeof(BindingExtension).GetRuntimeProperty("Source"), nameScope));
			xamlServiceProvider.Add(typeof(IReferenceProvider), service);
			Type typeFromHandle2 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver xmlNamespaceResolver = new XmlNamespaceResolver();
			xmlNamespaceResolver.Add("", "http://xamarin.com/schemas/2014/forms");
			xmlNamespaceResolver.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			xmlNamespaceResolver.Add("pages", "clr-namespace:Rg.Plugins.Popup.Pages;assembly=Rg.Plugins.Popup");
			xmlNamespaceResolver.Add("telerikPrimitives", "clr-namespace:Telerik.XamarinForms.Primitives;assembly=Telerik.XamarinForms.Primitives");
			xamlServiceProvider.Add(typeFromHandle2, new XamlTypeResolver(xmlNamespaceResolver, typeof(BusyPage).GetTypeInfo().Assembly));
			xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(24, 21)));
			object target = bindingExtension.Source = ((IMarkupExtension)referenceExtension).ProvideValue((IServiceProvider)xamlServiceProvider);
			VisualDiagnostics.RegisterSourceInfo(target, new Uri("Busy\\BusyPage.xaml", UriKind.RelativeOrAbsolute), 24, 21);
			bindingExtension.Path = "Message";
			BindingBase binding = ((IMarkupExtension<BindingBase>)bindingExtension).ProvideValue((IServiceProvider)null);
			label.SetBinding(Label.TextProperty, binding);
			label.SetValue(Label.TextColorProperty, Color.White);
			label.SetValue(Label.HorizontalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			BindableProperty fontSizeProperty = Label.FontSizeProperty;
			FontSizeConverter fontSizeConverter = new FontSizeConverter();
			XamlServiceProvider xamlServiceProvider2 = new XamlServiceProvider();
			Type typeFromHandle3 = typeof(IProvideValueTarget);
			object[] array2 = new object[0 + 4];
			array2[0] = label;
			array2[1] = radBusyIndicator;
			array2[2] = stackLayout;
			array2[3] = busyPage;
			object service2;
			xamlServiceProvider2.Add(typeFromHandle3, service2 = new SimpleValueTargetProvider(array2, Label.FontSizeProperty, nameScope));
			xamlServiceProvider2.Add(typeof(IReferenceProvider), service2);
			Type typeFromHandle4 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver xmlNamespaceResolver2 = new XmlNamespaceResolver();
			xmlNamespaceResolver2.Add("", "http://xamarin.com/schemas/2014/forms");
			xmlNamespaceResolver2.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			xmlNamespaceResolver2.Add("pages", "clr-namespace:Rg.Plugins.Popup.Pages;assembly=Rg.Plugins.Popup");
			xmlNamespaceResolver2.Add("telerikPrimitives", "clr-namespace:Telerik.XamarinForms.Primitives;assembly=Telerik.XamarinForms.Primitives");
			xamlServiceProvider2.Add(typeFromHandle4, new XamlTypeResolver(xmlNamespaceResolver2, typeof(BusyPage).GetTypeInfo().Assembly));
			xamlServiceProvider2.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(27, 21)));
			label.SetValue(fontSizeProperty, ((IExtendedTypeConverter)fontSizeConverter).ConvertFromInvariantString("Medium", (IServiceProvider)xamlServiceProvider2));
			radBusyIndicator.SetValue(RadBusyIndicator.BusyContentProperty, label);
			VisualDiagnostics.RegisterSourceInfo(label, new Uri("Busy\\BusyPage.xaml", UriKind.RelativeOrAbsolute), 23, 18);
			stackLayout.Children.Add(radBusyIndicator);
			VisualDiagnostics.RegisterSourceInfo(radBusyIndicator, new Uri("Busy\\BusyPage.xaml", UriKind.RelativeOrAbsolute), 14, 10);
			busyPage.SetValue(ContentPage.ContentProperty, stackLayout);
			VisualDiagnostics.RegisterSourceInfo(stackLayout, new Uri("Busy\\BusyPage.xaml", UriKind.RelativeOrAbsolute), 11, 6);
			VisualDiagnostics.RegisterSourceInfo(busyPage, new Uri("Busy\\BusyPage.xaml", UriKind.RelativeOrAbsolute), 2, 2);
		}

		private void __InitComponentRuntime()
		{
			this.LoadFromXaml(typeof(BusyPage));
			This = this.FindByName<PopupPage>("This");
		}
	}
}
