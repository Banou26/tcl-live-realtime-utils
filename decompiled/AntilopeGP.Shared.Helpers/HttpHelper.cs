using Newtonsoft.Json;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace AntilopeGP.Shared.Helpers
{
	public class HttpHelper
	{
		public static async Task<T> Get<T>(string url) where T : class
		{
			try
			{
				WebRequest webRequest = WebRequest.Create(url);
				webRequest.Timeout = 10000;
				webRequest.Method = "GET";
				using (WebResponse webResponse = await webRequest.GetResponseAsync())
				{
					Stream responseStream = webResponse.GetResponseStream();
					JsonSerializer jsonSerializer = new JsonSerializer();
					using (StreamReader reader = new StreamReader(responseStream))
					{
						using (JsonTextReader reader2 = new JsonTextReader(reader))
						{
							return jsonSerializer.Deserialize<T>(reader2);
						}
					}
				}
			}
			catch
			{
				return null;
			}
		}
	}
}
