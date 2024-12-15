namespace Interfaces;

interface IStock : IEnumerable<Item>
{
	void AddItem(Item item);
	bool RemoveItem(int id);
	int Count { get; }
	Item this[int index] { get; set; }

	static abstract int GetTotalCount();
}