Console.WriteLine("Hello World!");

// static ctor
// StaticClass.StaticProperty = 50;

// static class StaticClass
// {
// 	static StaticClass()
// 	{
// 		Console.WriteLine("StaticConstructor");
//
// 		StaticProperty = 42;
// 	}
//
// 	public static int StaticProperty
// 	{
// 		get;
// 		set;
// 	}
//
// 	public static void StaticMethod()
// 	{
// 		Console.WriteLine("StaticMethod");
// 	}
// }

var user = new User();

if (user.MyLogin.Length > User.MaxLoginLength)
{
}

// Console.WriteLine(user.MyLogin.Length);

// if (user.Login != null)
// {
// 	Console.WriteLine(user.Login.Length);
// }


class User
{
	public const int MaxLoginLength = 42;

	private string? _login;

	public string MyLogin
	{
		get
		{
			if (_login == null)
			{
				throw new UninitializedMemberException(nameof(MyLogin));
			}

			return _login;
		}
		set => _login = value;
	}

	public string? Password { get; set; }
	public DateTime LastLogin { get; set; }
}


class UninitializedMemberException : Exception
{
	private const string DefaultMessage = "Member {0} is uninitialized.";
	
	public UninitializedMemberException(string name) : base(string.Format(DefaultMessage, name))
	{
	}

	public UninitializedMemberException(string name, Exception? innerException) : base(
		string.Format(DefaultMessage, name), innerException)
	{
	}
}