using Rg.Plugins.Popup.Animations;
using Rg.Plugins.Popup.Converters.TypeConverters;
using Rg.Plugins.Popup.Enums;
using Rg.Plugins.Popup.Pages;
using System;
using System.CodeDom.Compiler;
using System.Reflection;
using Telerik.XamarinForms.Primitives;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Xaml.Diagnostics;
using Xamarin.Forms.Xaml.Internals;

namespace AntilopeGP.Shared.Views
{
	[XamlFilePath("Views\\ModalPopupPage.xaml")]
	public class ModalPopupPage : Rg.Plugins.Popup.Pages.PopupPage
	{
		public ModalPopupPage()
		{
			InitializeComponent();
		}

		protected override bool OnBackButtonPressed()
		{
			return true;
		}

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private void InitializeComponent()
		{
			if (ResourceLoader.CanProvideContentFor(new ResourceLoader.ResourceLoadingQuery
			{
				AssemblyName = typeof(ModalPopupPage).GetTypeInfo().Assembly.GetName(),
				ResourcePath = "Views/ModalPopupPage.xaml",
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
			ScaleAnimation scaleAnimation = new ScaleAnimation();
			BindingExtension bindingExtension = new BindingExtension();
			TapGestureRecognizer tapGestureRecognizer = new TapGestureRecognizer();
			BindingExtension bindingExtension2 = new BindingExtension();
			StaticResourceExtension staticResourceExtension = new StaticResourceExtension();
			Label label = new Label();
			RadBorder radBorder = new RadBorder();
			StackLayout stackLayout = new StackLayout();
			ModalPopupPage modalPopupPage;
			NameScope nameScope = (NameScope)(NameScope.GetNameScope(modalPopupPage = this) ?? new NameScope());
			NameScope.SetNameScope(modalPopupPage, nameScope);
			modalPopupPage.SetValue(VisualElement.BackgroundColorProperty, Color.Transparent);
			scaleAnimation.PositionIn = MoveAnimationOptions.Center;
			scaleAnimation.PositionOut = MoveAnimationOptions.Center;
			scaleAnimation.ScaleIn = 0.5;
			scaleAnimation.ScaleOut = 0.5;
			scaleAnimation.DurationIn = (uint)new UintTypeConverter().ConvertFromInvariantString("400");
			scaleAnimation.DurationOut = (uint)new UintTypeConverter().ConvertFromInvariantString("300");
			scaleAnimation.EasingIn = (Easing)new EasingTypeConverter().ConvertFromInvariantString("SinOut");
			scaleAnimation.EasingOut = (Easing)new EasingTypeConverter().ConvertFromInvariantString("SinIn");
			scaleAnimation.HasBackgroundAnimation = true;
			modalPopupPage.SetValue(Rg.Plugins.Popup.Pages.PopupPage.AnimationProperty, scaleAnimation);
			VisualDiagnostics.RegisterSourceInfo(scaleAnimation, new Uri("Views\\ModalPopupPage.xaml", UriKind.RelativeOrAbsolute), 12, 10);
			stackLayout.SetValue(View.VerticalOptionsProperty, LayoutOptions.Center);
			stackLayout.SetValue(View.HorizontalOptionsProperty, LayoutOptions.Center);
			stackLayout.SetValue(Xamarin.Forms.Layout.PaddingProperty, new Thickness(20.0));
			bindingExtension.Path = "ContentTapCommand";
			BindingBase binding = ((IMarkupExtension<BindingBase>)bindingExtension).ProvideValue((IServiceProvider)null);
			tapGestureRecognizer.SetBinding(TapGestureRecognizer.CommandProperty, binding);
			stackLayout.GestureRecognizers.Add(tapGestureRecognizer);
			VisualDiagnostics.RegisterSourceInfo(tapGestureRecognizer, new Uri("Views\\ModalPopupPage.xaml", UriKind.RelativeOrAbsolute), 28, 14);
			radBorder.SetValue(RadBorder.BorderColorProperty, new Color(0.18823529779911041, 0.18823529779911041, 0.18431372940540314, 0.93333333730697632));
			radBorder.SetValue(VisualElement.BackgroundColorProperty, new Color(0.18823529779911041, 0.18823529779911041, 0.18431372940540314, 0.93333333730697632));
			radBorder.SetValue(RadBorder.BorderThicknessProperty, new Thickness(2.0));
			radBorder.SetValue(RadBorder.CornerRadiusProperty, new Thickness(10.0));
			radBorder.SetValue(VisualElement.WidthRequestProperty, 300.0);
			bindingExtension2.Path = "Text";
			BindingBase binding2 = ((IMarkupExtension<BindingBase>)bindingExtension2).ProvideValue((IServiceProvider)null);
			label.SetBinding(Label.TextProperty, binding2);
			label.SetValue(Label.TextColorProperty, Color.White);
			staticResourceExtension.Key = "TCLRegular";
			XamlServiceProvider xamlServiceProvider = new XamlServiceProvider();
			Type typeFromHandle = typeof(IProvideValueTarget);
			object[] array = new object[0 + 4];
			array[0] = label;
			array[1] = radBorder;
			array[2] = stackLayout;
			array[3] = modalPopupPage;
			object service;
			xamlServiceProvider.Add(typeFromHandle, service = new SimpleValueTargetProvider(array, Label.FontFamilyProperty, nameScope));
			xamlServiceProvider.Add(typeof(IReferenceProvider), service);
			Type typeFromHandle2 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver xmlNamespaceResolver = new XmlNamespaceResolver();
			xmlNamespaceResolver.Add("", "http://xamarin.com/schemas/2014/forms");
			xmlNamespaceResolver.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			xmlNamespaceResolver.Add("animations", "clr-namespace:Rg.Plugins.Popup.Animations;assembly=Rg.Plugins.Popup");
			xmlNamespaceResolver.Add("pages", "clr-namespace:Rg.Plugins.Popup.Pages;assembly=Rg.Plugins.Popup");
			xmlNamespaceResolver.Add("telerikPrimitives", "clr-namespace:Telerik.XamarinForms.Primitives;assembly=Telerik.XamarinForms.Primitives");
			xamlServiceProvider.Add(typeFromHandle2, new XamlTypeResolver(xmlNamespaceResolver, typeof(ModalPopupPage).GetTypeInfo().Assembly));
			xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(40, 17)));
			object target = label.FontFamily = (string)((IMarkupExtension)staticResourceExtension).ProvideValue((IServiceProvider)xamlServiceProvider);
			VisualDiagnostics.RegisterSourceInfo(target, new Uri("Views\\ModalPopupPage.xaml", UriKind.RelativeOrAbsolute), 40, 17);
			BindableProperty fontSizeProperty = Label.FontSizeProperty;
			FontSizeConverter fontSizeConverter = new FontSizeConverter();
			XamlServiceProvider xamlServiceProvider2 = new XamlServiceProvider();
			Type typeFromHandle3 = typeof(IProvideValueTarget);
			object[] array2 = new object[0 + 4];
			array2[0] = label;
			array2[1] = radBorder;
			array2[2] = stackLayout;
			array2[3] = modalPopupPage;
			object service2;
			xamlServiceProvider2.Add(typeFromHandle3, service2 = new SimpleValueTargetProvider(array2, Label.FontSizeProperty, nameScope));
			xamlServiceProvider2.Add(typeof(IReferenceProvider), service2);
			Type typeFromHandle4 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver xmlNamespaceResolver2 = new XmlNamespaceResolver();
			xmlNamespaceResolver2.Add("", "http://xamarin.com/schemas/2014/forms");
			xmlNamespaceResolver2.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			xmlNamespaceResolver2.Add("animations", "clr-namespace:Rg.Plugins.Popup.Animations;assembly=Rg.Plugins.Popup");
			xmlNamespaceResolver2.Add("pages", "clr-namespace:Rg.Plugins.Popup.Pages;assembly=Rg.Plugins.Popup");
			xmlNamespaceResolver2.Add("telerikPrimitives", "clr-namespace:Telerik.XamarinForms.Primitives;assembly=Telerik.XamarinForms.Primitives");
			xamlServiceProvider2.Add(typeFromHandle4, new XamlTypeResolver(xmlNamespaceResolver2, typeof(ModalPopupPage).GetTypeInfo().Assembly));
			xamlServiceProvider2.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(41, 17)));
			label.SetValue(fontSizeProperty, ((IExtendedTypeConverter)fontSizeConverter).ConvertFromInvariantString("Default", (IServiceProvider)xamlServiceProvider2));
			label.SetValue(View.HorizontalOptionsProperty, LayoutOptions.FillAndExpand);
			label.SetValue(View.VerticalOptionsProperty, LayoutOptions.FillAndExpand);
			label.SetValue(Label.HorizontalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			label.SetValue(Label.VerticalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			label.SetValue(View.MarginProperty, new Thickness(10.0));
			radBorder.SetValue(ContentView.ContentProperty, label);
			VisualDiagnostics.RegisterSourceInfo(label, new Uri("Views\\ModalPopupPage.xaml", UriKind.RelativeOrAbsolute), 37, 14);
			stackLayout.Children.Add(radBorder);
			VisualDiagnostics.RegisterSourceInfo(radBorder, new Uri("Views\\ModalPopupPage.xaml", UriKind.RelativeOrAbsolute), 31, 10);
			modalPopupPage.SetValue(ContentPage.ContentProperty, stackLayout);
			VisualDiagnostics.RegisterSourceInfo(stackLayout, new Uri("Views\\ModalPopupPage.xaml", UriKind.RelativeOrAbsolute), 23, 6);
			VisualDiagnostics.RegisterSourceInfo(modalPopupPage, new Uri("Views\\ModalPopupPage.xaml", UriKind.RelativeOrAbsolute), 2, 2);
		}

		private void __InitComponentRuntime()
		{
			this.LoadFromXaml(typeof(ModalPopupPage));
		}
	}
}
