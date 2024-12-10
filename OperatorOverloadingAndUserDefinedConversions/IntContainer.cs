using System.Collections;

namespace OperatorOverloadingAndUserDefinedConversions;


/// <summary>
/// This is my sample class.
/// </summary>
public class IntContainer : IEnumerable<int>
{
	private int[] _arr;

	public IntContainer(int count)
	{
		_arr = new int[count];

		GenerateRandomElements(count);
	}

	private IntContainer(int[] arr)
	{
		_arr = arr;
	}

	public int this[Index index]
	{
		get => _arr[index];
		//set => _arr[index] = value;
	}

	/// <summary>
	/// This is indexer.
	/// </summary>
	/// <param name="range">this is a slice</param>
	/// <returns>A new copy of <see cref="IntContainer"/> </returns>
	public IntContainer this[Range range]
	{
		get
		{
			int count = range.End.Value - range.Start.Value;
			int[] arr = new int[count];

			for (int i = range.Start.Value, x = 0; i < range.End.Value; i++)
			{
				arr[x++] = _arr[i];
			}

			return new IntContainer(arr);
		}
	}

	private void GenerateRandomElements(int count)
	{
		for (int i = 0; i < count; i++)
		{
			_arr[i] = Random.Shared.Next(-100, 100);
		}
	}

	public IEnumerator<int> GetEnumerator()
	{
		return ((IEnumerable<int>)_arr).GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}