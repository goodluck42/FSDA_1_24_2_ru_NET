namespace Interfaces;

// Model, anemic model
class Item
{
	public int Id { get; set; }
	public required string Name { get; set; }
	public int Count { get; set; }
}