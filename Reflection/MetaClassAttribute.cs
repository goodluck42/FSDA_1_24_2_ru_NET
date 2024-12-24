namespace Reflection;

[AttributeUsage(AttributeTargets.Class)]
public class MetaClassAttribute : MetaAttribute
{
	public string? Name { get; set; }
}