namespace Calculator;

public class MyCalculator : IMyCalculator
{
	public int Add(int a, int b)
	{
		return a + b;
	}

	public int Subtract(int a, int b)
	{
		return a - b;
	}

	public double GetRadius(int r)
	{
		return Constants.PI * Math.Pow(r, 2);
	}

	private object op = new Operation();
	//private Operation op = new Operation();
	
	public void Foo()
	{
		var myOp = (Operation)op;
	}
}

file static class Constants
{
	public const double PI = 3.141592653589793238;
}

file class Operation
{
	public int Left { get; set; }
	public char Op { get; set; }
	public int Right { get; set; }
}