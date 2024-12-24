using System.Collections;

namespace Generics;

public class LocalStorage<TModel> : ILocalStorage<TModel>
{
	private readonly TModel[] _items;
	private int _length;

	public LocalStorage(int maxCapacity)
	{
		_items = new TModel[maxCapacity];
	}

	public void Add(TModel model)
	{
		if (_length == _items.Length)
		{
			throw new IndexOutOfRangeException();
		}

		_items[_length++] = model;
	}

	public IEnumerator<TModel> GetEnumerator()
	{
		return new Enumerator(this);
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	private class Enumerator : IEnumerator<TModel>
	{
		private readonly TModel[] _items;
		private int _index;
		private readonly int _currentLength;
		
		public Enumerator(LocalStorage<TModel> localStorage)
		{
			_items = localStorage._items;
			_currentLength = localStorage._length;
			
			Reset();
		}
		
		public bool MoveNext()
		{
			if (_index == _currentLength - 1)
			{
				return false;
			}
			
			_index++;

			return true;
		}

		public void Reset()
		{
			_index = -1;
		}

		public TModel Current => _items[_index];

		object? IEnumerator.Current => Current;

		public void Dispose()
		{
			
		}
	}
}