using System.Collections;
using System.Text.Json;

namespace Interfaces;

class FileStock : IStock
{
	private const string FileName = "stock.json";
	private List<Item> _items = [];

	public void AddItem(Item item)
	{
		Load();
		_items.Add(item);
		Save();
	}

	public bool RemoveItem(int id)
	{
		Load();
		var item = _items.FirstOrDefault(x => x.Id == id);

		if (item is null)
		{
			return false;
		}

		var result = _items.Remove(item);

		Save();

		return result;
	}

	public int Count
	{
		get
		{
			Load();

			return _items.Count;
		}
	}

	public Item this[int index]
	{
		get
		{
			Load();

			return _items[index];
		}
		set
		{
			Load();

			_items[index] = value;

			Save();
		}
	}

	public static int GetTotalCount()
	{
		throw new NotImplementedException();
	}

	private bool Load()
	{
		try
		{
			if (!File.Exists(FileName))
			{
				return false;
			}

			var json = File.ReadAllText(FileName);
			var localItems = JsonSerializer.Deserialize<List<Item>>(json);

			_items = localItems ?? throw new InvalidOperationException("Items not found");

			return true;
		}
		catch
		{
			return false;
		}
	}

	private bool Save()
	{
		try
		{
			var json = JsonSerializer.Serialize(_items);

			File.WriteAllText(FileName, json);

			return true;
		}
		catch
		{
			return false;
		}
	}

	public IEnumerator<Item> GetEnumerator()
	{
		Load();
		
		return _items.GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}