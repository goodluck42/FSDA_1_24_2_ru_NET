namespace Patterns;

public sealed class UWorld
{
	private UWorld()
	{
		
	}

	public object GetGameState()
	{
		return new object();
	}
	
	// ...
	
	private static UWorld? _instance;

	public static UWorld GetWorld()
	{
		if (_instance is null)
		{
			_instance = new UWorld();
		}
		
		return _instance;
	}

	// public static UWorld Instance => _instance ??= new UWorld();
}