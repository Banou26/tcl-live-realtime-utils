using AntilopeGP.Configuration;
using AntilopeGP.Data;
using AntilopeGP.FileSystem;
using AntilopeGP.Shared.AppCenter;
using AntilopeGP.Shared.Busy;
using AntilopeGP.Shared.Display;
using AntilopeGP.Shared.Events;
using AntilopeGP.Shared.Geolocation;
using AntilopeGP.Shared.Map;
using AntilopeGP.Shared.ViewModels.Pages;
using AntilopeGP.Shared.Views;
using AntilopeGP.Symbology;
using Esri.ArcGISRuntime;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Prism;
using Prism.DryIoc;
using Prism.Events;
using Prism.Ioc;
using Prism.Plugin.Popups;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Reflection;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Xaml.Diagnostics;
using Xamarin.Forms.Xaml.Internals;

namespace AntilopeGP
{
	[XamlFilePath("App.xaml")]
	public class App : PrismApplication
	{
		public App()
			: this(null)
		{
		}

		public App(IPlatformInitializer initializer)
			: base(initializer)
		{
		}

		protected override async void OnInitialized()
		{
			try
			{
				InitializeComponent();
				ArcGISRuntimeEnvironment.SetLicense("runtimelite,1000,rud2450418794,none,2K0RJAY3FLBBP2ELJ051");
				AppCenter.Start("android=9efaf29a-ff01-412f-abc1-0cdd26cdc592;ios=82ebcc8d-f204-4c29-87c1-8a106912da18", typeof(Crashes), typeof(Analytics));
				base.Container.Resolve<ErrorManager>().IsEnabled = true;
				base.Container.Resolve<AnalyticsManager>().IsEnabled = true;
				await base.NavigationService.NavigateAsync("MainPage");
			}
			catch (Exception)
			{
			}
		}

		protected override void RegisterTypes(IContainerRegistry containerRegistry)
		{
			containerRegistry.RegisterPopupNavigationService();
			Config currentConfig = Config.GetCurrentConfig();
			currentConfig.DeviceInfo.ScreenScale = DeviceDisplay.MainDisplayInfo.Density;
			containerRegistry.RegisterInstance(currentConfig);
			containerRegistry.RegisterSingleton<LiveDataManager>();
			containerRegistry.RegisterSingleton<IFileManager, FileManager>();
			containerRegistry.RegisterSingleton<SymbolsManager>();
			containerRegistry.RegisterSingleton<MapManager>();
			containerRegistry.Register<InsetsManager>();
			containerRegistry.RegisterSingleton<GeolocationManager>();
			containerRegistry.Register<BusyHelper>();
			containerRegistry.RegisterSingleton<ErrorManager>();
			containerRegistry.RegisterSingleton<AnalyticsManager>();
			containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
			containerRegistry.RegisterForNavigation<FiltreLignesPage, FiltreLignesPageViewModel>();
			containerRegistry.RegisterForNavigation<FavorisPage, FavorisPageViewModel>();
			containerRegistry.RegisterForNavigation<TutorialPage, TutorialPageViewModel>();
			containerRegistry.RegisterForNavigation<ModalPopupPage, ModalPopupPageViewModel>();
		}

		protected override void OnStart()
		{
			base.Container.Resolve<IEventAggregator>().GetEvent<AnalyticsEvent>().Publish(new AnalyticsReport("Démarrage de l'application"));
		}

		protected override void OnSleep()
		{
			base.Container.Resolve<IEventAggregator>().GetEvent<AnalyticsEvent>().Publish(new AnalyticsReport("Mise en pause de l'application"));
			base.Container.Resolve<LiveDataManager>().StopUpdates();
		}

		protected override void OnResume()
		{
			base.Container.Resolve<IEventAggregator>().GetEvent<AnalyticsEvent>().Publish(new AnalyticsReport("Reprise de l'application"));
			base.Container.Resolve<LiveDataManager>().StartUpdates(checkNow: true);
		}

