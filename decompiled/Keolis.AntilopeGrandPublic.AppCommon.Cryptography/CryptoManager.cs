using Newtonsoft.Json;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Keolis.AntilopeGrandPublic.AppCommon.Cryptography
{
	public class CryptoManager
	{
		private readonly byte[] _key = new byte[16]
		{
			14,
			227,
			73,
			7,
			212,
			206,
			76,
			182,
			250,
			182,
			108,
			241,
			142,
			146,
			187,
			66
		};

		private readonly RijndaelManaged _aes;

		public static CryptoManager Current
		{
			get;
		} = new CryptoManager();


		private CryptoManager()
		{
			_aes = new RijndaelManaged
			{
				Key = _key,
				Padding = PaddingMode.PKCS7,
				Mode = CipherMode.CBC
			};
		}

		public EncryptedMessage Encrypt<T>(T obj)
		{
			_aes.GenerateIV();
			using (MemoryStream memoryStream = new MemoryStream())
			{
				using (CryptoStream cryptoStream = new CryptoStream(memoryStream, _aes.CreateEncryptor(), CryptoStreamMode.Write))
				{
					byte[] bytes = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(obj));
					cryptoStream.Write(bytes, 0, bytes.Length);
					cryptoStream.FlushFinalBlock();
					return new EncryptedMessage
					{
						IV = _aes.IV,
						CipherText = memoryStream.ToArray()
					};
				}
			}
		}

		public T Decrypt<T>(EncryptedMessage message)
		{
			_aes.IV = message.IV;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				using (CryptoStream cryptoStream = new CryptoStream(memoryStream, _aes.CreateDecryptor(), CryptoStreamMode.Write))
				{
					cryptoStream.Write(message.CipherText, 0, message.CipherText.Length);
					cryptoStream.FlushFinalBlock();
					byte[] bytes = memoryStream.ToArray();
					return JsonConvert.DeserializeObject<T>(Encoding.UTF8.GetString(bytes));
				}
			}
		}
	}
}
