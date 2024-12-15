namespace Inheritance;

public class WindowsButton : RoundedButton
{
	public WindowsButton(int width, int height) : base(width, height)
	{
	}
	
	public override void Click(object eventData)
	{
		Console.WriteLine("WindowsButton clicked");
	}

	public override void Click()
	{
		base.Click();

		Click(new object());
	}
	
	public new int GetClicked()
	{
		return 1337;
	}
}