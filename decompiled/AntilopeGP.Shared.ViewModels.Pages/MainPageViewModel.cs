using AntilopeGP.Configuration;
using AntilopeGP.FileSystem;
using AntilopeGP.Shared.Busy;
using AntilopeGP.Shared.Events;
using AntilopeGP.Shared.Map;
using AntilopeGP.Shared.ViewModels.Main;
using AntilopeGP.Symbology;
using Keolis.AntilopeGrandPublic.Common.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Prism.Events;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace AntilopeGP.Shared.ViewModels.Pages
{
	public class MainPageViewModel : ViewModelBase
	{
		private Config _config;

		private SymbolsManager _symbolsManager;

		private IFileManager _fileManager;

		private readonly IEventAggregator _eventAggregator;

		private BusyHelper _busyHelper;

		public ICommand FiltreMenuTapCommand
		{
			[CompilerGenerated]
			get
			{
				return _003CFiltreMenuTapCommand_003Ek__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (!object.Equals(_003CFiltreMenuTapCommand_003Ek__BackingField, value))
				{
					_003CFiltreMenuTapCommand_003Ek__BackingField = value;
					OnPropertyChanged(_003C_003EPropertyChangedEventArgs.FiltreMenuTapCommand);
				}
			}
		}

		public ICommand FavorisMenuTapCommand
		{
			[CompilerGenerated]
			get
			{
				return _003CFavorisMenuTapCommand_003Ek__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (!object.Equals(_003CFavorisMenuTapCommand_003Ek__BackingField, value))
				{
					_003CFavorisMenuTapCommand_003Ek__BackingField = value;
					OnPropertyChanged(_003C_003EPropertyChangedEventArgs.FavorisMenuTapCommand);
				}
			}
		}

		public ICommand LocaliseurButtonTapCommand
		{
			[CompilerGenerated]
			get
			{
				return _003CLocaliseurButtonTapCommand_003Ek__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (!object.Equals(_003CLocaliseurButtonTapCommand_003Ek__BackingField, value))
				{
					_003CLocaliseurButtonTapCommand_003Ek__BackingField = value;
					OnPropertyChanged(_003C_003EPropertyChangedEventArgs.LocaliseurButtonTapCommand);
				}
			}
		}

		public ICommand DisplayVehiculeDirectionButtonTapCommand
		{
			[CompilerGenerated]
			get
			{
				return _003CDisplayVehiculeDirectionButtonTapCommand_003Ek__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (!object.Equals(_003CDisplayVehiculeDirectionButtonTapCommand_003Ek__BackingField, value))
				{
					_003CDisplayVehiculeDirectionButtonTapCommand_003Ek__BackingField = value;
					OnPropertyChanged(_003C_003EPropertyChangedEventArgs.DisplayVehiculeDirectionButtonTapCommand);
				}
			}
		}

		public ICommand InfoButtonTapCommand
		{
			[CompilerGenerated]
			get
			{
				return _003CInfoButtonTapCommand_003Ek__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (!object.Equals(_003CInfoButtonTapCommand_003Ek__BackingField, value))
				{
					_003CInfoButtonTapCommand_003Ek__BackingField = value;
					OnPropertyChanged(_003C_003EPropertyChangedEventArgs.InfoButtonTapCommand);
				}
			}
		}

		public ICommand GeoViewTapCommand
		{
			[CompilerGenerated]
			get
			{
				return _003CGeoViewTapCommand_003Ek__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (!object.Equals(_003CGeoViewTapCommand_003Ek__BackingField, value))
				{
					_003CGeoViewTapCommand_003Ek__BackingField = value;
					OnPropertyChanged(_003C_003EPropertyChangedEventArgs.GeoViewTapCommand);
				}
			}
		}

		public ICommand ClosePopupTapCommand
		{
			[CompilerGenerated]
			get
			{
				return _003CClosePopupTapCommand_003Ek__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (!object.Equals(_003CClosePopupTapCommand_003Ek__BackingField, value))
				{
					_003CClosePopupTapCommand_003Ek__BackingField = value;
					OnPropertyChanged(_003C_003EPropertyChangedEventArgs.ClosePopupTapCommand);
				}
			}
		}

		public ICommand MaxVehiculesIconTapCommand
		{
			[CompilerGenerated]
			get
			{
				return _003CMaxVehiculesIconTapCommand_003Ek__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (!object.Equals(_003CMaxVehiculesIconTapCommand_003Ek__BackingField, value))
				{
					_003CMaxVehiculesIconTapCommand_003Ek__BackingField = value;
					OnPropertyChanged(_003C_003EPropertyChangedEventArgs.MaxVehiculesIconTapCommand);
				}
			}
		}

		public ICommand DataTimeoutIconTapCommand
		{
			[CompilerGenerated]
			get
			{
				return _003CDataTimeoutIconTapCommand_003Ek__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (!object.Equals(_003CDataTimeoutIconTapCommand_003Ek__BackingField, value))
				{
					_003CDataTimeoutIconTapCommand_003Ek__BackingField = value;
					OnPropertyChanged(_003C_003EPropertyChangedEventArgs.DataTimeoutIconTapCommand);
				}
			}
		}

		public bool UserLocationEnabled
		{
			[CompilerGenerated]
			get
			{
				return _003CUserLocationEnabled_003Ek__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (_003CUserLocationEnabled_003Ek__BackingField != value)
				{
					_003CUserLocationEnabled_003Ek__BackingField = value;
					OnPropertyChanged(_003C_003EPropertyChangedEventArgs.UserLocationEnabled);
				}
			}
		}

		public bool VehiculeDirectionDisplayed
		{
			[CompilerGenerated]
			get
			{
				return _003CVehiculeDirectionDisplayed_003Ek__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (_003CVehiculeDirectionDisplayed_003Ek__BackingField != value)
				{
					_003CVehiculeDirectionDisplayed_003Ek__BackingField = value;
					OnPropertyChanged(_003C_003EPropertyChangedEventArgs.VehiculeDirectionDisplayed);
				}
			}
		} = true;


		public MapManager MapManager
		{
			[CompilerGenerated]
			get
			{
				return _003CMapManager_003Ek__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (!object.Equals(_003CMapManager_003Ek__BackingField, value))
				{
					_003CMapManager_003Ek__BackingField = value;
					OnPropertyChanged(_003C_003EPropertyChangedEventArgs.MapManager);
				}
			}
		}

		public SelectedVehicule SelectedVehicule
		{
			[CompilerGenerated]
			get
			{
				return _003CSelectedVehicule_003Ek__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (!object.Equals(_003CSelectedVehicule_003Ek__BackingField, value))
				{
					_003CSelectedVehicule_003Ek__BackingField = value;
					OnPropertyChanged(_003C_003EPropertyChangedEventArgs.SelectedVehicule);
				}
			}
		}

		public int FavorisCount
		{
			[CompilerGenerated]
			get
			{
				return _003CFavorisCount_003Ek__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (_003CFavorisCount_003Ek__BackingField != value)
				{
					_003CFavorisCount_003Ek__BackingField = value;
					OnPropertyChanged(_003C_003EPropertyChangedEventArgs.FavorisCount);
				}
			}
		}

		public MainPageViewModel(INavigationService navigationService, MapManager mapManager, SymbolsManager symbolsManager, IFileManager fileManager, Config config, IEventAggregator eventAggregator, BusyHelper busyHelper)
			: base(navigationService)
		{
			try
			{
				_config = config;
				_symbolsManager = symbolsManager;
				_fileManager = fileManager;
				_eventAggregator = eventAggregator;
				_busyHelper = busyHelper;
				FiltreMenuTapCommand = new Command(OnFiltreMenuTapped);
				FavorisMenuTapCommand = new Command(OnFavorisMenuTapped);
				LocaliseurButtonTapCommand = new Command(OnLocaliseurButtonTapped);
				DisplayVehiculeDirectionButtonTapCommand = new Command(OnDisplayVehiculeDirectionButtonTapped);
				InfoButtonTapCommand = new Command(OnInfoButtonTapped);
				GeoViewTapCommand = new Command<Point>(OnGeoViewTapped);
				ClosePopupTapCommand = new Command(OnClosePopupTapped);
				MaxVehiculesIconTapCommand = new Command((Action)delegate
				{
					DisplayModalPopup("Oups.. beaucoup de bus et de trams par ici, merci de zoomer un peu + sur la zone désirée");
				});
				DataTimeoutIconTapCommand = new Command((Action)delegate
				{
					DisplayModalPopup("Les données ne sont pas à jour, veuillez vérifier votre connexion internet");
				});
				MapManager = mapManager;
				_eventAggregator.GetEvent<FavorisListChanged>().Subscribe(OnFavorisListChanged);
				OnFavorisListChanged();
			}
			catch (Exception)
			{
			}
		}

		private void OnFiltreMenuTapped()
		{
			base.NavigationService.NavigateAsync("FiltreLignesPage", null, true);
		}

		private void OnFavorisMenuTapped()
		{
			base.NavigationService.NavigateAsync("FavorisPage", null, true);
		}

		private async void OnLocaliseurButtonTapped()
		{
			_eventAggregator.GetEvent<AnalyticsEvent>().Publish(new AnalyticsReport("Tap sur le bouton de localisation utilisateur"));
			await MapManager.PanToUserLocation();
		}

		private void OnDisplayVehiculeDirectionButtonTapped()
		{
			_eventAggregator.GetEvent<AnalyticsEvent>().Publish(new AnalyticsReport
			{
				Name = "Tap sur le bouton d'affichage de la direction",
				Properties = new Dictionary<string, string>
				{
					{
						"Direction affichée",
						VehiculeDirectionDisplayed ? "Non" : "Oui"
					}
				}
			});
			MapManager.SetDisplayVehiculeDirection(!VehiculeDirectionDisplayed);
			VehiculeDirectionDisplayed = !VehiculeDirectionDisplayed;
		}

		private void OnInfoButtonTapped()
		{
			_eventAggregator.GetEvent<AnalyticsEvent>().Publish(new AnalyticsReport("Ouverture manuelle du tutorial"));
			base.NavigationService.NavigateAsync("TutorialPage", null, true);
		}

		private async void DisplayModalPopup(string message)
		{
			NavigationParameters navigationParameters = new NavigationParameters();
			navigationParameters.Add("Text", message);
			await base.NavigationService.NavigateAsync("ModalPopupPage", navigationParameters);
		}

		private async void OnGeoViewTapped(Point position)
		{
			Vehicule vehicule = await MapManager.GetVehiculeAtPosition(position);
			if (vehicule != null)
			{
				InfosLigne infosLigne = _config.Lignes.FirstOrDefault((InfosLigne x) => x.Ligne == vehicule.Ligne);
				SelectedVehicule = new SelectedVehicule
				{
					ModeImagePath = _fileManager.GetModeImageFilename(infosLigne?.Mode),
					LigneImagePath = _fileManager.GetLigneImageFilename(vehicule.Ligne),
					Destination = vehicule.Destination,
					ProchainArret = vehicule.ProchainArret
				};
				MapManager.HighlightVehicule(vehicule);
				_eventAggregator.GetEvent<AnalyticsEvent>().Publish(new AnalyticsReport
				{
					Name = "Véhicule sélectionné",
					Properties = new Dictionary<string, string>
					{
						{
							"Ligne",
							vehicule.Ligne
						},
						{
							"Destination",
							vehicule.Destination
						},
						{
							"Prochain arrêt",
							vehicule.ProchainArret
						}
					}
				});
			}
		}

		private void OnClosePopupTapped()
		{
			_eventAggregator.GetEvent<AnalyticsEvent>().Publish(new AnalyticsReport("Infobulle fermée"));
			MapManager.ClearVehiculesHighlights();
			SelectedVehicule = null;
		}

		private void OnFavorisListChanged()
		{
			FavorisCount = JsonConvert.DeserializeObject<JArray>(Preferences.Get("fr.tcl.antilopegp.favoris", "[]")).Count;
		}

		public override async void OnNavigatedTo(INavigationParameters parameters)
		{
			if (!TutorialPageViewModel.InitialTutorialAccepted)
			{
				await base.NavigationService.NavigateAsync("TutorialPage", null, true);
			}
			else if (!MapManager.MapLoaded)
			{
				_eventAggregator.GetEvent<AnalyticsEvent>().Publish(new AnalyticsReport("Ouverture de l'écran principal"));
				await _busyHelper.DisplayBusyAnimation("Chargement de la carte");
				MapManager.OnMapLoaded += OnMapLoaded;
				MapManager.LoadMap();
			}
		}

		private async void OnMapLoaded(object sender, EventArgs args)
		{
			MapManager.OnMapLoaded -= OnMapLoaded;
			await _busyHelper.HideBusyAnimation();
		}
	}
}
