// int x = 42;
// object o = x; // boxing
//
// int y = (int)o; // unboxing

Console.WriteLine(0xff);
Console.WriteLine(0b1111);
/////////////
//var acc = new Account(1, "pashok_1337", "nagibator228_1337_42_69_1488");

var acc = new Account
{
	Id = 1,
	Login = "pashok_1337",
	Password = "nagibator228_1337_42_69_1488"
};

var newAcc = acc with { Password = "new_password69" };

Console.WriteLine(acc);
Console.WriteLine(newAcc);

void PrintVector(in Vector2d vector)
{
	Console.WriteLine(vector.X);
	Console.WriteLine(vector.Y);

	// vector = new Vector2d();
}

public readonly struct Vector2d : IEquatable<Vector2d>, IComparable
{
	private readonly int _x;
	private readonly int _y;

	public Vector2d()
	{
		X = 0;
		Y = 0;
	}

	public int X
	{
		get => _x;
		init
		{
			if (value < 0)
			{
				throw new ArgumentException("Value cannot be negative.");
			}

			_x = value;
		}
	}

	public int Y
	{
		get => _y;
		init
		{
			if (value < 0)
			{
				throw new ArgumentException("Value cannot be negative.");
			}

			_y = value;
		}
	}

	public static Vector2d operator +(Vector2d a, Vector2d b)
	{
		var obj = new Vector2d
		{
			X = a.X + b.X,
			Y = a.Y + b.Y
		};

		return obj;
	}

	public bool Equals(Vector2d other)
	{
		return X == other.X && Y == other.Y;
	}

	public int CompareTo(object? obj)
	{
		if (obj is not Vector2d vector2d)
		{
			throw new InvalidOperationException("Can't compare different types.");
		}

		var h1 = Math.Pow(X, 2) + Math.Pow(Y, 2);
		var h2 = Math.Pow(vector2d.X, 2) + Math.Pow(vector2d.Y, 2);

		if (h1 > h2)
		{
			return 1;
		}

		if (h1 < h2)
		{
			return -1;
		}

		return 0;
	}
}

public readonly ref struct Point
{
	public int X { get; init; }
	public int Y { get; init; }
}

// record Account(int Id, string Login, string Password); // positioning record

record Account
{
	public int Id { get; set; }
	public required string Login { get; set; }
	public required string Password { get; set; }
}