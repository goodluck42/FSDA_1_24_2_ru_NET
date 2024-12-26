namespace Convariance_Contravariance;

public class DecoratorAttribute : Attribute
{
	public required OutputType OutputType { get; init; }
}