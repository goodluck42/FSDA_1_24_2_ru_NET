namespace Inheritance;

public class LinuxButton : Button
{
	public LinuxButton(int width, int height) : base(width, height)
	{
	}

	public override void Click(object eventData)
	{
		Console.WriteLine("LinuxButton clicked");
	}

	public override void Click()
	{
		base.Click();
		
		Click(new object());
	}
}