namespace Calculator;

public class AccessModifiers
{
	internal int InternalProp { get; set; }

	protected internal int ProtectedInternalProp { get; set; }

	private protected int PrivateProtectedProp { get; set; }
}

public class AccessModifiers3 : AccessModifiers
{
	public AccessModifiers3()
	{
		this.InternalProp = 42;
		this.ProtectedInternalProp = 42;
		this.PrivateProtectedProp = 42;
	}
}