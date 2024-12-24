namespace Delegates;

class ObservableIntList
{
	private readonly List<int> _list;

	public ObservableIntList()
	{
		_list = new List<int>();
	}

	public event Action<int>? Added;
	
	public void Add(int value)
	{
		_list.Add(value);
		
		Added?.Invoke(value);
	}

	public int this[int index]
	{
		get => _list[index];
		set => _list[index] = value;
	}
}