		[GeneratedCode("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
		private void InitializeComponent()
		{
			if (ResourceLoader.CanProvideContentFor(new ResourceLoader.ResourceLoadingQuery
			{
				AssemblyName = typeof(App).GetTypeInfo().Assembly.GetName(),
				ResourcePath = "App.xaml",
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
			On on = new On();
			On on2 = new On();
			OnPlatform<string> onPlatform = new OnPlatform<string>();
			On on3 = new On();
			On on4 = new On();
			OnPlatform<string> onPlatform2 = new OnPlatform<string>();
			On on5 = new On();
			On on6 = new On();
			OnPlatform<string> onPlatform3 = new OnPlatform<string>();
			Color color = new Color(0.18823529779911041, 0.18823529779911041, 0.18431372940540314, 1.0);
			Color color2 = new Color(0.49019607901573181, 0.48627451062202454, 0.48627451062202454, 1.0);
			Color color3 = new Color(0.72156864404678345, 0.72156864404678345, 0.72156864404678345, 1.0);
			Color color4 = new Color(0.97254902124404907, 0.96078431606292725, 0.9686274528503418, 1.0);
			Color color5 = new Color(0.886274516582489, 0.0235294122248888, 0.074509806931018829, 1.0);
			ResourceDictionary resourceDictionary = new ResourceDictionary();
			App app;
			NameScope value = (NameScope)(NameScope.GetNameScope(app = this) ?? new NameScope());
			NameScope.SetNameScope(app, value);
			app.Resources = resourceDictionary;
			VisualDiagnostics.RegisterSourceInfo(resourceDictionary, new Uri("App.xaml", UriKind.RelativeOrAbsolute), 8, 10);
			on.Platform = new List<string>(1)
			{
				"Android"
			};
			on.Value = "Fonts/TCL-Light_0.otf#TCL";
			onPlatform.Platforms.Add(on);
			VisualDiagnostics.RegisterSourceInfo(on, new Uri("App.xaml", UriKind.RelativeOrAbsolute), 10, 18);
			on2.Platform = new List<string>(1)
			{
				"iOS"
			};
			on2.Value = "TCL-Light";
			onPlatform.Platforms.Add(on2);
			VisualDiagnostics.RegisterSourceInfo(on2, new Uri("App.xaml", UriKind.RelativeOrAbsolute), 11, 18);
			resourceDictionary.Add("TCLLight", onPlatform);
			on3.Platform = new List<string>(1)
			{
				"Android"
			};
			on3.Value = "Fonts/TCL-Regular_0.otf#TCL";
			onPlatform2.Platforms.Add(on3);
			VisualDiagnostics.RegisterSourceInfo(on3, new Uri("App.xaml", UriKind.RelativeOrAbsolute), 14, 18);
			on4.Platform = new List<string>(1)
			{
				"iOS"
			};
			on4.Value = "TCL-Regular";
			onPlatform2.Platforms.Add(on4);
			VisualDiagnostics.RegisterSourceInfo(on4, new Uri("App.xaml", UriKind.RelativeOrAbsolute), 15, 18);
			resourceDictionary.Add("TCLRegular", onPlatform2);
			on5.Platform = new List<string>(1)
			{
				"Android"
			};
			on5.Value = "Fonts/TCL-Bold_0.otf#TCL";
			onPlatform3.Platforms.Add(on5);
			VisualDiagnostics.RegisterSourceInfo(on5, new Uri("App.xaml", UriKind.RelativeOrAbsolute), 18, 18);
			on6.Platform = new List<string>(1)
			{
				"iOS"
			};
			on6.Value = "TCL-Bold";
			onPlatform3.Platforms.Add(on6);
			VisualDiagnostics.RegisterSourceInfo(on6, new Uri("App.xaml", UriKind.RelativeOrAbsolute), 19, 18);
			resourceDictionary.Add("TCLBold", onPlatform3);
			resourceDictionary.Add("DarkGrayColor", color);
			resourceDictionary.Add("MediumGrayColor", color2);
			resourceDictionary.Add("DisabledGrayColor", color3);
			resourceDictionary.Add("LightGrayColor", color4);
			resourceDictionary.Add("TCLRed", color5);
			app.Resources = resourceDictionary;
			VisualDiagnostics.RegisterSourceInfo(resourceDictionary, new Uri("App.xaml", UriKind.RelativeOrAbsolute), 8, 10);
			VisualDiagnostics.RegisterSourceInfo(app, new Uri("App.xaml", UriKind.RelativeOrAbsolute), 2, 2);
		}

		private void __InitComponentRuntime()
		{
			this.LoadFromXaml(typeof(App));
		}
	}
}
