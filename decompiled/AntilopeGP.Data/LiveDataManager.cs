using AntilopeGP.Configuration;
using AntilopeGP.Shared.Events;
using Keolis.AntilopeGrandPublic.AppCommon.Cryptography;
using Keolis.AntilopeGrandPublic.Common.Model;
using Keolis.AntilopeGrandPublic.FrontendCommon.Model;
using Newtonsoft.Json;
using Prism.Events;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AntilopeGP.Data
{
	public class LiveDataManager
	{
		private Config _config;

		private readonly Timer _updatePollTimer;

		private readonly Timer _dataTimeoutTimer;

		private DateTime? _lastUpdate;

		private IEnumerable<LigneSens> _lignes
		{
			get;
			set;
		}

		private Extent _extent
		{
			get;
			set;
		}

		public event EventHandler<IEnumerable<Vehicule>> DataUpdateAvailable;

		public event EventHandler<bool> VehiculeLimitExceeded;

		public event EventHandler<bool> DataTimeout;

		public LiveDataManager(Config config, IEventAggregator eventAggregator)
		{
			_config = config;
			_lignes = new LigneSens[0];
			_updatePollTimer = new Timer(CheckDataUpdate, null, -1, -1);
			_dataTimeoutTimer = new Timer(CheckDataTimeout, null, _config.Map.LiveDataTimeout, Timeout.InfiniteTimeSpan);
			eventAggregator.GetEvent<ExtentChangedEvent>().Subscribe(SetExtent);
			eventAggregator.GetEvent<SelectedLignesChangedEvent>().Subscribe(SetLignes);
		}

		public void StartUpdates(bool checkNow)
		{
			if (checkNow)
			{
				CheckDataUpdate(null);
			}
			else
			{
				_updatePollTimer.Change(_config.AntilopeWS.UpdatePollInterval, -1);
			}
		}

		public void RestartUpdates(bool forceReset, bool checkNow)
		{
			StopUpdates();
			if (forceReset)
			{
				_lastUpdate = null;
			}
			StartUpdates(checkNow);
		}

		public void StopUpdates()
		{
			_updatePollTimer.Change(-1, -1);
		}

		private void SetExtent(Extent extent)
		{
			_extent = extent;
			bool forceReset = true;
			RestartUpdates(forceReset, checkNow: true);
		}

		private void SetLignes(IEnumerable<LigneSens> lignes)
		{
			_lignes = lignes;
			bool forceReset = true;
			RestartUpdates(forceReset, checkNow: true);
		}

		private void CheckDataTimeout(object args)
		{
			this.DataTimeout?.Invoke(this, e: true);
		}

		private void CheckDataUpdate(object args)
		{
			Task.Run(async delegate
			{
				StopUpdates();
				DateTime? lastUpdate = await GetLastUpdate();
				if (lastUpdate == _lastUpdate || !lastUpdate.HasValue)
				{
					StartUpdates(checkNow: false);
				}
				else
				{
					VehiculeResponseModel vehiculeResponseModel = await GetVehicules();
					if (vehiculeResponseModel == null)
					{
						StartUpdates(checkNow: false);
					}
					else
					{
						this.DataUpdateAvailable?.Invoke(this, vehiculeResponseModel.Vehicules);
						this.VehiculeLimitExceeded?.Invoke(this, vehiculeResponseModel.LimitExceeded);
						_lastUpdate = lastUpdate;
						_dataTimeoutTimer.Change(_config.Map.LiveDataTimeout, Timeout.InfiniteTimeSpan);
						this.DataTimeout?.Invoke(this, e: false);
						StartUpdates(checkNow: false);
					}
				}
			});
		}

		private async Task<DateTime?> GetLastUpdate()
		{
			try
			{
				WebRequest webRequest = WebRequest.Create(_config.AntilopeWS.GetLastUpdateUrl);
				webRequest.Timeout = 10000;
				webRequest.Method = "GET";
				using (WebResponse webResponse = await webRequest.GetResponseAsync())
				{
					Stream responseStream = webResponse.GetResponseStream();
					StreamReader streamReader = new StreamReader(responseStream);
					return new DateTime(Convert.ToInt64(streamReader.ReadToEnd()));
				}
			}
			catch
			{
				return null;
			}
		}

		private async Task<VehiculeResponseModel> GetVehicules()
		{
			try
			{
				VehiculeRequestModel value = new VehiculeRequestModel
				{
					Lignes = _lignes,
					Extent = _extent
				};
				byte[] bytes = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(value, Formatting.None));
				WebRequest webRequest = WebRequest.Create(_config.AntilopeWS.GetVehiculesUrl);
				webRequest.Timeout = 10000;
				webRequest.Method = "POST";
				webRequest.ContentType = "application/json";
				webRequest.ContentLength = bytes.Length;
				Stream requestStream = webRequest.GetRequestStream();
				requestStream.Write(bytes, 0, bytes.Length);
				requestStream.Close();
				using (WebResponse webResponse = await webRequest.GetResponseAsync())
				{
					Stream responseStream = webResponse.GetResponseStream();
					JsonSerializer jsonSerializer = new JsonSerializer();
					using (StreamReader reader = new StreamReader(responseStream))
					{
						using (JsonTextReader reader2 = new JsonTextReader(reader))
						{
							EncryptedMessage message = jsonSerializer.Deserialize<EncryptedMessage>(reader2);
							return CryptoManager.Current.Decrypt<VehiculeResponseModel>(message);
						}
					}
				}
			}
			catch (Exception)
			{
				return null;
			}
		}
	}
}
