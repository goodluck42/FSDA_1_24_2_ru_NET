using Interfaces;

IStock myStock = new Stock();

FileStock.GetTotalCount();

myStock.AddItem(new Item
{
	Id = 1,
	Name = "Tomato",
	Count = 3
});

myStock.AddItem(new Item
{
	Id = 2,
	Name = "Xiyar",
	Count = 1
});

myStock.AddItem(new Item
{
	Id = 3,
	Name = "Apple",
	Count = 2
});

myStock.AddItem(new Item
{
	Id = 4,
	Name = "Watermelon",
	Count = 1
});

PrintStockItems(myStock);

Donkey donkey = new Donkey();
IA rauf = donkey as IA;
IB ilkin = donkey as IB;

donkey.PrintDonkey();
rauf.PrintDonkey();
ilkin.PrintDonkey();

void PrintStockItems(IStock stock)
{
	// for (int i = 0; i < stock.Count; i++)
	// {
	// 	Console.WriteLine($"{stock[i].Id}: {stock[i].Name}[{stock[i].Count}]");
	// }


	foreach (var item in stock)
	{
		Console.WriteLine($"{item.Id}: {item.Name}[{item.Count}]");
	}
}
interface IA
{
	void PrintDonkey();
}
interface IB
{
	void PrintDonkey();
}
class Donkey : IA, IB
{
	public void PrintDonkey()
	{
		Console.WriteLine("Donkey.PrintDonkey");
	}
	void IA.PrintDonkey()
	{
		Console.WriteLine("IA.PrintDonkey");
	}

	void IB.PrintDonkey()
	{
		Console.WriteLine("IB.PrintDonkey");
	}
}