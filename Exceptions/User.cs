namespace Exceptions;

class User
{
	public const int MaxLoginLength = 9;

	private string? _login;

	public string MyLogin
	{
		get => _login ?? throw new UninitializedMemberException(nameof(MyLogin));
		set
		{
			if (value.Length > MaxLoginLength)
			{
				throw new ArgumentException("Parameter exceeded max length.", nameof(value));
			}

			_login = value;
		}
	}

	public string? Password { get; set; }
	public DateTime LastLogin { get; set; }
}