using System.Text;
using ClassesAndObjects;
// using A;
// using B;

// var builder = new StringBuilder();
// // ! - null forgiving
// var name = Console.ReadLine()!;
//
// builder.AppendFormat("Hello, {0}", name);
//
// var result = builder.ToString();
//
// Console.WriteLine(result);

var accountManager = new AccountManager(5);

var acc = new Account
{
	Login = "admin", // SET
	Password = "admin" // SET
};

Console.WriteLine(acc.Login); // GET

accountManager.AddAccount(acc);
accountManager.AddAccount(new Account
{
	Login = "admin2",
	Password = "admin2"
});

var accounts = accountManager.GetAccounts();

foreach (var account in accounts)
{
	Console.WriteLine(account.Login);
	Console.WriteLine(account.Password);
}

Console.WriteLine(AccountManager.DefaultMaxAccounts);


// var boba = new B.Boba();
//
// // CRUD
//
// namespace A
// {
// 	class Boba {}
// }
//
// namespace B
// {
// 	class Boba
// 	{
// 	}
// }

static void Foo()
{
	
}