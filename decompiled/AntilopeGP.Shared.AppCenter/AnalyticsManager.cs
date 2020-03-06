using AntilopeGP.Shared.Events;
using Microsoft.AppCenter.Analytics;
using Prism.Events;

namespace AntilopeGP.Shared.AppCenter
{
	public class AnalyticsManager
	{
		public bool IsEnabled
		{
			set
			{
				Analytics.SetEnabledAsync(value);
			}
		}

		public AnalyticsManager(IEventAggregator ea)
		{
			ea.GetEvent<AnalyticsEvent>().Subscribe(ProcessAnalyticsReport);
		}

		private void ProcessAnalyticsReport(AnalyticsReport report)
		{
			Analytics.TrackEvent(report.Name, report.Properties);
		}
	}
}
