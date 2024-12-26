using System.Reflection;

namespace Convariance_Contravariance;

public class Caller
{
	private static DecoratorAttribute? _decoratorAttribute; 
	
	public static void Call(TimeService instance)
	{
		var type = typeof(TimeService);
		var methodInfo = type.GetMethod(nameof(TimeService.GetTimeAsString), BindingFlags.Instance | BindingFlags.Public);

		// null conditional

		if (_decoratorAttribute is null)
		{
			_decoratorAttribute = methodInfo?.GetCustomAttribute<DecoratorAttribute>();

			if (_decoratorAttribute is null)
			{
				throw new Exception();
			}
		}
		

		switch (_decoratorAttribute.OutputType)
		{
			case OutputType.Console:
				Console.WriteLine(instance.GetTimeAsString());
				break;
			case OutputType.File:
				File.WriteAllText("time.txt", instance.GetTimeAsString());
				break;
			default:
				throw new ArgumentOutOfRangeException();
		}
	}
}