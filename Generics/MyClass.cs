using Generics;

public class MyClass : ISerializable
{
	public MyClass()
	{
		Console.WriteLine("default constructor");
	}

	public byte[] Serialize()
	{
		return new byte[] { 1, 2, 3 };
	}
}