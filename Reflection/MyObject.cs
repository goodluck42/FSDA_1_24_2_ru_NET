using System.Text;

namespace Reflection;

[MetaClass]
public class MyObject
{
	[MetaMember] private int _privateField = 42;

	[MetaMember]
	public void ShowPrivateField(int a)
	{
		Console.WriteLine(_privateField);
	}

	[MetaMember]
	public void Foo(int a, float x, StringBuilder z)
	{
		Console.WriteLine(_privateField);
	}

	public void Foo(int a)
	{
		Console.WriteLine(_privateField);
	}
}