namespace OperatorOverloadingAndUserDefinedConversions;

public class Sreznik
{
	private int _grade;

	public int Grade
	{
		get => _grade;
		set
		{
			if (value > 12 || value <= 0)
			{
				throw new ArgumentOutOfRangeException();
			}
			
			_grade = value;
		}
	}

	public required string Name { get; set; }

	public override string ToString()
	{
		return $"Name: {Name}: {Grade}";
	}
}