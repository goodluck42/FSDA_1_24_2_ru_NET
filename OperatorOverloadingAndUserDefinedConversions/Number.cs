namespace OperatorOverloadingAndUserDefinedConversions;

public class Number
{
	private int _number;

	public Number(int initialValue = 0)
	{
		_number = initialValue;
	}

	public int Value => _number;

	public static Number operator -(Number self)
	{
		return new Number(-self._number);
	}

	// += 
	public static Number operator +(Number left, Number right)
	{
		return new Number(left._number + right._number);
	}

	// public static bool operator ==(Number left, Number right)
	// {
	// 	return left._number == right._number;
	// }
	//
	// public static bool operator !=(Number left, Number right)
	// {
	// 	return !(left == right);
	// }

	public override bool Equals(object? obj)
	{
		if (obj is Number number)
		{
			return number._number == _number;
		}

		return false;
	}

	public static bool operator true(Number self)
	{
		return self._number != 0;
	}

	public static bool operator false(Number self)
	{
		return self._number == 0;
	}

	// user defined conversions

	public static explicit operator string(Number self)
	{
		return self._number.ToString();
	}

	public static implicit operator int(Number self)
	{
		return self._number;
	}
}