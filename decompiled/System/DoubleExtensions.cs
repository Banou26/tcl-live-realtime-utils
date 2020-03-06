namespace System
{
	public static class DoubleExtensions
	{
		public static string ToUSFormat(this double number)
		{
			return number.ToString().Replace(",", ".");
		}
	}
}
