namespace LINQ;

public static class CollectionExtensions
{
	public static T GetByIndex<T>(this ICollection<T> source, int index)
	{
		var count = 0;
		
		foreach (var item in source)
		{
			if (count++ == index)
			{
				return item;
			}
		}

		throw new IndexOutOfRangeException("Invalid index");
	}
}