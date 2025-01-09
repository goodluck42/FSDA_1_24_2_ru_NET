using LINQ;

// Lang Integrated Queries



// var list = new List<int>();

// list.GetByIndex(0);
//
// var oList = new ObservableCollection<int>();
//
//
// oList.GetByIndex(0);
//
// var s = "hello";
//
// s.Capitalize(); // StringExtensions.Capitalize(s);



//////////////


// using LINQ;
//
// var list = new List<string>();
//
// var e1 = list.Append("biba");
// var e2 = e1.Append("boba");
// var e3 = e2.Append("Nigar");
//
// //e3.Print();
//
// EnumerableExtensions.Print(e3);
//
// Console.WriteLine(new string('-', 42));
//
// foreach (var item in list)
// {
// 	Console.WriteLine(item);
// }


IEnumerable<string> list = new List<string> { "foo", "bar", "baz", "Nigar", "Guseyn" };

//// First & FirstOrDefault, Last & LastOrDefault, Single & SingleOrDefault
// var firstElem = list.FirstOrDefault();
//
// if (firstElem is not null)
// {
// 	Console.WriteLine(firstElem);
// }
//
// try
// {
// 	var res = list.Single(x => x.StartsWith('b'));
// 	
// 	Console.WriteLine(res);
// }
// catch (InvalidOperationException)
// {
// 	Console.WriteLine("result is null");
// }

// var names = list.Where(x => char.IsUpper(x[0]));
//
// foreach (var name in names)
// {
// 	Console.WriteLine(name);
// }

//
// var names = list.MyWhere(x =>
// {
// 	Console.WriteLine(x);
//
// 	return char.IsUpper(x[0]);
// });
//
// foreach (var name in names)
// {
// 	Console.WriteLine("!");
// }


// var enumerable = EnumerableExtensions.YieldTest();
// var enumerator = enumerable.GetEnumerator();
//
// enumerator.MoveNext();
// Console.WriteLine(enumerator.Current);
//
// enumerator.MoveNext();
// Console.WriteLine(enumerator.Current);



//// All & Any

Console.WriteLine(list.Count());


// if (list.Count() == 0) // BAD
// {
// 	
// }

// if (list.Any()) // GOOD
// {
// 	
// }


// if (list.Any(x => x.StartsWith('B')))
// {
// 	Console.WriteLine("HAS B");
// }
// else
// {
// 	Console.WriteLine("HAS NO B");
// }
//
// if (list.All(x => char.IsAscii(x[0])))
// {
// 	Console.WriteLine("all starts with ascii");
// }

// Take & Skip 

// var list1 = list.Skip(2);
//
// list1.Print();

// var list2 = list.TakeWhile(x => x.Length == 3);
//
// list2.Print();

//// Select
var users = new List<User>
{
	new()
	{
		FirstName = "John",
		LastName = "Doe",
		Id = 1
	},
	new()
	{
		FirstName = "Jack",
		LastName = "Doe",
		Id = 2
	},
	new()
	{
		FirstName = "Joel",
		LastName = "Doe",
		Id = 3
	},
};

// var data = users.Select(x => new
// {
// 	x.Id, // Id = x.Id
// 	Name = x.FirstName
// });
//
// // SendToUser(socket);
//
// foreach (var user in data)
// {
// 	Console.WriteLine($"{user.Id}: {user.Name}");
// }


var names = users.Select(x => x.FirstName);

foreach (var name in names)
{
	Console.WriteLine(name);
}

class User
{
	public int Id { get; set; }
	public string? FirstName { get; set; }
	public string? LastName { get; set; }
}
