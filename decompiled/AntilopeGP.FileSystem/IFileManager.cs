using System.IO;
using System.Threading.Tasks;

namespace AntilopeGP.FileSystem
{
	public interface IFileManager
	{
		string GetModeImageFilename(string mode);

		string GetLigneImageFilename(string ligne);

		Task<Stream> GetBundleBinaryFile(string filename);

		Task<string> GetBundleTextFile(string filename);

		string GetBundleFilePath(string filename);

		Stream GetCacheBinaryFile(string filename);

		string GetCacheTextFile(string filename);

		string GetCacheFilePath(string filename);

		void WriteCacheFile(Stream stream, string filename);

		bool CacheFileExists(string filename);
	}
}
