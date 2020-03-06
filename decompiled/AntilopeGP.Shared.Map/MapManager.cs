using AntilopeGP.Configuration;
using AntilopeGP.Data;
using AntilopeGP.Geometry;
using AntilopeGP.Shared.Events;
using AntilopeGP.Shared.Geolocation;
using AntilopeGP.Shared.Helpers;
using AntilopeGP.Symbology;
using Esri.ArcGISRuntime.Data;
using Esri.ArcGISRuntime.Geometry;
using Esri.ArcGISRuntime.Location;
using Esri.ArcGISRuntime.Mapping;
using Esri.ArcGISRuntime.Symbology;
using Esri.ArcGISRuntime.UI;
using Esri.ArcGISRuntime.Xamarin.Forms;
using Keolis.AntilopeGrandPublic.Common.Model;
using Keolis.AntilopeGrandPublic.FrontendCommon.Model;
using Newtonsoft.Json;
using Prism.Events;
using Prism.Services;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace AntilopeGP.Shared.Map
{
	public class MapManager : INotifyPropertyChanged
	{
		private MapView _mapView;

		private readonly GraphicsOverlay _vehiculesLayer;

		private readonly LiveDataManager _liveDataManager;

		private readonly SymbolsManager _symbolsManager;

		private readonly IDictionary<string, PictureMarkerSymbol> _symbolsCache;

		private readonly Config _config;

		private readonly IEventAggregator _eventAggregator;

		private readonly IPageDialogService _dialogService;

		private readonly GeolocationManager _geolocationManager;

		private double _currentSymbolOpacity = 1.0;

		private bool _displayVehiculeDirection = true;

		public IList<LigneSens> Lignes
		{
			[CompilerGenerated]
			get
			{
				return _003CLignes_003Ek__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (!object.Equals(_003CLignes_003Ek__BackingField, value))
				{
					_003CLignes_003Ek__BackingField = value;
					_003C_003EOnPropertyChanged(_003C_003EPropertyChangedEventArgs.Lignes);
				}
			}
		}

		public Extent MapExtent => _mapView?.VisibleArea?.Extent?.ToExtent();

		public bool VehiculeLimitExceeded
		{
			[CompilerGenerated]
			get
			{
				return _003CVehiculeLimitExceeded_003Ek__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (_003CVehiculeLimitExceeded_003Ek__BackingField != value)
				{
					_003CVehiculeLimitExceeded_003Ek__BackingField = value;
					_003C_003EOnPropertyChanged(_003C_003EPropertyChangedEventArgs.VehiculeLimitExceeded);
				}
			}
		}

		public bool DataTimeout
		{
			[CompilerGenerated]
			get
			{
				return _003CDataTimeout_003Ek__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (_003CDataTimeout_003Ek__BackingField != value)
				{
					_003CDataTimeout_003Ek__BackingField = value;
					_003C_003EOnPropertyChanged(_003C_003EPropertyChangedEventArgs.DataTimeout);
				}
			}
		}

		public bool MapLoaded => _mapView.Map != null;

		public event EventHandler OnMapLoaded;

		[field: NonSerialized]
		public event PropertyChangedEventHandler PropertyChanged;

		public MapManager(LiveDataManager liveDataManager, SymbolsManager symbolsManager, Config config, IEventAggregator eventAggregator, IPageDialogService dialogService, GeolocationManager geolocationManager)
		{
			_vehiculesLayer = new GraphicsOverlay
			{
				MinScale = config.Map.VehiculesLayerMinScale
			};
			_liveDataManager = liveDataManager;
			_liveDataManager.DataUpdateAvailable += OnDataUpdateAvailable;
			_liveDataManager.VehiculeLimitExceeded += OnVehiculeLimitExceeded;
			_liveDataManager.DataTimeout += OnDataTimeout;
			_symbolsManager = symbolsManager;
			_symbolsCache = new Dictionary<string, PictureMarkerSymbol>();
			_config = config;
			_eventAggregator = eventAggregator;
			_dialogService = dialogService;
			_geolocationManager = geolocationManager;
			Lignes = new LigneSens[0];
		}

		public void InitWithMapView(MapView mapView)
		{
			_mapView = mapView;
			_mapView.InteractionOptions = new MapViewInteractionOptions
			{
				IsMagnifierEnabled = false,
				IsRotateEnabled = false
			};
			_mapView.NavigationCompleted += OnMapNavigationCompleted;
			_mapView.ViewpointChanged += OnInitialViewPointSet;
			_mapView.GraphicsOverlays.Add(_vehiculesLayer);
			_liveDataManager.StartUpdates(checkNow: true);
			_mapView.LayerViewStateChanged += delegate(object s, LayerViewStateChangedEventArgs e)
			{
				Layer layer = _mapView.Map.Basemap.BaseLayers.First();
				if (e.Layer == layer && _mapView.GetLayerViewState(layer).Status == LayerViewStatus.Active)
				{
					Console.WriteLine("Basemap loaded");
					this.OnMapLoaded?.Invoke(this, EventArgs.Empty);
				}
			};
		}

		public async Task LoadMap()
		{
			Esri.ArcGISRuntime.Mapping.Map map = new Esri.ArcGISRuntime.Mapping.Map(_config.Map.URL);
			await map.LoadAsync();
			Console.WriteLine("Map loaded");
			await Task.WhenAll(map.AllLayers.Select((Layer x) => x.LoadAsync()));
			Console.WriteLine("Layers loaded");
			Device.BeginInvokeOnMainThread(delegate
			{
				_mapView.Map = map;
				_mapView.LocationDisplay.AutoPanMode = LocationDisplayAutoPanMode.Recenter;
				_mapView.LocationDisplay.LocationChanged += OnPanToUserLocationWhenLocationChanged;
				PanToUserLocation();
			});
		}

		public void SetLignes(IEnumerable<LigneSens> lignes)
		{
			if (lignes == null)
			{
				lignes = new LigneSens[0];
			}
			Lignes = lignes.ToList();
			UpdateLayersDefinitionExpressions();
			_eventAggregator.GetEvent<SelectedLignesChangedEvent>().Publish(lignes);
		}

		public void SetExtent(Extent extent)
		{
			_mapView.SetViewpoint(new Viewpoint(extent.ToEnvelope(_mapView.SpatialReference)));
			_eventAggregator.GetEvent<ExtentChangedEvent>().Publish(extent);
		}

		public void HighlightVehicule(Vehicule vehicule)
		{
			Graphic graphic = _vehiculesLayer.Graphics.FirstOrDefault((Graphic x) => x.Attributes["NumeroCarrosserie"].As<int>() == vehicule.NumeroCarrosserie);
			if (graphic != null)
			{
				graphic.ZIndex = _vehiculesLayer.Graphics.Max((Graphic x) => x.ZIndex) + 1;
				_currentSymbolOpacity = 0.4;
				foreach (Graphic graphic2 in _vehiculesLayer.Graphics)
				{
					graphic2.Symbol.As<PictureMarkerSymbol>().Opacity = _currentSymbolOpacity;
				}
				graphic.Symbol.As<PictureMarkerSymbol>().Opacity = 1.0;
			}
		}

		public void ClearVehiculesHighlights()
		{
			_currentSymbolOpacity = 1.0;
			foreach (Graphic graphic in _vehiculesLayer.Graphics)
			{
				graphic.Symbol.As<PictureMarkerSymbol>().Opacity = _currentSymbolOpacity;
			}
		}

		public void SetDisplayVehiculeDirection(bool display)
		{
			_displayVehiculeDirection = display;
			_symbolsCache.Clear();
			Task.Run(async delegate
			{
				foreach (Graphic graphic2 in _vehiculesLayer.Graphics)
				{
					Vehicule vehicule = JsonConvert.DeserializeObject<Vehicule>(graphic2.Attributes["Vehicule"].ToString());
					Graphic graphic = graphic2;
					graphic.Symbol = await GetVehiculeSymbol(vehicule);
				}
			});
		}

		public async Task<IEnumerable<LigneSens>> GetVisibleLignes()
		{
			FeatureLayer featureLayer = _mapView.Map.OperationalLayers.Single((Layer x) => x.Id == _config.Map.LignesLayerId).As<FeatureLayer>();
			Extent mapExtent = MapExtent;
			string url = $"{featureLayer.FeatureTable.As<ServiceFeatureTable>().Source}/query?" + "geometry=" + mapExtent.Xmin.ToUSFormat() + "," + mapExtent.Ymin.ToUSFormat() + "," + mapExtent.Xmax.ToUSFormat() + "," + mapExtent.Ymax.ToUSFormat() + "&geometryType=esriGeometryEnvelope&spatialRel=esriSpatialRelIntersects&outFields=Ligne,Sens&returnGeometry=false&returnExceededLimitFeatures=true&f=json";
			LigneQueryResult ligneQueryResult = await HttpHelper.Get<LigneQueryResult>(url);
			if (ligneQueryResult == null)
			{
				return new LigneSens[0];
			}
			return ligneQueryResult.Features.Select((Feature x) => new LigneSens
			{
				Ligne = x.Attributes.Ligne,
				Sens = x.Attributes.Sens
			}).ToList();
		}

		public async Task<Vehicule> GetVehiculeAtPosition(Point position)
		{
			Graphic graphic = (await _mapView.IdentifyGraphicsOverlayAsync(_vehiculesLayer, position, 10.0, returnPopupsOnly: false, 1L)).Graphics.FirstOrDefault();
			if (graphic == null)
			{
				return null;
			}
			return JsonConvert.DeserializeObject<Vehicule>(graphic.Attributes["Vehicule"].As<string>());
		}

		public async Task PanToUserLocation()
		{
			Xamarin.Essentials.Location location = await _geolocationManager.GetUserLocation();
			await Device.InvokeOnMainThreadAsync(async delegate
			{
				if (location != null)
				{
					_mapView.LocationDisplay.IsEnabled = true;
				}
				else
				{
					await _dialogService.DisplayAlertAsync("Localisation", "La localisation n'est pas activée, impossible de vous localiser sur la carte.", "OK");
				}
			});
			if (location != null)
			{
				await Device.InvokeOnMainThreadAsync(async () => await _mapView.SetViewpointAsync(new Viewpoint(new MapPoint(location.Longitude, location.Latitude, SpatialReferences.Wgs84), _mapView.LocationDisplay.InitialZoomScale)));
			}
		}

		private void OnMapNavigationCompleted(object sender, EventArgs eventArgs)
		{
			_mapView.ViewpointChanged -= OnInitialViewPointSet;
			_eventAggregator.GetEvent<ExtentChangedEvent>().Publish(MapExtent);
		}

		private void OnInitialViewPointSet(object sender, EventArgs eventArgs)
		{
			if (MapExtent != null)
			{
				_eventAggregator.GetEvent<ExtentChangedEvent>().Publish(MapExtent);
			}
		}

		private async void OnPanToUserLocationWhenLocationChanged(object sender, Esri.ArcGISRuntime.Location.Location e)
		{
			if (_mapView.LocationDisplay.MapLocation.X != 0.0 || _mapView.LocationDisplay.MapLocation.Y != 0.0)
			{
				_mapView.LocationDisplay.LocationChanged -= OnPanToUserLocationWhenLocationChanged;
				await PanToUserLocation();
			}
		}

		private void OnDataUpdateAvailable(object sender, IEnumerable<Vehicule> vehicules)
		{
			List<int> currentNumeroCarrosserie = _vehiculesLayer.Graphics.Select((Graphic x) => x.Attributes["NumeroCarrosserie"].As<int>()).ToList();
			List<int> newNumeroCarrosserie = vehicules.Select((Vehicule x) => x.NumeroCarrosserie).ToList();
			List<Vehicule> added = vehicules.Where((Vehicule x) => !x.NumeroCarrosserie.In(currentNumeroCarrosserie)).ToList();
			List<KeyValuePair<Graphic, Vehicule>> updated = _vehiculesLayer.Graphics.Join(vehicules, (Graphic x) => x.Attributes["NumeroCarrosserie"].As<int>(), (Vehicule x) => x.NumeroCarrosserie, (Graphic c, Vehicule n) => new KeyValuePair<Graphic, Vehicule>(c, n)).ToList();
			List<Graphic> removed = _vehiculesLayer.Graphics.Where((Graphic x) => !x.Attributes["NumeroCarrosserie"].As<int>().In(newNumeroCarrosserie)).ToList();
			Task.Run(async delegate
			{
				_ = 1;
				try
				{
					foreach (Graphic item in removed)
					{
						_vehiculesLayer.Graphics.Remove(item);
					}
					foreach (Vehicule item2 in added)
					{
						Graphic graphic = await GetVehiculeGraphic(item2);
						if (graphic != null)
						{
							_vehiculesLayer.Graphics.Add(graphic);
						}
					}
					await UpdateVehiculesGraphics(updated);
				}
				catch (Exception)
				{
				}
			});
		}

		private void OnVehiculeLimitExceeded(object sender, bool limitExceeded)
		{
			VehiculeLimitExceeded = limitExceeded;
		}

		private void OnDataTimeout(object sender, bool timeout)
		{
			DataTimeout = timeout;
		}

		private async Task<Graphic> GetVehiculeGraphic(Vehicule vehicule)
		{
			try
			{
				MapPoint geometry = new MapPoint(vehicule.X, vehicule.Y, _mapView.SpatialReference);
				PictureMarkerSymbol symbol = await GetVehiculeSymbol(vehicule);
				Graphic graphic = new Graphic
				{
					Geometry = geometry,
					Symbol = symbol
				};
				graphic.Attributes.Add("NumeroCarrosserie", vehicule.NumeroCarrosserie);
				graphic.Attributes.Add("Ligne", vehicule.Ligne);
				graphic.Attributes.Add("Destination", vehicule.Destination);
				graphic.Attributes.Add("Cap", vehicule.Cap);
				graphic.Attributes.Add("Vehicule", JsonConvert.SerializeObject(vehicule, Formatting.None));
				return graphic;
			}
			catch (Exception)
			{
				return null;
			}
		}

		private async Task<PictureMarkerSymbol> GetVehiculeSymbol(Vehicule vehicule)
		{
			string symbolCacheKey = vehicule.Ligne + vehicule.Destination + vehicule.Cap;
			if (!_symbolsCache.ContainsKey(symbolCacheKey))
			{
				VehiculeSymbol rawSymbol = await _symbolsManager.GetMapVehiculeSymbol(vehicule, _displayVehiculeDirection);
				PictureMarkerSymbol pictureMarkerSymbol = await PictureMarkerSymbol.CreateAsync(rawSymbol.Stream);
				pictureMarkerSymbol.Height = _config.Map.VehiculeSymbolHeight;
				pictureMarkerSymbol.Width = pictureMarkerSymbol.Height * (double)rawSymbol.Width / (double)rawSymbol.Height;
				pictureMarkerSymbol.OffsetY = (0.0 - rawSymbol.YOffsetFromCenter) * pictureMarkerSymbol.Height / (double)rawSymbol.Height;
				_symbolsCache.Add(symbolCacheKey, pictureMarkerSymbol);
			}
			PictureMarkerSymbol pictureMarkerSymbol2 = _symbolsCache[symbolCacheKey].Clone().As<PictureMarkerSymbol>();
			pictureMarkerSymbol2.Opacity = _currentSymbolOpacity;
			return pictureMarkerSymbol2;
		}

		private async Task UpdateVehiculesGraphics(IEnumerable<KeyValuePair<Graphic, Vehicule>> vehicules)
		{
			var vehiculesConfig = vehicules.Select((KeyValuePair<Graphic, Vehicule> x) => new
			{
				Graphic = x.Key,
				NewVehicule = x.Value,
				InitialLocation = x.Key.Geometry.As<MapPoint>()
			});
			foreach (var vehicule in vehiculesConfig)
			{
				if (vehicule.Graphic.Attributes["Ligne"].As<string>() != vehicule.NewVehicule.Ligne || vehicule.Graphic.Attributes["Destination"].As<string>() != vehicule.NewVehicule.Destination || vehicule.Graphic.Attributes["Cap"].As<int>() != vehicule.NewVehicule.Cap)
				{
					Graphic graphic = vehicule.Graphic;
					graphic.Symbol = await GetVehiculeSymbol(vehicule.NewVehicule);
				}
				vehicule.Graphic.Attributes["Vehicule"] = JsonConvert.SerializeObject(vehicule.NewVehicule, Formatting.None);
			}
			Easing easing = Easing.CubicInOut;
			double animationPeriod = TimeSpan.FromSeconds(1.0 / _config.Map.GraphicAnimationFPS).TotalMilliseconds;
			Stopwatch stopWatch = new Stopwatch();
			stopWatch.Start();
			while (stopWatch.Elapsed < _config.Map.GraphicAnimationDuration)
			{
				TimeSpan elapsed = stopWatch.Elapsed;
				double num = easing.Ease(elapsed.TotalMilliseconds / _config.Map.GraphicAnimationDuration.TotalMilliseconds);
				foreach (var item in vehiculesConfig)
				{
					double x2 = item.InitialLocation.X + (item.NewVehicule.X - item.InitialLocation.X) * num;
					double y = item.InitialLocation.Y + (item.NewVehicule.Y - item.InitialLocation.Y) * num;
					item.Graphic.Geometry = new MapPoint(x2, y, _mapView.SpatialReference);
				}
				await Task.Delay((int)Math.Max(0.0, animationPeriod - (stopWatch.Elapsed - elapsed).TotalMilliseconds));
			}
			stopWatch.Stop();
		}

		private void UpdateLayersDefinitionExpressions()
		{
			FeatureLayer featureLayer = _mapView.Map.OperationalLayers.Single((Layer x) => x.Id == _config.Map.LignesLayerId).As<FeatureLayer>();
			FeatureLayer featureLayer2 = _mapView.Map.OperationalLayers.Single((Layer x) => x.Id == _config.Map.ArretsLayerId).As<FeatureLayer>();
			if (Lignes.Any())
			{
				featureLayer.DefinitionExpression = string.Join(" OR ", Lignes.Select((LigneSens x) => "(Ligne='" + x.Ligne + "' AND Sens='" + x.Sens + "')"));
				featureLayer2.DefinitionExpression = string.Join(" OR ", Lignes.Select((LigneSens x) => "Ligne='" + x.Ligne + "'"));
			}
			else
			{
				featureLayer.DefinitionExpression = string.Empty;
				featureLayer2.DefinitionExpression = string.Empty;
			}
		}

		[GeneratedCode("PropertyChanged.Fody", "3.2.1.0")]
		[DebuggerNonUserCode]
		protected void _003C_003EOnPropertyChanged(PropertyChangedEventArgs eventArgs)
		{
			this.PropertyChanged?.Invoke(this, eventArgs);
		}
	}
}
