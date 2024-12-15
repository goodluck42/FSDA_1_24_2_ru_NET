namespace Inheritance;

public abstract class Button
{
	protected Button(int width, int height)
	{
		Width = width;
		Height = height;
	}

	public int Width { get; }
	public int Height { get; }
	
	public virtual int Radius { get; } = 0;

	public abstract void Click(object eventData); // virtual void Click(object data) = 0;

	public virtual void Click()
	{
		_clicked++;
	}

	public int GetClicked()
	{
		return _clicked;
	}

	private int _clicked;
}