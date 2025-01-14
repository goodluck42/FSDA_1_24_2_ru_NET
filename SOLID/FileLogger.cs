namespace SOLID;

public class FileLogger : ILogger
{
	public void Log(string message)
	{
		File.AppendAllText("logs.txt", $"[{DateTime.Now}]: {message}]");
	}
}