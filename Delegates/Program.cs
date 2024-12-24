namespace Delegates;

class Program
{
	static void Main(string[] args)
	{
		var observableIntList = new ObservableIntList();
		
		observableIntList.Added += item =>
		{
			Console.WriteLine($"{item} added!");
		};
		
		observableIntList.Added += item =>
		{
			File.AppendAllText("data.txt", $"{item} added!");
		};
		
		observableIntList.Add(10);
		observableIntList.Add(20);
		observableIntList.Add(30);
		
		//////////////////////////////////////
		// var myLambda = (int a, int b) =>
		// {
		// 	Console.WriteLine("lambda");
		//
		// 	return a * b;
		// };

		// var myLambda2 = delegate (int a, int b)
		// {
		// 	Console.WriteLine("lambda");
		//
		// 	return a * b;
		// };

		// Func<int, int, int>? @delegate = MySum;
		//
		// @delegate += MySubtract;
		// @delegate += myLambda;
		//
		// Console.WriteLine(@delegate(10, 20));
		//
		// @delegate -= myLambda;
		// @delegate -= MySubtract;
		//
		// Console.WriteLine(@delegate?.Invoke(10, 20));

		
		///////////////////////////////
		// Func<int, int, long> x = (a, b) => (long)(a + b);

		// Func<int, int, long> x = MySum;
		// Action<int, int>? operation = null;
		//
		// Action a = () =>
		// {
		// 	Console.WriteLine("Delegate without params");
		// };
		//
		// a();
		//
		// Action<int> b = value =>
		// {
		// 	Console.WriteLine("Delegate with one param");
		// };

		// var choice = Console.ReadLine();
		//
		// if (choice == "sum")
		// { 
		// 	operation = Sum;
		// }
		//
		// if (choice == "subtract")
		// {
		// 	operation = Subtract;
		// }
		//
		// if (choice == "multiply")
		// {
		// 	operation = (a, b) =>
		// 	{
		// 		Console.WriteLine(a * b);
		// 	};
		// }
		//
		// operation?.Invoke(50, 90);
	}

	static void Sum(int a, int b)
	{
		Console.WriteLine(a + b);
	}

	static void Subtract(int a, int b)
	{
		Console.WriteLine(a - b);
	}

	static int MySum(int a, int b)
	{
		Console.WriteLine("MySum");

		return a + b;
	}

	static int MySubtract(int a, int b)
	{
		Console.WriteLine("MySubtract");

		return a - b;
	}
}