using System.Linq;

namespace System.Collections.Generic
{
	public static class EnumerableExtensions
	{
		public static bool In<T>(this T source, IEnumerable<T> array)
		{
			return array.Contains(source);
		}

		public static IEnumerable<TSource> DistinctBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
		{
			HashSet<TKey> knownKeys = new HashSet<TKey>();
			foreach (TSource item in source)
			{
				if (knownKeys.Add(keySelector(item)))
				{
					yield return item;
				}
			}
		}
	}
}
