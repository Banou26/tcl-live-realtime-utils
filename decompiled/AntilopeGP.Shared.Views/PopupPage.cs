using System;
using System.CodeDom.Compiler;
using System.Reflection;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Xaml.Diagnostics;
using Xamarin.Forms.Xaml.Internals;

namespace AntilopeGP.Shared.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	[XamlFilePath("Views\\PopupPage.xaml")]
	public class PopupPage : FlexLayout
	{
		public PopupPage()
		{
			InitializeComponent();
		}

		protected override void OnBindingContextChanged()
		{
			base.OnBindingContextChanged();
		}

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private void InitializeComponent()
		{
			if (ResourceLoader.CanProvideContentFor(new ResourceLoader.ResourceLoadingQuery
			{
				AssemblyName = typeof(PopupPage).GetTypeInfo().Assembly.GetName(),
				ResourcePath = "Views/PopupPage.xaml",
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
			StaticResourceExtension staticResourceExtension = new StaticResourceExtension();
			BindingExtension bindingExtension = new BindingExtension();
			BindingExtension bindingExtension2 = new BindingExtension();
			Image image = new Image();
			BindingExtension bindingExtension3 = new BindingExtension();
			BindingExtension bindingExtension4 = new BindingExtension();
			Image image2 = new Image();
			BindingExtension bindingExtension5 = new BindingExtension();
			BindingExtension bindingExtension6 = new BindingExtension();
			StaticResourceExtension staticResourceExtension2 = new StaticResourceExtension();
			StaticResourceExtension staticResourceExtension3 = new StaticResourceExtension();
			Label label = new Label();
			BindingExtension bindingExtension7 = new BindingExtension();
			ImageButton imageButton = new ImageButton();
			FlexLayout flexLayout = new FlexLayout();
			StaticResourceExtension staticResourceExtension4 = new StaticResourceExtension();
			StaticResourceExtension staticResourceExtension5 = new StaticResourceExtension();
			Label label2 = new Label();
			BindingExtension bindingExtension8 = new BindingExtension();
			BindingExtension bindingExtension9 = new BindingExtension();
			StaticResourceExtension staticResourceExtension6 = new StaticResourceExtension();
			StaticResourceExtension staticResourceExtension7 = new StaticResourceExtension();
			Label label3 = new Label();
			FlexLayout flexLayout2 = new FlexLayout();
			PopupPage popupPage;
			NameScope nameScope = (NameScope)(NameScope.GetNameScope(popupPage = this) ?? new NameScope());
			NameScope.SetNameScope(popupPage, nameScope);
			popupPage.SetValue(FlexLayout.DirectionProperty, new FlexDirectionTypeConverter().ConvertFromInvariantString("Column"));
			popupPage.SetValue(FlexLayout.AlignItemsProperty, new FlexAlignItemsTypeConverter().ConvertFromInvariantString("Stretch"));
			popupPage.SetValue(FlexLayout.JustifyContentProperty, new FlexJustifyTypeConverter().ConvertFromInvariantString("Start"));
			staticResourceExtension.Key = "LightGrayColor";
			XamlServiceProvider xamlServiceProvider = new XamlServiceProvider();
			Type typeFromHandle = typeof(IProvideValueTarget);
			object[] array = new object[0 + 1];
			array[0] = popupPage;
			object service;
			xamlServiceProvider.Add(typeFromHandle, service = new SimpleValueTargetProvider(array, VisualElement.BackgroundColorProperty, nameScope));
			xamlServiceProvider.Add(typeof(IReferenceProvider), service);
			Type typeFromHandle2 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver xmlNamespaceResolver = new XmlNamespaceResolver();
			xmlNamespaceResolver.Add("", "http://xamarin.com/schemas/2014/forms");
			xmlNamespaceResolver.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			xamlServiceProvider.Add(typeFromHandle2, new XamlTypeResolver(xmlNamespaceResolver, typeof(PopupPage).GetTypeInfo().Assembly));
			xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(8, 13)));
			object obj = ((IMarkupExtension)staticResourceExtension).ProvideValue((IServiceProvider)xamlServiceProvider);
			popupPage.BackgroundColor = (Color)obj;
			VisualDiagnostics.RegisterSourceInfo(obj, new Uri("Views\\PopupPage.xaml", UriKind.RelativeOrAbsolute), 8, 13);
			flexLayout.SetValue(FlexLayout.DirectionProperty, new FlexDirectionTypeConverter().ConvertFromInvariantString("Row"));
			flexLayout.SetValue(FlexLayout.AlignItemsProperty, new FlexAlignItemsTypeConverter().ConvertFromInvariantString("Center"));
			flexLayout.SetValue(FlexLayout.JustifyContentProperty, new FlexJustifyTypeConverter().ConvertFromInvariantString("SpaceBetween"));
			flexLayout.SetValue(FlexLayout.BasisProperty, new FlexBasis.FlexBasisTypeConverter().ConvertFromInvariantString("70"));
			flexLayout.SetValue(FlexLayout.ShrinkProperty, 0f);
			flexLayout.SetValue(VisualElement.BackgroundColorProperty, Color.White);
			image.SetValue(VisualElement.HeightRequestProperty, 25.0);
			image.SetValue(Image.AspectProperty, Aspect.AspectFit);
			image.SetValue(View.MarginProperty, new Thickness(20.0, 0.0, 0.0, 0.0));
			bindingExtension.Path = "SelectedVehicule";
			BindingBase binding = ((IMarkupExtension<BindingBase>)bindingExtension).ProvideValue((IServiceProvider)null);
			image.SetBinding(BindableObject.BindingContextProperty, binding);
			bindingExtension2.Path = "ModeImagePath";
			BindingBase binding2 = ((IMarkupExtension<BindingBase>)bindingExtension2).ProvideValue((IServiceProvider)null);
			image.SetBinding(Image.SourceProperty, binding2);
			flexLayout.Children.Add(image);
			VisualDiagnostics.RegisterSourceInfo(image, new Uri("Views\\PopupPage.xaml", UriKind.RelativeOrAbsolute), 15, 10);
			image2.SetValue(VisualElement.HeightRequestProperty, 25.0);
			image2.SetValue(Image.AspectProperty, Aspect.AspectFit);
			image2.SetValue(View.MarginProperty, new Thickness(2.0, 0.0, 0.0, 0.0));
			bindingExtension3.Path = "SelectedVehicule";
			BindingBase binding3 = ((IMarkupExtension<BindingBase>)bindingExtension3).ProvideValue((IServiceProvider)null);
			image2.SetBinding(BindableObject.BindingContextProperty, binding3);
			bindingExtension4.Path = "LigneImagePath";
			BindingBase binding4 = ((IMarkupExtension<BindingBase>)bindingExtension4).ProvideValue((IServiceProvider)null);
			image2.SetBinding(Image.SourceProperty, binding4);
			flexLayout.Children.Add(image2);
			VisualDiagnostics.RegisterSourceInfo(image2, new Uri("Views\\PopupPage.xaml", UriKind.RelativeOrAbsolute), 20, 10);
			bindingExtension5.Path = "SelectedVehicule";
			BindingBase binding5 = ((IMarkupExtension<BindingBase>)bindingExtension5).ProvideValue((IServiceProvider)null);
			label.SetBinding(BindableObject.BindingContextProperty, binding5);
			bindingExtension6.Path = "Destination";
			BindingBase binding6 = ((IMarkupExtension<BindingBase>)bindingExtension6).ProvideValue((IServiceProvider)null);
			label.SetBinding(Label.TextProperty, binding6);
			staticResourceExtension2.Key = "DarkGrayColor";
			XamlServiceProvider xamlServiceProvider2 = new XamlServiceProvider();
			Type typeFromHandle3 = typeof(IProvideValueTarget);
			object[] array2 = new object[0 + 3];
			array2[0] = label;
			array2[1] = flexLayout;
			array2[2] = popupPage;
			object service2;
			xamlServiceProvider2.Add(typeFromHandle3, service2 = new SimpleValueTargetProvider(array2, Label.TextColorProperty, nameScope));
			xamlServiceProvider2.Add(typeof(IReferenceProvider), service2);
			Type typeFromHandle4 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver xmlNamespaceResolver2 = new XmlNamespaceResolver();
			xmlNamespaceResolver2.Add("", "http://xamarin.com/schemas/2014/forms");
			xmlNamespaceResolver2.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			xamlServiceProvider2.Add(typeFromHandle4, new XamlTypeResolver(xmlNamespaceResolver2, typeof(PopupPage).GetTypeInfo().Assembly));
			xamlServiceProvider2.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(27, 16)));
			object obj2 = ((IMarkupExtension)staticResourceExtension2).ProvideValue((IServiceProvider)xamlServiceProvider2);
			label.TextColor = (Color)obj2;
			VisualDiagnostics.RegisterSourceInfo(obj2, new Uri("Views\\PopupPage.xaml", UriKind.RelativeOrAbsolute), 27, 16);
			staticResourceExtension3.Key = "TCLRegular";
			XamlServiceProvider xamlServiceProvider3 = new XamlServiceProvider();
			Type typeFromHandle5 = typeof(IProvideValueTarget);
			object[] array3 = new object[0 + 3];
			array3[0] = label;
			array3[1] = flexLayout;
			array3[2] = popupPage;
			object service3;
			xamlServiceProvider3.Add(typeFromHandle5, service3 = new SimpleValueTargetProvider(array3, Label.FontFamilyProperty, nameScope));
			xamlServiceProvider3.Add(typeof(IReferenceProvider), service3);
			Type typeFromHandle6 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver xmlNamespaceResolver3 = new XmlNamespaceResolver();
			xmlNamespaceResolver3.Add("", "http://xamarin.com/schemas/2014/forms");
			xmlNamespaceResolver3.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			xamlServiceProvider3.Add(typeFromHandle6, new XamlTypeResolver(xmlNamespaceResolver3, typeof(PopupPage).GetTypeInfo().Assembly));
			xamlServiceProvider3.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(28, 16)));
			object target = label.FontFamily = (string)((IMarkupExtension)staticResourceExtension3).ProvideValue((IServiceProvider)xamlServiceProvider3);
			VisualDiagnostics.RegisterSourceInfo(target, new Uri("Views\\PopupPage.xaml", UriKind.RelativeOrAbsolute), 28, 16);
			BindableProperty fontSizeProperty = Label.FontSizeProperty;
			FontSizeConverter fontSizeConverter = new FontSizeConverter();
			XamlServiceProvider xamlServiceProvider4 = new XamlServiceProvider();
			Type typeFromHandle7 = typeof(IProvideValueTarget);
			object[] array4 = new object[0 + 3];
			array4[0] = label;
			array4[1] = flexLayout;
			array4[2] = popupPage;
			object service4;
			xamlServiceProvider4.Add(typeFromHandle7, service4 = new SimpleValueTargetProvider(array4, Label.FontSizeProperty, nameScope));
			xamlServiceProvider4.Add(typeof(IReferenceProvider), service4);
			Type typeFromHandle8 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver xmlNamespaceResolver4 = new XmlNamespaceResolver();
			xmlNamespaceResolver4.Add("", "http://xamarin.com/schemas/2014/forms");
			xmlNamespaceResolver4.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			xamlServiceProvider4.Add(typeFromHandle8, new XamlTypeResolver(xmlNamespaceResolver4, typeof(PopupPage).GetTypeInfo().Assembly));
			xamlServiceProvider4.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(29, 16)));
			label.SetValue(fontSizeProperty, ((IExtendedTypeConverter)fontSizeConverter).ConvertFromInvariantString("Default", (IServiceProvider)xamlServiceProvider4));
			label.SetValue(Label.LineBreakModeProperty, LineBreakMode.TailTruncation);
			label.SetValue(View.MarginProperty, new Thickness(5.0, 0.0, 0.0, 0.0));
			label.SetValue(FlexLayout.GrowProperty, 1f);
			flexLayout.Children.Add(label);
			VisualDiagnostics.RegisterSourceInfo(label, new Uri("Views\\PopupPage.xaml", UriKind.RelativeOrAbsolute), 25, 10);
			imageButton.SetValue(VisualElement.HeightRequestProperty, 20.0);
			imageButton.SetValue(View.MarginProperty, new Thickness(20.0, 0.0));
			imageButton.SetValue(ImageButton.AspectProperty, Aspect.AspectFit);
			imageButton.SetValue(ImageButton.SourceProperty, new ImageSourceConverter().ConvertFromInvariantString("close.png"));
			imageButton.SetValue(VisualElement.BackgroundColorProperty, Color.White);
			bindingExtension7.Path = "ClosePopupTapCommand";
			BindingBase binding7 = ((IMarkupExtension<BindingBase>)bindingExtension7).ProvideValue((IServiceProvider)null);
			imageButton.SetBinding(ImageButton.CommandProperty, binding7);
			flexLayout.Children.Add(imageButton);
			VisualDiagnostics.RegisterSourceInfo(imageButton, new Uri("Views\\PopupPage.xaml", UriKind.RelativeOrAbsolute), 33, 10);
			popupPage.Children.Add(flexLayout);
			VisualDiagnostics.RegisterSourceInfo(flexLayout, new Uri("Views\\PopupPage.xaml", UriKind.RelativeOrAbsolute), 9, 6);
			flexLayout2.SetValue(FlexLayout.DirectionProperty, new FlexDirectionTypeConverter().ConvertFromInvariantString("Column"));
			flexLayout2.SetValue(FlexLayout.AlignItemsProperty, new FlexAlignItemsTypeConverter().ConvertFromInvariantString("Start"));
			flexLayout2.SetValue(FlexLayout.JustifyContentProperty, new FlexJustifyTypeConverter().ConvertFromInvariantString("Start"));
			flexLayout2.SetValue(FlexLayout.GrowProperty, 1f);
			label2.SetValue(Label.TextProperty, "Prochain arrêt : ");
			staticResourceExtension4.Key = "DarkGrayColor";
			XamlServiceProvider xamlServiceProvider5 = new XamlServiceProvider();
			Type typeFromHandle9 = typeof(IProvideValueTarget);
			object[] array5 = new object[0 + 3];
			array5[0] = label2;
			array5[1] = flexLayout2;
			array5[2] = popupPage;
			object service5;
			xamlServiceProvider5.Add(typeFromHandle9, service5 = new SimpleValueTargetProvider(array5, Label.TextColorProperty, nameScope));
			xamlServiceProvider5.Add(typeof(IReferenceProvider), service5);
			Type typeFromHandle10 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver xmlNamespaceResolver5 = new XmlNamespaceResolver();
			xmlNamespaceResolver5.Add("", "http://xamarin.com/schemas/2014/forms");
			xmlNamespaceResolver5.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			xamlServiceProvider5.Add(typeFromHandle10, new XamlTypeResolver(xmlNamespaceResolver5, typeof(PopupPage).GetTypeInfo().Assembly));
			xamlServiceProvider5.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(45, 16)));
			object obj3 = ((IMarkupExtension)staticResourceExtension4).ProvideValue((IServiceProvider)xamlServiceProvider5);
			label2.TextColor = (Color)obj3;
			VisualDiagnostics.RegisterSourceInfo(obj3, new Uri("Views\\PopupPage.xaml", UriKind.RelativeOrAbsolute), 45, 16);
			staticResourceExtension5.Key = "TCLLight";
			XamlServiceProvider xamlServiceProvider6 = new XamlServiceProvider();
			Type typeFromHandle11 = typeof(IProvideValueTarget);
			object[] array6 = new object[0 + 3];
			array6[0] = label2;
			array6[1] = flexLayout2;
			array6[2] = popupPage;
			object service6;
			xamlServiceProvider6.Add(typeFromHandle11, service6 = new SimpleValueTargetProvider(array6, Label.FontFamilyProperty, nameScope));
			xamlServiceProvider6.Add(typeof(IReferenceProvider), service6);
			Type typeFromHandle12 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver xmlNamespaceResolver6 = new XmlNamespaceResolver();
			xmlNamespaceResolver6.Add("", "http://xamarin.com/schemas/2014/forms");
			xmlNamespaceResolver6.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			xamlServiceProvider6.Add(typeFromHandle12, new XamlTypeResolver(xmlNamespaceResolver6, typeof(PopupPage).GetTypeInfo().Assembly));
			xamlServiceProvider6.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(46, 16)));
			object target2 = label2.FontFamily = (string)((IMarkupExtension)staticResourceExtension5).ProvideValue((IServiceProvider)xamlServiceProvider6);
			VisualDiagnostics.RegisterSourceInfo(target2, new Uri("Views\\PopupPage.xaml", UriKind.RelativeOrAbsolute), 46, 16);
			BindableProperty fontSizeProperty2 = Label.FontSizeProperty;
			FontSizeConverter fontSizeConverter2 = new FontSizeConverter();
			XamlServiceProvider xamlServiceProvider7 = new XamlServiceProvider();
			Type typeFromHandle13 = typeof(IProvideValueTarget);
			object[] array7 = new object[0 + 3];
			array7[0] = label2;
			array7[1] = flexLayout2;
			array7[2] = popupPage;
			object service7;
			xamlServiceProvider7.Add(typeFromHandle13, service7 = new SimpleValueTargetProvider(array7, Label.FontSizeProperty, nameScope));
			xamlServiceProvider7.Add(typeof(IReferenceProvider), service7);
			Type typeFromHandle14 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver xmlNamespaceResolver7 = new XmlNamespaceResolver();
			xmlNamespaceResolver7.Add("", "http://xamarin.com/schemas/2014/forms");
			xmlNamespaceResolver7.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			xamlServiceProvider7.Add(typeFromHandle14, new XamlTypeResolver(xmlNamespaceResolver7, typeof(PopupPage).GetTypeInfo().Assembly));
			xamlServiceProvider7.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(47, 16)));
			label2.SetValue(fontSizeProperty2, ((IExtendedTypeConverter)fontSizeConverter2).ConvertFromInvariantString("Small", (IServiceProvider)xamlServiceProvider7));
			label2.SetValue(View.MarginProperty, new Thickness(20.0, 20.0, 0.0, 0.0));
			flexLayout2.Children.Add(label2);
			VisualDiagnostics.RegisterSourceInfo(label2, new Uri("Views\\PopupPage.xaml", UriKind.RelativeOrAbsolute), 44, 10);
			bindingExtension8.Path = "SelectedVehicule";
			BindingBase binding8 = ((IMarkupExtension<BindingBase>)bindingExtension8).ProvideValue((IServiceProvider)null);
			label3.SetBinding(BindableObject.BindingContextProperty, binding8);
			bindingExtension9.Path = "ProchainArret";
			BindingBase binding9 = ((IMarkupExtension<BindingBase>)bindingExtension9).ProvideValue((IServiceProvider)null);
			label3.SetBinding(Label.TextProperty, binding9);
			staticResourceExtension6.Key = "DarkGrayColor";
			XamlServiceProvider xamlServiceProvider8 = new XamlServiceProvider();
			Type typeFromHandle15 = typeof(IProvideValueTarget);
			object[] array8 = new object[0 + 3];
			array8[0] = label3;
			array8[1] = flexLayout2;
			array8[2] = popupPage;
			object service8;
			xamlServiceProvider8.Add(typeFromHandle15, service8 = new SimpleValueTargetProvider(array8, Label.TextColorProperty, nameScope));
			xamlServiceProvider8.Add(typeof(IReferenceProvider), service8);
			Type typeFromHandle16 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver xmlNamespaceResolver8 = new XmlNamespaceResolver();
			xmlNamespaceResolver8.Add("", "http://xamarin.com/schemas/2014/forms");
			xmlNamespaceResolver8.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			xamlServiceProvider8.Add(typeFromHandle16, new XamlTypeResolver(xmlNamespaceResolver8, typeof(PopupPage).GetTypeInfo().Assembly));
			xamlServiceProvider8.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(51, 16)));
			object obj4 = ((IMarkupExtension)staticResourceExtension6).ProvideValue((IServiceProvider)xamlServiceProvider8);
			label3.TextColor = (Color)obj4;
			VisualDiagnostics.RegisterSourceInfo(obj4, new Uri("Views\\PopupPage.xaml", UriKind.RelativeOrAbsolute), 51, 16);
			staticResourceExtension7.Key = "TCLRegular";
			XamlServiceProvider xamlServiceProvider9 = new XamlServiceProvider();
			Type typeFromHandle17 = typeof(IProvideValueTarget);
			object[] array9 = new object[0 + 3];
			array9[0] = label3;
			array9[1] = flexLayout2;
			array9[2] = popupPage;
			object service9;
			xamlServiceProvider9.Add(typeFromHandle17, service9 = new SimpleValueTargetProvider(array9, Label.FontFamilyProperty, nameScope));
			xamlServiceProvider9.Add(typeof(IReferenceProvider), service9);
			Type typeFromHandle18 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver xmlNamespaceResolver9 = new XmlNamespaceResolver();
			xmlNamespaceResolver9.Add("", "http://xamarin.com/schemas/2014/forms");
			xmlNamespaceResolver9.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			xamlServiceProvider9.Add(typeFromHandle18, new XamlTypeResolver(xmlNamespaceResolver9, typeof(PopupPage).GetTypeInfo().Assembly));
			xamlServiceProvider9.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(52, 16)));
			object target3 = label3.FontFamily = (string)((IMarkupExtension)staticResourceExtension7).ProvideValue((IServiceProvider)xamlServiceProvider9);
			VisualDiagnostics.RegisterSourceInfo(target3, new Uri("Views\\PopupPage.xaml", UriKind.RelativeOrAbsolute), 52, 16);
			BindableProperty fontSizeProperty3 = Label.FontSizeProperty;
			FontSizeConverter fontSizeConverter3 = new FontSizeConverter();
			XamlServiceProvider xamlServiceProvider10 = new XamlServiceProvider();
			Type typeFromHandle19 = typeof(IProvideValueTarget);
			object[] array10 = new object[0 + 3];
			array10[0] = label3;
			array10[1] = flexLayout2;
			array10[2] = popupPage;
			object service10;
			xamlServiceProvider10.Add(typeFromHandle19, service10 = new SimpleValueTargetProvider(array10, Label.FontSizeProperty, nameScope));
			xamlServiceProvider10.Add(typeof(IReferenceProvider), service10);
			Type typeFromHandle20 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver xmlNamespaceResolver10 = new XmlNamespaceResolver();
			xmlNamespaceResolver10.Add("", "http://xamarin.com/schemas/2014/forms");
			xmlNamespaceResolver10.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			xamlServiceProvider10.Add(typeFromHandle20, new XamlTypeResolver(xmlNamespaceResolver10, typeof(PopupPage).GetTypeInfo().Assembly));
			xamlServiceProvider10.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(53, 16)));
			label3.SetValue(fontSizeProperty3, ((IExtendedTypeConverter)fontSizeConverter3).ConvertFromInvariantString("Medium", (IServiceProvider)xamlServiceProvider10));
			label3.SetValue(View.MarginProperty, new Thickness(20.0, 0.0, 0.0, 0.0));
			label3.SetValue(Label.LineBreakModeProperty, LineBreakMode.TailTruncation);
			flexLayout2.Children.Add(label3);
			VisualDiagnostics.RegisterSourceInfo(label3, new Uri("Views\\PopupPage.xaml", UriKind.RelativeOrAbsolute), 49, 10);
			popupPage.Children.Add(flexLayout2);
			VisualDiagnostics.RegisterSourceInfo(flexLayout2, new Uri("Views\\PopupPage.xaml", UriKind.RelativeOrAbsolute), 40, 6);
			VisualDiagnostics.RegisterSourceInfo(popupPage, new Uri("Views\\PopupPage.xaml", UriKind.RelativeOrAbsolute), 2, 2);
		}

		private void __InitComponentRuntime()
		{
			this.LoadFromXaml(typeof(PopupPage));
		}
	}
}
