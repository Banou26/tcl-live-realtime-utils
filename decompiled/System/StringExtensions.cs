using System.Security.Cryptography;
using System.Text;

namespace System
{
	public static class StringExtensions
	{
		public static string FirstLetterToUpper(this string str)
		{
			if (str == null)
			{
				return null;
			}
			if (str.Length > 1)
			{
				return char.ToUpper(str[0]) + str.Substring(1);
			}
			return str.ToUpper();
		}

		public static string GetHash(this string str)
		{
			using (MD5 mD = MD5.Create())
			{
				byte[] bytes = Encoding.ASCII.GetBytes(str);
				byte[] array = mD.ComputeHash(bytes);
				StringBuilder stringBuilder = new StringBuilder();
				for (int i = 0; i < array.Length; i++)
				{
					stringBuilder.Append(array[i].ToString("X2"));
				}
				return stringBuilder.ToString();
			}
		}
	}
}
