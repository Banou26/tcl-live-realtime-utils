using System.Collections.Generic;

namespace AntilopeGP.Shared.Events
{
	public class AnalyticsReport
	{
		public string Name
		{
			get;
			set;
		}

		public IDictionary<string, string> Properties
		{
			get;
			set;
		}

		public AnalyticsReport()
		{
		}

		public AnalyticsReport(string name)
		{
			Name = name;
		}
	}
}
