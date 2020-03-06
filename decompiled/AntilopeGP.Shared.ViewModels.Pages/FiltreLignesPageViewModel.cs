using AntilopeGP.Configuration;
using AntilopeGP.FileSystem;
using AntilopeGP.Shared.Events;
using AntilopeGP.Shared.Map;
using AntilopeGP.Shared.ViewModels.FiltreLignes;
using AntilopeGP.Symbology;
using Keolis.AntilopeGrandPublic.FrontendCommon.Model;
using Prism.Events;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Input;
using Telerik.XamarinForms.DataControls.ListView.Commands;
using Xamarin.Forms;

namespace AntilopeGP.Shared.ViewModels.Pages
{
	public class FiltreLignesPageViewModel : ViewModelBase
	{
		private Config _config;

		private SymbolsManager _symbolsManager;

		private MapManager _mapManager;

		private IFileManager _fileManager;

		private readonly IEventAggregator _eventAggregator;

		public bool AllLignesSelected
		{
			[CompilerGenerated]
			get
			{
				return _003CAllLignesSelected_003Ek__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (_003CAllLignesSelected_003Ek__BackingField != value)
				{
					_003CAllLignesSelected_003Ek__BackingField = value;
					OnPropertyChanged(_003C_003EPropertyChangedEventArgs.AllLignesSelected);
				}
			}
		}

		public bool PartialLignesSelected
		{
			[CompilerGenerated]
			get
			{
				return _003CPartialLignesSelected_003Ek__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (_003CPartialLignesSelected_003Ek__BackingField != value)
				{
					_003CPartialLignesSelected_003Ek__BackingField = value;
					OnPropertyChanged(_003C_003EPropertyChangedEventArgs.PartialLignesSelected);
				}
			}
		}

		public bool NoLignesSelected
		{
			[CompilerGenerated]
			get
			{
				return _003CNoLignesSelected_003Ek__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (_003CNoLignesSelected_003Ek__BackingField != value)
				{
					_003CNoLignesSelected_003Ek__BackingField = value;
					OnPropertyChanged(_003C_003EPropertyChangedEventArgs.NoLignesSelected);
				}
			}
		}

		public bool IsBusy
		{
			[CompilerGenerated]
			get
			{
				return _003CIsBusy_003Ek__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (_003CIsBusy_003Ek__BackingField != value)
				{
					_003CIsBusy_003Ek__BackingField = value;
					OnPropertyChanged(_003C_003EPropertyChangedEventArgs.IsBusy);
				}
			}
		}

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

		public ICommand SelectAllTapCommand
		{
			[CompilerGenerated]
			get
			{
				return _003CSelectAllTapCommand_003Ek__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (!object.Equals(_003CSelectAllTapCommand_003Ek__BackingField, value))
				{
					_003CSelectAllTapCommand_003Ek__BackingField = value;
					OnPropertyChanged(_003C_003EPropertyChangedEventArgs.SelectAllTapCommand);
				}
			}
		}

		public ICommand ItemTapCommand
		{
			[CompilerGenerated]
			get
			{
				return _003CItemTapCommand_003Ek__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(_003CItemTapCommand_003Ek__BackingField, value))
				{
					_003CItemTapCommand_003Ek__BackingField = value;
					OnPropertyChanged(_003C_003EPropertyChangedEventArgs.ItemTapCommand);
				}
			}
		}

