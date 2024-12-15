using System.Collections;

namespace Interfaces;

class Stock : IStock
{
	private List<Item> _items = [];

	public void AddItem(Item item)
	{
		if (_items.Any(i => i.Id == item.Id))
		{
			return;
		}

		_items.Add(item);
	}

	public bool RemoveItem(int id)
	{
		var item = _items.FirstOrDefault(x => x.Id == id);

		if (item is null)
		{
			return false;
		}

		return _items.Remove(item);
	}

	public int Count => _items.Count;

	public Item this[int index]
	{
		get => _items[index];
		set => _items[index] = value;
	}

	public static int GetTotalCount()
	{
		throw new NotImplementedException();
	}

	public IEnumerator<Item> GetEnumerator()
	{
		return _items.GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}