using System.IO;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace AntilopeGP.FileSystem
{
	public class FileManager : IFileManager
	{
		public string GetModeImageFilename(string mode)
		{
			return "pictoligne_mode_" + mode?.ToLower() + ".png";
		}

		public string GetLigneImageFilename(string ligne)
		{
			return "pictoligne_" + ligne?.ToLower() + ".png";
		}

		public async Task<Stream> GetBundleBinaryFile(string filename)
		{
			return await Xamarin.Essentials.FileSystem.OpenAppPackageFileAsync(filename);
		}

		public async Task<string> GetBundleTextFile(string filename)
		{
			using (Stream stream = await GetBundleBinaryFile(filename))
			{
				if (stream == null)
				{
					return null;
				}
				using (StreamReader reader = new StreamReader(stream))
				{
					return await reader.ReadToEndAsync();
				}
			}
		}

		public string GetBundleFilePath(string filename)
		{
			return Path.Combine(Xamarin.Essentials.FileSystem.AppDataDirectory, filename);
		}

		public Stream GetCacheBinaryFile(string filename)
		{
			return File.OpenRead(Path.Combine(Xamarin.Essentials.FileSystem.CacheDirectory, filename));
		}

		public string GetCacheTextFile(string filename)
		{
			using (Stream stream = GetCacheBinaryFile(filename))
			{
				if (stream != null)
				{
					using (StreamReader streamReader = new StreamReader(stream))
					{
						return streamReader.ReadToEnd();
					}
				}
				return null;
			}
		}

		public string GetCacheFilePath(string filename)
		{
			return Path.Combine(Xamarin.Essentials.FileSystem.CacheDirectory, filename);
		}

		public void WriteCacheFile(Stream stream, string filename)
		{
			string path = Path.Combine(Xamarin.Essentials.FileSystem.CacheDirectory, Path.GetDirectoryName(filename));
			if (!Directory.Exists(path))
			{
				Directory.CreateDirectory(path);
			}
			using (FileStream destination = File.OpenWrite(Path.Combine(Xamarin.Essentials.FileSystem.CacheDirectory, filename)))
			{
				stream.CopyTo(destination);
			}
		}

		public bool CacheFileExists(string filename)
		{
			return File.Exists(Path.Combine(Xamarin.Essentials.FileSystem.CacheDirectory, filename));
		}
	}
}
