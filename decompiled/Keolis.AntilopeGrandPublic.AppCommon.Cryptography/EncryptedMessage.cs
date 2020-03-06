namespace Keolis.AntilopeGrandPublic.AppCommon.Cryptography
{
	public class EncryptedMessage
	{
		public byte[] IV
		{
			get;
			set;
		}

		public byte[] CipherText
		{
			get;
			set;
		}
	}
}
