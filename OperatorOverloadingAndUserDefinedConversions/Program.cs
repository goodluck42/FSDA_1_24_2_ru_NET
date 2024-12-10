namespace OperatorOverloadingAndUserDefinedConversions;

public static class Program
{
	static void Main(string[] args)
	{
		var intContainer = new IntContainer(12);

		foreach (var value in intContainer)
		{
			Console.Write(value);
			Console.Write(' ');
		}

		var intContainer2 = intContainer[^2..5];

		//intContainer[0] = 42;
		//Console.WriteLine(intContainer[0]);

		Console.WriteLine();
		
		foreach (var value in intContainer2)
		{
			Console.Write(value);
			Console.Write(' ');
		}
		
		//-----------------------------------
		// Number number = new Number(42);
		// Number number2 = new Number(42);
		// Number temp = -number;
		//
		// if (number.Equals(number2)) // equals = compare by value
		// {
		// 	Console.WriteLine("Equals");
		// }
		// else
		// {
		// 	Console.WriteLine("Not Equals");
		// }
		//
		// Console.WriteLine(temp.Value);
		// Console.WriteLine(number.Value);
		//
		// int num = new Number(); // implicit
		// string numString = (string)new Number(); // explicit

		// var sreznik = new Sreznik()
		// {
		// 	Grade = 6,
		// 	Name = "Nigar"
		// };
		//
		// PassObject(ref sreznik);
		//
		// Console.WriteLine(sreznik);
		//
		// Console.WriteLine("--------------------");
		//
		//
		// PassObjectByOut(out var sreznik1, out var sreznik2);
		//
		// Console.WriteLine(sreznik1);
		// Console.WriteLine(sreznik2);
	}

	static void PassObject(Sreznik sreznik) // void PassObject(Sreznik* sreznik)
	{
		sreznik.Grade -= 1; // sreznik->Grade -= 1;
	}

	static void PassObject(ref Sreznik sreznik) // void PassObject(Sreznik*& sreznik)
	{
		sreznik = new Sreznik()
		{
			Grade = 3,
			Name = "Ramazan"
		};
	}

	static void PassObjectByOut(out Sreznik sreznik, out Sreznik sreznik2)
	{
		sreznik = new Sreznik
		{
			Grade = 12,
			Name = "Nigar"
		};

		sreznik2 = new Sreznik
		{
			Grade = 7,
			Name = "Raul"
		};
	}

	static void PassObjectByIn(in Sreznik sreznik)
	{
		// sreznik = new Sreznik
		// {
		// 	Grade = 12,
		// 	Name = "Nigar"
		// };
	}
}