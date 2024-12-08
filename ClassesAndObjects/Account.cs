namespace ClassesAndObjects;

public sealed class Account
{
	private string? _login; // backing field

	public Account()
	{
		Password = string.Empty;
	}

	public Account(string login) : this(login, string.Empty)
	{
	}

	public Account(string login, string password)
	{
		Login = login;
		Password = password;
	}

	public int Id { get; set; }

	public string Login
	{
		get => _login ?? throw new InvalidOperationException("Login cannot be null.");
		set => _login = value;
	}

	public string Password { get; set; }
}