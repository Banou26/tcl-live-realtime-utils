using AntilopeGP.Configuration;
using AntilopeGP.FileSystem;
using AntilopeGP.Shared.Events;
using AntilopeGP.Shared.Map;
using AntilopeGP.Shared.ViewModels.Favoris;
using Keolis.AntilopeGrandPublic.FrontendCommon.Model;
using Newtonsoft.Json;
using Prism.Events;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Telerik.XamarinForms.DataControls.ListView.Commands;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace AntilopeGP.Shared.ViewModels.Pages
{
	public class FavorisPageViewModel : ViewModelBase
	{
		public const string FAVORIS_PREFERENCES_KEY = "fr.tcl.antilopegp.favoris";

		private MapManager _mapManager;

		private Config _config;

		private IFileManager _fileManager;

		private readonly IEventAggregator _eventAggregator;

		private readonly IPageDialogService _dialogService;

		public ICommand CloseTapCommand
		{
			[CompilerGenerated]
			get
			{
				return _003CCloseTapCommand_003Ek__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (!object.Equals(_003CCloseTapCommand_003Ek__BackingField, value))
				{
					_003CCloseTapCommand_003Ek__BackingField = value;
					OnPropertyChanged(_003C_003EPropertyChangedEventArgs.CloseTapCommand);
				}
			}
		}

		public ICommand AjouterFavorisTapCommand
		{
			[CompilerGenerated]
			get
			{
				return _003CAjouterFavorisTapCommand_003Ek__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (!object.Equals(_003CAjouterFavorisTapCommand_003Ek__BackingField, value))
				{
					_003CAjouterFavorisTapCommand_003Ek__BackingField = value;
					OnPropertyChanged(_003C_003EPropertyChangedEventArgs.AjouterFavorisTapCommand);
				}
			}
		}

		public ICommand FavorisDeleteCommand
		{
			[CompilerGenerated]
			get
			{
				return _003CFavorisDeleteCommand_003Ek__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (!object.Equals(_003CFavorisDeleteCommand_003Ek__BackingField, value))
				{
					_003CFavorisDeleteCommand_003Ek__BackingField = value;
					OnPropertyChanged(_003C_003EPropertyChangedEventArgs.FavorisDeleteCommand);
				}
			}
		}

		public ICommand FavorisReorderCommand
		{
			[CompilerGenerated]
			get
			{
				return _003CFavorisReorderCommand_003Ek__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (!object.Equals(_003CFavorisReorderCommand_003Ek__BackingField, value))
				{
					_003CFavorisReorderCommand_003Ek__BackingField = value;
					OnPropertyChanged(_003C_003EPropertyChangedEventArgs.FavorisReorderCommand);
				}
			}
		}

		public ICommand FavorisTapCommand
		{
			[CompilerGenerated]
			get
			{
				return _003CFavorisTapCommand_003Ek__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (!object.Equals(_003CFavorisTapCommand_003Ek__BackingField, value))
				{
					_003CFavorisTapCommand_003Ek__BackingField = value;
					OnPropertyChanged(_003C_003EPropertyChangedEventArgs.FavorisTapCommand);
				}
			}
		}

		public ObservableCollection<InfoLigne> SelectedLignes
		{
			[CompilerGenerated]
			get
			{
				return _003CSelectedLignes_003Ek__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(_003CSelectedLignes_003Ek__BackingField, value))
				{
					_003CSelectedLignes_003Ek__BackingField = value;
					OnPropertyChanged(_003C_003EPropertyChangedEventArgs.SelectedLignes);
				}
			}
		}

		public ObservableCollection<Favori> Favoris
		{
			[CompilerGenerated]
			get
			{
				return _003CFavoris_003Ek__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(_003CFavoris_003Ek__BackingField, value))
				{
					_003CFavoris_003Ek__BackingField = value;
					OnPropertyChanged(_003C_003EPropertyChangedEventArgs.Favoris);
				}
			}
		}

		public string FavoriName
		{
			[CompilerGenerated]
			get
			{
				return _003CFavoriName_003Ek__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!string.Equals(_003CFavoriName_003Ek__BackingField, value, StringComparison.Ordinal))
				{
					_003CFavoriName_003Ek__BackingField = value;
					OnPropertyChanged(_003C_003EPropertyChangedEventArgs.FavoriName);
				}
			}
		}

		public double SwipeWidth => 200.0;

		public Thickness SwipeOffset => new Thickness(SwipeWidth, 0.0, 0.0, 0.0);

		public ICommand OuvrirAideWebTapCommand
		{
			[CompilerGenerated]
			get
			{
				return _003COuvrirAideWebTapCommand_003Ek__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (!object.Equals(_003COuvrirAideWebTapCommand_003Ek__BackingField, value))
				{
					_003COuvrirAideWebTapCommand_003Ek__BackingField = value;
					OnPropertyChanged(_003C_003EPropertyChangedEventArgs.OuvrirAideWebTapCommand);
				}
			}
		}

		public FavorisPageViewModel(INavigationService navigationService, MapManager mapManager, IFileManager fileManager, Config config, IEventAggregator eventAggregator, IPageDialogService dialogService)
			: base(navigationService)
		{
			_mapManager = mapManager;
			_config = config;
			_fileManager = fileManager;
			_eventAggregator = eventAggregator;
			_dialogService = dialogService;
			CloseTapCommand = new Command(OnCloseTapped);
			AjouterFavorisTapCommand = new Command(OnAjouterFavorisTapped);
			FavorisDeleteCommand = new Command(OnFavorisDeleted);
			FavorisReorderCommand = new Command<ReorderEndedCommandContext>(OnFavorisReordered);
			FavorisTapCommand = new Command<ItemTapCommandContext>(OnFavorisTapped);
			OuvrirAideWebTapCommand = new Command(OnOuvrirAideWebTapped);
			SelectedLignes = new ObservableCollection<InfoLigne>();
			Favoris = new ObservableCollection<Favori>();
		}

		private void OnCloseTapped()
		{
			_eventAggregator.GetEvent<AnalyticsEvent>().Publish(new AnalyticsReport("Fermeture de l'écran des favoris"));
			base.NavigationService.GoBackAsync();
		}

		private void OnAjouterFavorisTapped()
		{
			if (string.IsNullOrWhiteSpace(FavoriName))
			{
				_dialogService.DisplayAlertAsync("Erreur", "Veuillez saisir un nom pour le favori", "OK");
				return;
			}
			_eventAggregator.GetEvent<AnalyticsEvent>().Publish(new AnalyticsReport("Ajout d'un favori"));
			IList<FavoriPreferences> list = JsonConvert.DeserializeObject<IList<FavoriPreferences>>(Preferences.Get("fr.tcl.antilopegp.favoris", "[]"));
			list.Add(new FavoriPreferences
			{
				Name = FavoriName,
				MapExtent = _mapManager.MapExtent,
				Lignes = _mapManager.Lignes
			});
			Preferences.Set("fr.tcl.antilopegp.favoris", JsonConvert.SerializeObject(list, Formatting.None));
			FavoriName = null;
			InitFavoris();
		}

		private async void OnFavorisDeleted(object favori)
		{
			if (await _dialogService.DisplayAlertAsync("Suppression du favori", "Voulez-vous supprimer le favori?", "Oui", "Non"))
			{
				_eventAggregator.GetEvent<AnalyticsEvent>().Publish(new AnalyticsReport("Suppression d'un favori"));
				Favoris.Remove(favori.As<Favori>());
				SaveFavoris();
				InitFavoris();
			}
		}

		private void OnFavorisReordered(ReorderEndedCommandContext context)
		{
			int oldIndex = Favoris.IndexOf(context.Item.As<Favori>());
			int newIndex = Favoris.IndexOf(context.DestinationItem.As<Favori>());
			Favoris.Move(oldIndex, newIndex);
			SaveFavoris();
			InitFavoris();
		}

		private void OnFavorisTapped(ItemTapCommandContext context)
		{
			_eventAggregator.GetEvent<AnalyticsEvent>().Publish(new AnalyticsReport("Sélection d'un favori"));
			base.NavigationService.GoBackAsync();
			Favori favori = context.Item.As<Favori>();
			IEnumerable<LigneSens> lignes = favori.Lignes.Select((InfoLigne x) => new LigneSens
			{
				Ligne = x.Ligne,
				Sens = x.Sens,
				Destination = x.Destination
			});
			_mapManager.SetLignes(lignes);
			_mapManager.SetExtent(favori.MapExtent);
		}

		public override void OnNavigatedTo(INavigationParameters parameters)
		{
			_eventAggregator.GetEvent<AnalyticsEvent>().Publish(new AnalyticsReport("Ouverture de l'écran des favoris"));
			InitSelectedLignes();
			InitFavoris();
		}

		private void InitSelectedLignes()
		{
			SelectedLignes.Clear();
			foreach (LigneSens ligne in _mapManager.Lignes)
			{
				InfosLigne infosLigne = _config.Lignes.FirstOrDefault((InfosLigne x) => x.Ligne == ligne.Ligne);
				SelectedLignes.Add(new InfoLigne
				{
					ModeImagePath = _fileManager.GetModeImageFilename(infosLigne?.Mode),
					LigneImagePath = _fileManager.GetLigneImageFilename(ligne.Ligne),
					Ligne = ligne.Ligne,
					Sens = ligne.Sens,
					Destination = ligne.Destination
				});
			}
		}

		private void InitFavoris()
		{
			IList<FavoriPreferences> list = JsonConvert.DeserializeObject<IList<FavoriPreferences>>(Preferences.Get("fr.tcl.antilopegp.favoris", "[]"));
			Favoris.Clear();
			foreach (FavoriPreferences item in list)
			{
				IEnumerable<InfoLigne> enumerable = item.Lignes.Select(delegate(LigneSens x)
				{
					InfosLigne infosLigne = _config.Lignes.FirstOrDefault((InfosLigne ligne) => ligne.Ligne == x.Ligne);
					return new InfoLigne
					{
						ModeImagePath = _fileManager.GetModeImageFilename(infosLigne?.Mode),
						LigneImagePath = _fileManager.GetLigneImageFilename(x.Ligne),
						Ligne = x.Ligne,
						Sens = x.Sens,
						Destination = x.Destination
					};
				});
				Favori favori = new Favori
				{
					Name = item.Name,
					MapExtent = item.MapExtent,
					Lignes = new List<InfoLigne>()
				};
				foreach (InfoLigne item2 in enumerable)
				{
					favori.Lignes.Add(item2);
				}
				Favoris.Add(favori);
			}
			foreach (Favori favori2 in Favoris)
			{
				favori2.AlternateRow = (Favoris.IndexOf(favori2) % 2 != 0);
			}
			_eventAggregator.GetEvent<FavorisListChanged>().Publish();
		}

		private void SaveFavoris()
		{
			IEnumerable<FavoriPreferences> value = Favoris.Select((Favori x) => new FavoriPreferences
			{
				Name = x.Name,
				MapExtent = x.MapExtent,
				Lignes = x.Lignes.Select((InfoLigne ligne) => new LigneSens
				{
					Ligne = ligne.Ligne,
					Sens = ligne.Sens,
					Destination = ligne.Destination
				})
			});
			Preferences.Set("fr.tcl.antilopegp.favoris", JsonConvert.SerializeObject(value, Formatting.None));
		}

		private async void OnOuvrirAideWebTapped()
		{
			_eventAggregator.GetEvent<AnalyticsEvent>().Publish(new AnalyticsReport("Ouverture de l'aide des favoris"));
			await Browser.OpenAsync("https://www.tcl.fr/assistance/tcl-live/comment-gerer-les-favoris", BrowserLaunchMode.SystemPreferred);
		}
	}
}