		public ObservableCollection<InfoLigne> Lignes
		{
			[CompilerGenerated]
			get
			{
				return _003CLignes_003Ek__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!object.Equals(_003CLignes_003Ek__BackingField, value))
				{
					_003CLignes_003Ek__BackingField = value;
					OnPropertyChanged(_003C_003EPropertyChangedEventArgs.Lignes);
				}
			}
		}

		public FiltreLignesPageViewModel(INavigationService navigationService, Config config, SymbolsManager symbolsManager, MapManager mapManager, IFileManager fileManager, IEventAggregator eventAggregator)
			: base(navigationService)
		{
			_config = config;
			_symbolsManager = symbolsManager;
			_mapManager = mapManager;
			_fileManager = fileManager;
			_eventAggregator = eventAggregator;
			IsBusy = false;
			CloseTapCommand = new Command(OnCloseTapped);
			SelectAllTapCommand = new Command(OnSelectAllTapped);
			ItemTapCommand = new Command<ItemTapCommandContext>(OnItemTapped);
			Lignes = new ObservableCollection<InfoLigne>();
		}

		private void OnCloseTapped()
		{
			_eventAggregator.GetEvent<AnalyticsEvent>().Publish(new AnalyticsReport("Fermeture de l'écran de filtre des lignes"));
			if (PartialLignesSelected)
			{
				IEnumerable<LigneSens> enumerable = from x in Lignes
					where x.Selected
					select new LigneSens
					{
						Ligne = x.Ligne,
						Sens = x.Sens,
						Destination = x.Destination
					};
				_mapManager.SetLignes(enumerable);
				foreach (LigneSens item in enumerable)
				{
					_eventAggregator.GetEvent<AnalyticsEvent>().Publish(new AnalyticsReport
					{
						Name = "Sélection ligne",
						Properties = new Dictionary<string, string>
						{
							{
								"Ligne",
								item.Ligne + " - " + item.Sens
							}
						}
					});
				}
			}
			else
			{
				_mapManager.SetLignes(null);
				_eventAggregator.GetEvent<AnalyticsEvent>().Publish(new AnalyticsReport
				{
					Name = "Sélection ligne",
					Properties = new Dictionary<string, string>
					{
						{
							"Ligne",
							"Toutes"
						}
					}
				});
			}
			base.NavigationService.GoBackAsync();
		}

		private void OnSelectAllTapped()
		{
			if (AllLignesSelected || PartialLignesSelected)
			{
				foreach (InfoLigne ligne in Lignes)
				{
					ligne.SetSelected(selected: false);
				}
			}
			else
			{
				foreach (InfoLigne ligne2 in Lignes)
				{
					ligne2.SetSelected(selected: true);
				}
			}
			UpdateLignesSelectedProperties();
		}

		private void OnItemTapped(ItemTapCommandContext context)
		{
			InfoLigne infoLigne = context.Item.As<InfoLigne>();
			infoLigne.SetSelected(!infoLigne.Selected);
			UpdateLignesSelectedProperties();
		}

		public override async void OnNavigatedTo(INavigationParameters parameters)
		{
			_eventAggregator.GetEvent<AnalyticsEvent>().Publish(new AnalyticsReport("Ouverture de l'écran de filtre des lignes"));
			await InitLignes();
		}

		private async Task InitLignes()
		{
			IsBusy = true;
			IEnumerable<LigneSens> source = await _mapManager.GetVisibleLignes();
			IList<LigneSens> lignes = _mapManager.Lignes;
			List<InfoLigne> list = _config.Lignes.Select((InfosLigne x) => new InfoLigne
			{
				ModeImagePath = _fileManager.GetModeImageFilename(x.Mode),
				LigneImagePath = _fileManager.GetLigneImageFilename(x.Ligne),
				Ligne = x.Ligne,
				Sens = x.Sens,
				Destination = x.Destination,
				TempsReel = x.TempsReel,
				Selected = x.TempsReel,
				Proximity = true
			}).ToList();
			foreach (InfoLigne ligne in list)
			{
				ligne.SetSelected(!lignes.Any() || lignes.Any((LigneSens x) => x.Ligne == ligne.Ligne && x.Sens == ligne.Sens));
				ligne.Proximity = source.Any((LigneSens x) => x.Ligne == ligne.Ligne && x.Sens == ligne.Sens);
			}
			int num = 1;
			foreach (InfoLigne item in list.Where((InfoLigne x) => x.Proximity))
			{
				item.AlternateRow = (num % 2 == 0);
				num++;
			}
			num = 1;
			foreach (InfoLigne item2 in list.Where((InfoLigne x) => !x.Proximity))
			{
				item2.AlternateRow = (num % 2 == 0);
				num++;
			}
			foreach (InfoLigne item3 in list)
			{
				Lignes.Add(item3);
			}
			UpdateLignesSelectedProperties();
			IsBusy = false;
		}

		private void UpdateLignesSelectedProperties()
		{
			AllLignesSelected = Lignes.Where((InfoLigne x) => x.TempsReel).All((InfoLigne x) => x.Selected);
			PartialLignesSelected = (Lignes.Where((InfoLigne x) => x.TempsReel).Any((InfoLigne x) => x.Selected) && !AllLignesSelected);
			NoLignesSelected = (!AllLignesSelected && !PartialLignesSelected);
		}
	}
}
