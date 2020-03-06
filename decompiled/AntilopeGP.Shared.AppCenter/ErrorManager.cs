using AntilopeGP.Shared.Events;
using Keolis.AntilopeGrandPublic.FrontendCommon.Model;
using Microsoft.AppCenter.Crashes;
using Newtonsoft.Json;
using Prism.Events;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AntilopeGP.Shared.AppCenter
{
	public class ErrorManager
	{
		private Extent _extent;

		private IEnumerable<LigneSens> _lignes;

		public bool IsEnabled
		{
			set
			{
				Crashes.SetEnabledAsync(value);
			}
		}

		public ErrorManager(IEventAggregator ea)
		{
			AppDomain.CurrentDomain.UnhandledException += delegate(object s, UnhandledExceptionEventArgs e)
			{
				ReportException(e.ExceptionObject as Exception);
			};
			TaskScheduler.UnobservedTaskException += delegate(object s, UnobservedTaskExceptionEventArgs e)
			{
				ReportException(e.Exception.InnerException);
			};
			SubscribeToEvents(ea);
		}

		private void SubscribeToEvents(IEventAggregator ea)
		{
			ea.GetEvent<ErrorEvent>().Subscribe(ProcessError);
			ea.GetEvent<ExtentChangedEvent>().Subscribe(delegate(Extent extent)
			{
				_extent = extent;
			});
			ea.GetEvent<SelectedLignesChangedEvent>().Subscribe(delegate(IEnumerable<LigneSens> lignes)
			{
				_lignes = lignes;
			});
		}

		private void ProcessError(Error error)
		{
		}

		private void ReportException(Exception e)
		{
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			try
			{
				string value = JsonConvert.SerializeObject(_extent);
				string value2 = JsonConvert.SerializeObject(_lignes);
				dictionary.Add("Extent", value);
				dictionary.Add("Lignes", value2);
			}
			catch
			{
			}
			Crashes.TrackError(e, dictionary);
		}
	}
}
