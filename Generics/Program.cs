using System.Collections;
using System.Text;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Generics;
//
// var storage = new LocalStorage<Game>(5)
// {
// 	new Game
// 	{
// 		Id = 1,
// 		Name = "GTA: SA"
// 	},
// 	new Game
// 	{
// 		Id = 2,
// 		Name = "R6 Siege"
// 	},
// 	new Game
// 	{
// 		Id = 3,
// 		Name = "R6 Siege: Extraction"
// 	}
// };

// storage.Add(new Game
// {
// 	Id = 1,
// 	Name = "GTA: SA"
// });
//
// storage.Add(new Game
// {
// 	Id = 2,
// 	Name = "R6 Siege"
// });
//
// storage.Add(new Game
// {
// 	Id = 2,
// 	Name = "R6 Siege: Extraction"
// });

// int val = 42; 
//
// var arrList = new ArrayList();
//
// arrList.Add(val); // boxing
// arrList.Add(10); // boxing
// arrList.Add(20); // boxing
// arrList.Add(30); // boxing
//
// foreach (var item in arrList)
// {
// 	int value = (int)item; // unboxing
//
// 	Console.WriteLine(value);
// }

[MemoryDiagnoser]
public class GenericBenchmark
{
	[Benchmark]
	public void NonGenericVersion()
	{
		var arrList = new ArrayList();

		for (int i = 0; i < 5_000_000; i++)
		{
			arrList.Add(i);
		}

		for (int i = 0; i < arrList.Count; i++)
		{
			int value = (int)arrList[i]!;
		}
	}

	[Benchmark]
	public void GenericVersion()
	{
		var list = new List<int>();

		for (int i = 0; i < 5_000_000; i++)
		{
			list.Add(i);
		}

		for (int i = 0; i < list.Count; i++)
		{
			int value = list[i]!;
		}
	}
}

public class Program
{
	public static void Main(string[] args)
	{
		var summary = BenchmarkRunner.Run(typeof(Program).Assembly);
	}
}