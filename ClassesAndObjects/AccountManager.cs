namespace ClassesAndObjects;

public static class AccountManagerHelper
{
	static AccountManagerHelper()
	{
		Value = 42;
	}
	
	private static int _value;

	public static int Value
	{
		get => _value;
		set => _value = value;
	}

	public static void CheckIfIdIsNull(int id)
	{
		if (id == 0)
		{
			throw new ArgumentException("Id cannot be zero.");
		}
	}
}

public sealed class AccountManager
{
	public const int DefaultMaxAccounts = 15;
	private readonly List<Account> _accounts; 
	
	public AccountManager(int maxAccounts = DefaultMaxAccounts)
	{
		_accounts = new(maxAccounts);
		
		// List<Account> accounts1 = new();
		// List<Account> accounts2 = [];
		// var accounts3 = new List<Account>();
	}

	public void AddAccount(Account account)
	{
		AccountManagerHelper.CheckIfIdIsNull(account.Id);

		_accounts.Add(account);
	}
	
	public bool RemoveAccount(int id)
	{
		AccountManagerHelper.CheckIfIdIsNull(id);
		
		foreach (var account in _accounts)
		{
			if (account.Id == id)
			{
				_accounts.Remove(account);

				return true;
			}
		}

		return false;
	}
	
	public List<Account> GetAccounts() => _accounts;
}