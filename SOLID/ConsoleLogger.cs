namespace SOLID;

public class ConsoleLogger : ILogger
{
	public void Log(string message)
	{
		Console.WriteLine($"[{DateTime.Now}]: {message}]");
	}
}