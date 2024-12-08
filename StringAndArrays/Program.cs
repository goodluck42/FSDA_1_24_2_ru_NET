using System;

// Top level statements
// var x = Console.ReadLine();
//
// if (x != null)
// {
// 	int value = int.Parse(x);
//
// 	Console.WriteLine(x);
// }

// int argNum = 0;
//
// foreach (var arg in args)
// {
// 	Console.WriteLine($"{argNum++}: {arg}");
// }
//
// Console.ReadLine();

// var str = "Hello world!";
//
// str += "42";
//
// Console.WriteLine(str);
//
// var replaced = str.Replace("Hello", "Goodbye");
//
// Console.WriteLine(replaced);
//
// string cat = "MainCat|SubCat|SubCat2";
// string[] split = cat.Split('|');
//
// foreach (var val in split)
// {
// 	Console.WriteLine(val);
// }
//
// string result = string.Join("<=>", split);
//
// Console.WriteLine(result);
///////////////////////////////
/// Arrays
// string[] names = { "Ramin", "Nigar", "Rauf" };
// string[] names = ["Ramin", "Nigar", "Rauf"];
// string?[] names = new string[3];
// string[] names = new string[3] { "Ramin", "Nigar", "Ramazan" };
//// Nullable and Arrays
//// Example1
// string?[] values = { "nigar", null, "guseyn" };
//
// foreach (var value in values)
// {
// 	if (value != null)
// 	{
// 		Console.WriteLine(value.Capitalize());
// 	}
// }
//// Example2
// string?[]? values = { "nigar", null, "guseyn" };
//
// if (values != null)
// {
// 	foreach (var value in values)
// 	{
// 		if (value != null)
// 		{
// 			Console.WriteLine(value.Capitalize());
// 		}
// 	}
// }

//// Arrays
// string[] names = new string[3] { "Ramin", "Nigar", "Ramazan" };
//
// for (int i = 0; i < names.Length; i++)
// {
// 	Console.WriteLine(names[i]);
// }


//// Md arrays
// int[,] grid = new int[3, 4];
// int d0Length = grid.GetLength(0);
// int d0Boundary = grid.GetUpperBound(0);
// int d1Boundary = grid.GetUpperBound(1);
//
// Console.WriteLine($"d0Length = {d0Length}");
// Console.WriteLine($"d0Boundary = {d0Boundary}");
// Console.WriteLine($"d1Boundary = {d1Boundary}");
//
// for (int i = 0; i < grid.GetLength(0); i++)
// {
// 	for (int j = 0; j < grid.GetLength(1); j++)
// 	{
// 		grid[i, j] = 0;
// 	}
// }
//
// Console.Read();

// Jagged arrays
int[][] jaggedArray = new int[3][];

Console.WriteLine(jaggedArray[1][2]);

const int size = 3;

for (int i = 0; i < jaggedArray.Length; i++)
{
	jaggedArray[i] = new int[size + i];
	
	for (int j = 0; j < jaggedArray[i].Length; j++)
	{
		jaggedArray[i][j] = Random.Shared.Next(10, 99);
	}
}

