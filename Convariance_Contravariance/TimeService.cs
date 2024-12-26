namespace Convariance_Contravariance;

public class TimeService
{
	[Decorator(OutputType = OutputType.File)]
	public string GetTimeAsString()
	{
		return $"Time is: {DateTime.Now}";
	}
}