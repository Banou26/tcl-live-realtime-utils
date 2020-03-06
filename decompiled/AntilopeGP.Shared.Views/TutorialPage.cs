using AntilopeGP.Shared.Display;
using AntilopeGP.Shared.MVVM;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Reflection;
using Telerik.XamarinForms.Input;
using Telerik.XamarinForms.Primitives;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Xaml.Diagnostics;
using Xamarin.Forms.Xaml.Internals;

namespace AntilopeGP.Shared.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	[XamlFilePath("Views\\TutorialPage.xaml")]
	public class TutorialPage : ContentPage
	{
		private InsetsManager _insetsManager;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private ContentPage This;

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private RadSlideView slideView;

		public TutorialPage(InsetsManager insetsManager)
		{
			_insetsManager = insetsManager;
			_insetsManager.StartManagingInsets(this, forceUseSafeInsets: true);
			InitializeComponent();
		}

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private void InitializeComponent()
		{
			if (ResourceLoader.CanProvideContentFor(new ResourceLoader.ResourceLoadingQuery
			{
				AssemblyName = typeof(TutorialPage).GetTypeInfo().Assembly.GetName(),
				ResourcePath = "Views/TutorialPage.xaml",
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
			IndexConverter value = new IndexConverter();
			NegateBooleanConverter value2 = new NegateBooleanConverter();
			ResourceDictionary resourceDictionary = new ResourceDictionary();
			RowDefinition rowDefinition = new RowDefinition();
			RowDefinition rowDefinition2 = new RowDefinition();
			RowDefinition rowDefinition3 = new RowDefinition();
			StaticResourceExtension staticResourceExtension = new StaticResourceExtension();
			StaticResourceExtension staticResourceExtension2 = new StaticResourceExtension();
			Label label = new Label();
			StaticResourceExtension staticResourceExtension3 = new StaticResourceExtension();
			StaticResourceExtension staticResourceExtension4 = new StaticResourceExtension();
			Type typeFromHandle = typeof(ContentView);
			Image image = new Image();
			ContentView contentView = new ContentView();
			Image image2 = new Image();
			ContentView contentView2 = new ContentView();
			Image image3 = new Image();
			ContentView contentView3 = new ContentView();
			Image image4 = new Image();
			ContentView contentView4 = new ContentView();
			ArrayExtension arrayExtension;
			(arrayExtension = new ArrayExtension()).Type = typeFromHandle;
			VisualDiagnostics.RegisterSourceInfo(typeFromHandle, new Uri("Views\\TutorialPage.xaml", UriKind.RelativeOrAbsolute), 35, 26);
			contentView.SetValue(View.MarginProperty, new Thickness(30.0, 0.0));
			contentView.SetValue(View.VerticalOptionsProperty, LayoutOptions.StartAndExpand);
			image.SetValue(Image.AspectProperty, Aspect.AspectFit);
			image.SetValue(Image.SourceProperty, new ImageSourceConverter().ConvertFromInvariantString("tuto_prochainarret.png"));
			contentView.SetValue(ContentView.ContentProperty, image);
			VisualDiagnostics.RegisterSourceInfo(image, new Uri("Views\\TutorialPage.xaml", UriKind.RelativeOrAbsolute), 38, 26);
			arrayExtension.Items.Add(contentView);
			VisualDiagnostics.RegisterSourceInfo(contentView, new Uri("Views\\TutorialPage.xaml", UriKind.RelativeOrAbsolute), 36, 22);
			contentView2.SetValue(View.MarginProperty, new Thickness(30.0, 0.0));
			contentView2.SetValue(View.VerticalOptionsProperty, LayoutOptions.StartAndExpand);
			image2.SetValue(Image.AspectProperty, Aspect.AspectFit);
			image2.SetValue(Image.SourceProperty, new ImageSourceConverter().ConvertFromInvariantString("tuto_filtre.png"));
			contentView2.SetValue(ContentView.ContentProperty, image2);
			VisualDiagnostics.RegisterSourceInfo(image2, new Uri("Views\\TutorialPage.xaml", UriKind.RelativeOrAbsolute), 44, 26);
			arrayExtension.Items.Add(contentView2);
			VisualDiagnostics.RegisterSourceInfo(contentView2, new Uri("Views\\TutorialPage.xaml", UriKind.RelativeOrAbsolute), 42, 22);
			contentView3.SetValue(View.MarginProperty, new Thickness(30.0, 0.0));
			contentView3.SetValue(View.VerticalOptionsProperty, LayoutOptions.StartAndExpand);
			image3.SetValue(Image.AspectProperty, Aspect.AspectFit);
			image3.SetValue(Image.SourceProperty, new ImageSourceConverter().ConvertFromInvariantString("tuto_favoris.png"));
			contentView3.SetValue(ContentView.ContentProperty, image3);
			VisualDiagnostics.RegisterSourceInfo(image3, new Uri("Views\\TutorialPage.xaml", UriKind.RelativeOrAbsolute), 50, 26);
			arrayExtension.Items.Add(contentView3);
			VisualDiagnostics.RegisterSourceInfo(contentView3, new Uri("Views\\TutorialPage.xaml", UriKind.RelativeOrAbsolute), 48, 22);
			contentView4.SetValue(View.MarginProperty, new Thickness(30.0, 0.0));
			contentView4.SetValue(View.VerticalOptionsProperty, LayoutOptions.StartAndExpand);
			image4.SetValue(Image.AspectProperty, Aspect.AspectFit);
			image4.SetValue(Image.SourceProperty, new ImageSourceConverter().ConvertFromInvariantString("tuto_directions.png"));
			contentView4.SetValue(ContentView.ContentProperty, image4);
			VisualDiagnostics.RegisterSourceInfo(image4, new Uri("Views\\TutorialPage.xaml", UriKind.RelativeOrAbsolute), 56, 26);
			arrayExtension.Items.Add(contentView4);
			VisualDiagnostics.RegisterSourceInfo(contentView4, new Uri("Views\\TutorialPage.xaml", UriKind.RelativeOrAbsolute), 54, 22);
			ContentView[] array = new ContentView[4]
			{
				contentView,
				contentView2,
				contentView3,
				contentView4
			};
			RadSlideView radSlideView = new RadSlideView();
			StaticResourceExtension staticResourceExtension5 = new StaticResourceExtension();
			StaticResourceExtension staticResourceExtension6 = new StaticResourceExtension();
			StaticResourceExtension staticResourceExtension7 = new StaticResourceExtension();
			ReferenceExtension referenceExtension = new ReferenceExtension();
			BindingExtension bindingExtension = new BindingExtension();
			BindingExtension bindingExtension2 = new BindingExtension();
			Setter setter = new Setter();
			Setter setter2 = new Setter();
			StaticResourceExtension staticResourceExtension8 = new StaticResourceExtension();
			Setter setter3 = new Setter();
			DataTrigger dataTrigger = new DataTrigger(typeof(RadButton));
			RadButton radButton = new RadButton();
			Grid grid = new Grid();
			TutorialPage tutorialPage;
			NameScope nameScope = (NameScope)(NameScope.GetNameScope(tutorialPage = this) ?? new NameScope());
			NameScope.SetNameScope(tutorialPage, nameScope);
			((INameScope)nameScope).RegisterName("This", (object)tutorialPage);
			if (tutorialPage.StyleId == null)
			{
				tutorialPage.StyleId = "This";
			}
			((INameScope)nameScope).RegisterName("slideView", (object)radSlideView);
			if (radSlideView.StyleId == null)
			{
				radSlideView.StyleId = "slideView";
			}
			This = tutorialPage;
			slideView = radSlideView;
			tutorialPage.Resources = resourceDictionary;
			VisualDiagnostics.RegisterSourceInfo(resourceDictionary, new Uri("Views\\TutorialPage.xaml", UriKind.RelativeOrAbsolute), 10, 10);
			resourceDictionary.Add("indexConverter", value);
			resourceDictionary.Add("inverter", value2);
			tutorialPage.Resources = resourceDictionary;
			VisualDiagnostics.RegisterSourceInfo(resourceDictionary, new Uri("Views\\TutorialPage.xaml", UriKind.RelativeOrAbsolute), 10, 10);
			rowDefinition.SetValue(RowDefinition.HeightProperty, new GridLengthTypeConverter().ConvertFromInvariantString("50"));
			((DefinitionCollection<RowDefinition>)grid.GetValue(Grid.RowDefinitionsProperty)).Add(rowDefinition);
			rowDefinition2.SetValue(RowDefinition.HeightProperty, new GridLengthTypeConverter().ConvertFromInvariantString("*"));
			((DefinitionCollection<RowDefinition>)grid.GetValue(Grid.RowDefinitionsProperty)).Add(rowDefinition2);
			rowDefinition3.SetValue(RowDefinition.HeightProperty, new GridLengthTypeConverter().ConvertFromInvariantString("70"));
			((DefinitionCollection<RowDefinition>)grid.GetValue(Grid.RowDefinitionsProperty)).Add(rowDefinition3);
			label.SetValue(Label.TextProperty, "TUTORIEL");
			staticResourceExtension.Key = "DarkGrayColor";
			XamlServiceProvider xamlServiceProvider = new XamlServiceProvider();
			Type typeFromHandle2 = typeof(IProvideValueTarget);
			object[] array2 = new object[0 + 3];
			array2[0] = label;
			array2[1] = grid;
			array2[2] = tutorialPage;
			object service;
			xamlServiceProvider.Add(typeFromHandle2, service = new SimpleValueTargetProvider(array2, Label.TextColorProperty, nameScope));
			xamlServiceProvider.Add(typeof(IReferenceProvider), service);
			Type typeFromHandle3 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver xmlNamespaceResolver = new XmlNamespaceResolver();
			xmlNamespaceResolver.Add("", "http://xamarin.com/schemas/2014/forms");
			xmlNamespaceResolver.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			xmlNamespaceResolver.Add("mvvm", "clr-namespace:AntilopeGP.Shared.MVVM");
			xmlNamespaceResolver.Add("telerikPrimitives", "clr-namespace:Telerik.XamarinForms.Primitives;assembly=Telerik.XamarinForms.Primitives");
			xmlNamespaceResolver.Add("telerikInput", "clr-namespace:Telerik.XamarinForms.Input;assembly=Telerik.XamarinForms.Input");
			xamlServiceProvider.Add(typeFromHandle3, new XamlTypeResolver(xmlNamespaceResolver, typeof(TutorialPage).GetTypeInfo().Assembly));
			xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(22, 16)));
			object obj = ((IMarkupExtension)staticResourceExtension).ProvideValue((IServiceProvider)xamlServiceProvider);
			label.TextColor = (Color)obj;
			VisualDiagnostics.RegisterSourceInfo(obj, new Uri("Views\\TutorialPage.xaml", UriKind.RelativeOrAbsolute), 22, 16);
			staticResourceExtension2.Key = "TCLBold";
			XamlServiceProvider xamlServiceProvider2 = new XamlServiceProvider();
			Type typeFromHandle4 = typeof(IProvideValueTarget);
			object[] array3 = new object[0 + 3];
			array3[0] = label;
			array3[1] = grid;
			array3[2] = tutorialPage;
			object service2;
			xamlServiceProvider2.Add(typeFromHandle4, service2 = new SimpleValueTargetProvider(array3, Label.FontFamilyProperty, nameScope));
			xamlServiceProvider2.Add(typeof(IReferenceProvider), service2);
			Type typeFromHandle5 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver xmlNamespaceResolver2 = new XmlNamespaceResolver();
			xmlNamespaceResolver2.Add("", "http://xamarin.com/schemas/2014/forms");
			xmlNamespaceResolver2.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			xmlNamespaceResolver2.Add("mvvm", "clr-namespace:AntilopeGP.Shared.MVVM");
			xmlNamespaceResolver2.Add("telerikPrimitives", "clr-namespace:Telerik.XamarinForms.Primitives;assembly=Telerik.XamarinForms.Primitives");
			xmlNamespaceResolver2.Add("telerikInput", "clr-namespace:Telerik.XamarinForms.Input;assembly=Telerik.XamarinForms.Input");
			xamlServiceProvider2.Add(typeFromHandle5, new XamlTypeResolver(xmlNamespaceResolver2, typeof(TutorialPage).GetTypeInfo().Assembly));
			xamlServiceProvider2.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(23, 16)));
			object target = label.FontFamily = (string)((IMarkupExtension)staticResourceExtension2).ProvideValue((IServiceProvider)xamlServiceProvider2);
			VisualDiagnostics.RegisterSourceInfo(target, new Uri("Views\\TutorialPage.xaml", UriKind.RelativeOrAbsolute), 23, 16);
			BindableProperty fontSizeProperty = Label.FontSizeProperty;
			FontSizeConverter fontSizeConverter = new FontSizeConverter();
			XamlServiceProvider xamlServiceProvider3 = new XamlServiceProvider();
			Type typeFromHandle6 = typeof(IProvideValueTarget);
			object[] array4 = new object[0 + 3];
			array4[0] = label;
			array4[1] = grid;
			array4[2] = tutorialPage;
			object service3;
			xamlServiceProvider3.Add(typeFromHandle6, service3 = new SimpleValueTargetProvider(array4, Label.FontSizeProperty, nameScope));
			xamlServiceProvider3.Add(typeof(IReferenceProvider), service3);
			Type typeFromHandle7 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver xmlNamespaceResolver3 = new XmlNamespaceResolver();
			xmlNamespaceResolver3.Add("", "http://xamarin.com/schemas/2014/forms");
			xmlNamespaceResolver3.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			xmlNamespaceResolver3.Add("mvvm", "clr-namespace:AntilopeGP.Shared.MVVM");
			xmlNamespaceResolver3.Add("telerikPrimitives", "clr-namespace:Telerik.XamarinForms.Primitives;assembly=Telerik.XamarinForms.Primitives");
			xmlNamespaceResolver3.Add("telerikInput", "clr-namespace:Telerik.XamarinForms.Input;assembly=Telerik.XamarinForms.Input");
			xamlServiceProvider3.Add(typeFromHandle7, new XamlTypeResolver(xmlNamespaceResolver3, typeof(TutorialPage).GetTypeInfo().Assembly));
			xamlServiceProvider3.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(24, 16)));
			label.SetValue(fontSizeProperty, ((IExtendedTypeConverter)fontSizeConverter).ConvertFromInvariantString("Large", (IServiceProvider)xamlServiceProvider3));
			label.SetValue(Label.HorizontalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			label.SetValue(Label.VerticalTextAlignmentProperty, new TextAlignmentConverter().ConvertFromInvariantString("Center"));
			grid.Children.Add(label);
			VisualDiagnostics.RegisterSourceInfo(label, new Uri("Views\\TutorialPage.xaml", UriKind.RelativeOrAbsolute), 21, 10);
			radSlideView.SetValue(Grid.RowProperty, 1);
			radSlideView.SetValue(View.MarginProperty, new Thickness(10.0, 0.0));
			radSlideView.SetValue(RadSlideView.HorizontalContentOptionsProperty, LayoutOptions.CenterAndExpand);
			radSlideView.SetValue(RadSlideView.VerticalContentOptionsProperty, LayoutOptions.StartAndExpand);
			staticResourceExtension3.Key = "DarkGrayColor";
			XamlServiceProvider xamlServiceProvider4 = new XamlServiceProvider();
			Type typeFromHandle8 = typeof(IProvideValueTarget);
			object[] array5 = new object[0 + 3];
			array5[0] = radSlideView;
			array5[1] = grid;
			array5[2] = tutorialPage;
			object service4;
			xamlServiceProvider4.Add(typeFromHandle8, service4 = new SimpleValueTargetProvider(array5, RadSlideView.IndicatorColorProperty, nameScope));
			xamlServiceProvider4.Add(typeof(IReferenceProvider), service4);
			Type typeFromHandle9 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver xmlNamespaceResolver4 = new XmlNamespaceResolver();
			xmlNamespaceResolver4.Add("", "http://xamarin.com/schemas/2014/forms");
			xmlNamespaceResolver4.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			xmlNamespaceResolver4.Add("mvvm", "clr-namespace:AntilopeGP.Shared.MVVM");
			xmlNamespaceResolver4.Add("telerikPrimitives", "clr-namespace:Telerik.XamarinForms.Primitives;assembly=Telerik.XamarinForms.Primitives");
			xmlNamespaceResolver4.Add("telerikInput", "clr-namespace:Telerik.XamarinForms.Input;assembly=Telerik.XamarinForms.Input");
			xamlServiceProvider4.Add(typeFromHandle9, new XamlTypeResolver(xmlNamespaceResolver4, typeof(TutorialPage).GetTypeInfo().Assembly));
			xamlServiceProvider4.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(32, 41)));
			object obj2 = ((IMarkupExtension)staticResourceExtension3).ProvideValue((IServiceProvider)xamlServiceProvider4);
			radSlideView.IndicatorColor = (Color)obj2;
			VisualDiagnostics.RegisterSourceInfo(obj2, new Uri("Views\\TutorialPage.xaml", UriKind.RelativeOrAbsolute), 32, 41);
			staticResourceExtension4.Key = "TCLRed";
			XamlServiceProvider xamlServiceProvider5 = new XamlServiceProvider();
			Type typeFromHandle10 = typeof(IProvideValueTarget);
			object[] array6 = new object[0 + 3];
			array6[0] = radSlideView;
			array6[1] = grid;
			array6[2] = tutorialPage;
			object service5;
			xamlServiceProvider5.Add(typeFromHandle10, service5 = new SimpleValueTargetProvider(array6, RadSlideView.SelectedIndicatorColorProperty, nameScope));
			xamlServiceProvider5.Add(typeof(IReferenceProvider), service5);
			Type typeFromHandle11 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver xmlNamespaceResolver5 = new XmlNamespaceResolver();
			xmlNamespaceResolver5.Add("", "http://xamarin.com/schemas/2014/forms");
			xmlNamespaceResolver5.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			xmlNamespaceResolver5.Add("mvvm", "clr-namespace:AntilopeGP.Shared.MVVM");
			xmlNamespaceResolver5.Add("telerikPrimitives", "clr-namespace:Telerik.XamarinForms.Primitives;assembly=Telerik.XamarinForms.Primitives");
			xmlNamespaceResolver5.Add("telerikInput", "clr-namespace:Telerik.XamarinForms.Input;assembly=Telerik.XamarinForms.Input");
			xamlServiceProvider5.Add(typeFromHandle11, new XamlTypeResolver(xmlNamespaceResolver5, typeof(TutorialPage).GetTypeInfo().Assembly));
			xamlServiceProvider5.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(33, 41)));
			object obj3 = ((IMarkupExtension)staticResourceExtension4).ProvideValue((IServiceProvider)xamlServiceProvider5);
			radSlideView.SelectedIndicatorColor = (Color)obj3;
			VisualDiagnostics.RegisterSourceInfo(obj3, new Uri("Views\\TutorialPage.xaml", UriKind.RelativeOrAbsolute), 33, 41);
			radSlideView.SetValue(RadSlideView.ItemsSourceProperty, array);
			VisualDiagnostics.RegisterSourceInfo(array, new Uri("Views\\TutorialPage.xaml", UriKind.RelativeOrAbsolute), 35, 18);
			grid.Children.Add(radSlideView);
			VisualDiagnostics.RegisterSourceInfo(radSlideView, new Uri("Views\\TutorialPage.xaml", UriKind.RelativeOrAbsolute), 27, 10);
			radButton.SetValue(Grid.RowProperty, 2);
			radButton.SetValue(View.VerticalOptionsProperty, LayoutOptions.Center);
			radButton.SetValue(View.HorizontalOptionsProperty, LayoutOptions.Center);
			radButton.SetValue(VisualElement.HeightRequestProperty, 50.0);
			radButton.SetValue(Button.PaddingProperty, new Thickness(15.0, 0.0));
			radButton.SetValue(Button.BorderRadiusProperty, 25);
			radButton.SetValue(Button.TextProperty, "J'ai compris, fermer le tutoriel");
			staticResourceExtension5.Key = "MediumGrayColor";
			XamlServiceProvider xamlServiceProvider6 = new XamlServiceProvider();
			Type typeFromHandle12 = typeof(IProvideValueTarget);
			object[] array7 = new object[0 + 3];
			array7[0] = radButton;
			array7[1] = grid;
			array7[2] = tutorialPage;
			object service6;
			xamlServiceProvider6.Add(typeFromHandle12, service6 = new SimpleValueTargetProvider(array7, Button.TextColorProperty, nameScope));
			xamlServiceProvider6.Add(typeof(IReferenceProvider), service6);
			Type typeFromHandle13 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver xmlNamespaceResolver6 = new XmlNamespaceResolver();
			xmlNamespaceResolver6.Add("", "http://xamarin.com/schemas/2014/forms");
			xmlNamespaceResolver6.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			xmlNamespaceResolver6.Add("mvvm", "clr-namespace:AntilopeGP.Shared.MVVM");
			xmlNamespaceResolver6.Add("telerikPrimitives", "clr-namespace:Telerik.XamarinForms.Primitives;assembly=Telerik.XamarinForms.Primitives");
			xmlNamespaceResolver6.Add("telerikInput", "clr-namespace:Telerik.XamarinForms.Input;assembly=Telerik.XamarinForms.Input");
			xamlServiceProvider6.Add(typeFromHandle13, new XamlTypeResolver(xmlNamespaceResolver6, typeof(TutorialPage).GetTypeInfo().Assembly));
			xamlServiceProvider6.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(70, 33)));
			object obj4 = ((IMarkupExtension)staticResourceExtension5).ProvideValue((IServiceProvider)xamlServiceProvider6);
			radButton.TextColor = (Color)obj4;
			VisualDiagnostics.RegisterSourceInfo(obj4, new Uri("Views\\TutorialPage.xaml", UriKind.RelativeOrAbsolute), 70, 33);
			staticResourceExtension6.Key = "TCLRegular";
			XamlServiceProvider xamlServiceProvider7 = new XamlServiceProvider();
			Type typeFromHandle14 = typeof(IProvideValueTarget);
			object[] array8 = new object[0 + 3];
			array8[0] = radButton;
			array8[1] = grid;
			array8[2] = tutorialPage;
			object service7;
			xamlServiceProvider7.Add(typeFromHandle14, service7 = new SimpleValueTargetProvider(array8, Button.FontFamilyProperty, nameScope));
			xamlServiceProvider7.Add(typeof(IReferenceProvider), service7);
			Type typeFromHandle15 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver xmlNamespaceResolver7 = new XmlNamespaceResolver();
			xmlNamespaceResolver7.Add("", "http://xamarin.com/schemas/2014/forms");
			xmlNamespaceResolver7.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			xmlNamespaceResolver7.Add("mvvm", "clr-namespace:AntilopeGP.Shared.MVVM");
			xmlNamespaceResolver7.Add("telerikPrimitives", "clr-namespace:Telerik.XamarinForms.Primitives;assembly=Telerik.XamarinForms.Primitives");
			xmlNamespaceResolver7.Add("telerikInput", "clr-namespace:Telerik.XamarinForms.Input;assembly=Telerik.XamarinForms.Input");
			xamlServiceProvider7.Add(typeFromHandle15, new XamlTypeResolver(xmlNamespaceResolver7, typeof(TutorialPage).GetTypeInfo().Assembly));
			xamlServiceProvider7.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(71, 33)));
			object target2 = radButton.FontFamily = (string)((IMarkupExtension)staticResourceExtension6).ProvideValue((IServiceProvider)xamlServiceProvider7);
			VisualDiagnostics.RegisterSourceInfo(target2, new Uri("Views\\TutorialPage.xaml", UriKind.RelativeOrAbsolute), 71, 33);
			BindableProperty fontSizeProperty2 = Button.FontSizeProperty;
			FontSizeConverter fontSizeConverter2 = new FontSizeConverter();
			XamlServiceProvider xamlServiceProvider8 = new XamlServiceProvider();
			Type typeFromHandle16 = typeof(IProvideValueTarget);
			object[] array9 = new object[0 + 3];
			array9[0] = radButton;
			array9[1] = grid;
			array9[2] = tutorialPage;
			object service8;
			xamlServiceProvider8.Add(typeFromHandle16, service8 = new SimpleValueTargetProvider(array9, Button.FontSizeProperty, nameScope));
			xamlServiceProvider8.Add(typeof(IReferenceProvider), service8);
			Type typeFromHandle17 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver xmlNamespaceResolver8 = new XmlNamespaceResolver();
			xmlNamespaceResolver8.Add("", "http://xamarin.com/schemas/2014/forms");
			xmlNamespaceResolver8.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			xmlNamespaceResolver8.Add("mvvm", "clr-namespace:AntilopeGP.Shared.MVVM");
			xmlNamespaceResolver8.Add("telerikPrimitives", "clr-namespace:Telerik.XamarinForms.Primitives;assembly=Telerik.XamarinForms.Primitives");
			xmlNamespaceResolver8.Add("telerikInput", "clr-namespace:Telerik.XamarinForms.Input;assembly=Telerik.XamarinForms.Input");
			xamlServiceProvider8.Add(typeFromHandle17, new XamlTypeResolver(xmlNamespaceResolver8, typeof(TutorialPage).GetTypeInfo().Assembly));
			xamlServiceProvider8.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(72, 33)));
			radButton.SetValue(fontSizeProperty2, ((IExtendedTypeConverter)fontSizeConverter2).ConvertFromInvariantString("Medium", (IServiceProvider)xamlServiceProvider8));
			staticResourceExtension7.Key = "LightGrayColor";
			XamlServiceProvider xamlServiceProvider9 = new XamlServiceProvider();
			Type typeFromHandle18 = typeof(IProvideValueTarget);
			object[] array10 = new object[0 + 3];
			array10[0] = radButton;
			array10[1] = grid;
			array10[2] = tutorialPage;
			object service9;
			xamlServiceProvider9.Add(typeFromHandle18, service9 = new SimpleValueTargetProvider(array10, VisualElement.BackgroundColorProperty, nameScope));
			xamlServiceProvider9.Add(typeof(IReferenceProvider), service9);
			Type typeFromHandle19 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver xmlNamespaceResolver9 = new XmlNamespaceResolver();
			xmlNamespaceResolver9.Add("", "http://xamarin.com/schemas/2014/forms");
			xmlNamespaceResolver9.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			xmlNamespaceResolver9.Add("mvvm", "clr-namespace:AntilopeGP.Shared.MVVM");
			xmlNamespaceResolver9.Add("telerikPrimitives", "clr-namespace:Telerik.XamarinForms.Primitives;assembly=Telerik.XamarinForms.Primitives");
			xmlNamespaceResolver9.Add("telerikInput", "clr-namespace:Telerik.XamarinForms.Input;assembly=Telerik.XamarinForms.Input");
			xamlServiceProvider9.Add(typeFromHandle19, new XamlTypeResolver(xmlNamespaceResolver9, typeof(TutorialPage).GetTypeInfo().Assembly));
			xamlServiceProvider9.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(73, 33)));
			object obj5 = ((IMarkupExtension)staticResourceExtension7).ProvideValue((IServiceProvider)xamlServiceProvider9);
			radButton.BackgroundColor = (Color)obj5;
			VisualDiagnostics.RegisterSourceInfo(obj5, new Uri("Views\\TutorialPage.xaml", UriKind.RelativeOrAbsolute), 73, 33);
			referenceExtension.Name = "slideView";
			XamlServiceProvider xamlServiceProvider10 = new XamlServiceProvider();
			Type typeFromHandle20 = typeof(IProvideValueTarget);
			object[] array11 = new object[0 + 5];
			array11[0] = bindingExtension;
			array11[1] = dataTrigger;
			array11[2] = radButton;
			array11[3] = grid;
			array11[4] = tutorialPage;
			object service10;
			xamlServiceProvider10.Add(typeFromHandle20, service10 = new SimpleValueTargetProvider(array11, typeof(BindingExtension).GetRuntimeProperty("Source"), nameScope));
			xamlServiceProvider10.Add(typeof(IReferenceProvider), service10);
			Type typeFromHandle21 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver xmlNamespaceResolver10 = new XmlNamespaceResolver();
			xmlNamespaceResolver10.Add("", "http://xamarin.com/schemas/2014/forms");
			xmlNamespaceResolver10.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			xmlNamespaceResolver10.Add("mvvm", "clr-namespace:AntilopeGP.Shared.MVVM");
			xmlNamespaceResolver10.Add("telerikPrimitives", "clr-namespace:Telerik.XamarinForms.Primitives;assembly=Telerik.XamarinForms.Primitives");
			xmlNamespaceResolver10.Add("telerikInput", "clr-namespace:Telerik.XamarinForms.Input;assembly=Telerik.XamarinForms.Input");
			xamlServiceProvider10.Add(typeFromHandle21, new XamlTypeResolver(xmlNamespaceResolver10, typeof(TutorialPage).GetTypeInfo().Assembly));
			xamlServiceProvider10.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(76, 30)));
			object target3 = bindingExtension.Source = ((IMarkupExtension)referenceExtension).ProvideValue((IServiceProvider)xamlServiceProvider10);
			VisualDiagnostics.RegisterSourceInfo(target3, new Uri("Views\\TutorialPage.xaml", UriKind.RelativeOrAbsolute), 76, 30);
			bindingExtension.Path = "SelectedIndex";
			BindingBase target4 = dataTrigger.Binding = ((IMarkupExtension<BindingBase>)bindingExtension).ProvideValue((IServiceProvider)null);
			VisualDiagnostics.RegisterSourceInfo(target4, new Uri("Views\\TutorialPage.xaml", UriKind.RelativeOrAbsolute), 76, 30);
			dataTrigger.Value = "3";
			setter.Property = Button.CommandProperty;
			bindingExtension2.Path = "AcceptTapCommand";
			BindingBase target5 = (BindingBase)(setter.Value = ((IMarkupExtension<BindingBase>)bindingExtension2).ProvideValue((IServiceProvider)null));
			VisualDiagnostics.RegisterSourceInfo(target5, new Uri("Views\\TutorialPage.xaml", UriKind.RelativeOrAbsolute), 79, 29);
			dataTrigger.Setters.Add(setter);
			VisualDiagnostics.RegisterSourceInfo(setter, new Uri("Views\\TutorialPage.xaml", UriKind.RelativeOrAbsolute), 78, 22);
			setter2.Property = Button.TextColorProperty;
			setter2.Value = "White";
			setter2.Value = Color.White;
			dataTrigger.Setters.Add(setter2);
			VisualDiagnostics.RegisterSourceInfo(setter2, new Uri("Views\\TutorialPage.xaml", UriKind.RelativeOrAbsolute), 80, 22);
			setter3.Property = VisualElement.BackgroundColorProperty;
			staticResourceExtension8.Key = "TCLRed";
			XamlServiceProvider xamlServiceProvider11 = new XamlServiceProvider();
			Type typeFromHandle22 = typeof(IProvideValueTarget);
			object[] array12 = new object[0 + 5];
			array12[0] = setter3;
			array12[1] = dataTrigger;
			array12[2] = radButton;
			array12[3] = grid;
			array12[4] = tutorialPage;
			object service11;
			xamlServiceProvider11.Add(typeFromHandle22, service11 = new SimpleValueTargetProvider(array12, typeof(Setter).GetRuntimeProperty("Value"), nameScope));
			xamlServiceProvider11.Add(typeof(IReferenceProvider), service11);
			Type typeFromHandle23 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver xmlNamespaceResolver11 = new XmlNamespaceResolver();
			xmlNamespaceResolver11.Add("", "http://xamarin.com/schemas/2014/forms");
			xmlNamespaceResolver11.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			xmlNamespaceResolver11.Add("mvvm", "clr-namespace:AntilopeGP.Shared.MVVM");
			xmlNamespaceResolver11.Add("telerikPrimitives", "clr-namespace:Telerik.XamarinForms.Primitives;assembly=Telerik.XamarinForms.Primitives");
			xmlNamespaceResolver11.Add("telerikInput", "clr-namespace:Telerik.XamarinForms.Input;assembly=Telerik.XamarinForms.Input");
			xamlServiceProvider11.Add(typeFromHandle23, new XamlTypeResolver(xmlNamespaceResolver11, typeof(TutorialPage).GetTypeInfo().Assembly));
			xamlServiceProvider11.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(83, 29)));
			object target6 = setter3.Value = ((IMarkupExtension)staticResourceExtension8).ProvideValue((IServiceProvider)xamlServiceProvider11);
			VisualDiagnostics.RegisterSourceInfo(target6, new Uri("Views\\TutorialPage.xaml", UriKind.RelativeOrAbsolute), 83, 29);
			dataTrigger.Setters.Add(setter3);
			VisualDiagnostics.RegisterSourceInfo(setter3, new Uri("Views\\TutorialPage.xaml", UriKind.RelativeOrAbsolute), 82, 22);
			((ICollection<TriggerBase>)radButton.GetValue(VisualElement.TriggersProperty)).Add((TriggerBase)dataTrigger);
			VisualDiagnostics.RegisterSourceInfo(dataTrigger, new Uri("Views\\TutorialPage.xaml", UriKind.RelativeOrAbsolute), 75, 18);
			grid.Children.Add(radButton);
			VisualDiagnostics.RegisterSourceInfo(radButton, new Uri("Views\\TutorialPage.xaml", UriKind.RelativeOrAbsolute), 63, 10);
			tutorialPage.SetValue(ContentPage.ContentProperty, grid);
			VisualDiagnostics.RegisterSourceInfo(grid, new Uri("Views\\TutorialPage.xaml", UriKind.RelativeOrAbsolute), 15, 6);
			VisualDiagnostics.RegisterSourceInfo(tutorialPage, new Uri("Views\\TutorialPage.xaml", UriKind.RelativeOrAbsolute), 2, 2);
		}

		private void __InitComponentRuntime()
		{
			this.LoadFromXaml(typeof(TutorialPage));
			This = this.FindByName<ContentPage>("This");
			slideView = this.FindByName<RadSlideView>("slideView");
		}
	}
}
