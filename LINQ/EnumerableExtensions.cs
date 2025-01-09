namespace LINQ;

public static partial class EnumerableExtensions
{
	public static void Print<T>(this IEnumerable<T> source)
	{
		var enumerator = source.GetEnumerator();

		while (enumerator.MoveNext())
		{
			Console.WriteLine(enumerator.Current);
		}

		//enumerator.Reset();
		enumerator.Dispose();
	}
}

public static partial class EnumerableExtensions
{
	public static IEnumerable<TSource> MyWhere<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
	{
		foreach (var item in source)
		{
			if (predicate(item))
			{
				yield return item;
			}
		}
	}
	
	// public static IEnumerable<string> YieldTest()
	// {
	// 	Console.WriteLine("before foo");
	// 	yield return "foo";
	// 	Console.WriteLine("before bar");
	// 	yield return "bar";
	// 	Console.WriteLine("before baz");
	// 	yield return "baz";
	// }
}