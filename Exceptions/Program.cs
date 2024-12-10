using Exceptions;

Console.WriteLine("Hello World!");

// static ctor
// StaticClass.StaticProperty = 50;

// static class StaticClass
// {
// 	static StaticClass()
// 	{
// 		Console.WriteLine("StaticConstructor");
//
// 		StaticProperty = 42;
// 	}
//
// 	public static int StaticProperty
// 	{
// 		get;
// 		set;
// 	}
//
// 	public static void StaticMethod()
// 	{
// 		Console.WriteLine("StaticMethod");
// 	}
// }

var user = new User();
try
{
	user.MyLogin = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaa";

	if (user.MyLogin.Length > User.MaxLoginLength)
	{
	}
}
catch (Exception ex) when (ex is UninitializedMemberException or ArgumentException)
{
	Console.WriteLine(ex.Message);
}
catch (NotSupportedException)
{
	Console.WriteLine("NotSupportedException");
}
catch (Exception ex)
{
	// Console.WriteLine(ex.Message);
}
finally
{
	Console.WriteLine("Finnaly");
}
// 00001111
// 0 + 0 + 0 + 0 + 8 + 4 + 2 + 1 = 15

int a = int.MaxValue;

try
{
	unchecked
	{
		a += 1;
	}
}
catch (OverflowException ex)
{
	a = int.MaxValue;

	Console.WriteLine(ex.Message);
}

// Console.WriteLine("100" + "10"); // 110

Console.WriteLine(a);

// Console.WriteLine(user.MyLogin.Length);

// if (user.Login != null)
// {
// 	Console.WriteLine(user.Login.Length);
// }


// File.Open("file.txt", FileMode.Open);


// Finally clause
// int i = 0;
//
// while (true)
// {
// 	try
// 	{
// 		i++;
// 	}
// 	finally
// 	{
// 		if (i == 5)
// 		{
// 			break;
// 		}
// 	}
// }