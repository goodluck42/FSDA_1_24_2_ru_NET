using System.Reflection;
using System.Runtime.Loader;
using Calculator;

var assemblyLoadContext = new AssemblyLoadContext("AssemblyLoadContext", true);
using var fileStream = new FileStream("ManagerService.dll", FileMode.Open, FileAccess.Read);
var assembly = assemblyLoadContext.LoadFromStream(fileStream); // plugin

// class Chat; 
var chatType = assembly.GetType("ManagerService.Chat")!; // typeof(Chat);
var chatInstance = Activator.CreateInstance(chatType); // new Chat();

// chat.SendMessage("Helloy")
{
	var sendMessageMethodInfo = chatType.GetMethod("SendMessage", BindingFlags.Instance | BindingFlags.Public)!;
	var getMessagesMethodInfo = chatType.GetMethod("GetMessages", BindingFlags.Instance | BindingFlags.Public)!;
	
	sendMessageMethodInfo.Invoke(chatInstance, ["Hello world!"]); // chat.SendMessage("Hello world!");
	sendMessageMethodInfo.Invoke(chatInstance, ["Goodbye world!"]); // chat.SendMessage("Goodbye world!");


	var result = (List<string>)getMessagesMethodInfo.Invoke(chatInstance, null)!; // chat.GetMessages();

	// Console.WriteLine(result.GetType());
	
	foreach (var message in result)
	{
		Console.WriteLine(message);
	}
}

assemblyLoadContext.Unload();


// assemblyLoadContext.Unload();


// IMyCalculator calculator = new MyCalculator();
//
// Console.WriteLine(calculator.Subtract(52, 10));
//
// var am = new AccessModifiers();
	
// var o = new
// {
// 	Field1 = "Value1",
// 	Field2 = 42,
// };
//
// MySerialize(o);
//
// void MySerialize(object o)
// {
// 	var type = o.GetType();
//
// 	var props = type.GetProperties();
//
// 	foreach (var prop in props)
// 	{
// 		Console.WriteLine(prop.Name);
// 		Console.WriteLine(prop.GetValue(o));
// 	}
// 	
// 	// Console.WriteLine(o.Field1);
// 	// Console.WriteLine(o.Field2);
// }

// class AccessModifiers2 : AccessModifiers
// {
// 	public AccessModifiers2()
// 	{
// 		this.InternalProp = 42;
// 		this.ProtectedInternalProp = 42;
// 		this.PrivateProtectedProp = 42;
// 	}
// }