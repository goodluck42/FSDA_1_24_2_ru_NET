namespace Inheritance;

public abstract class RoundedButton : Button
{
	protected RoundedButton(int width, int height) : base(width, height)
	{
	}

	public override int Radius => 6;
}