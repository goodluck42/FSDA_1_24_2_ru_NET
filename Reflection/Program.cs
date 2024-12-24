using System.Reflection;
using Reflection;
//
// var obj = new MyObject();
//
// Type objType = typeof(MyObject); // obj.GetType();
//
// FieldInfo? fieldInfo = objType.GetField("_privateField", BindingFlags.Instance | BindingFlags.NonPublic);
//
// if (fieldInfo is null)
// {
// 	Console.WriteLine("_privateField not found");
// 	return;
// }
//
// fieldInfo.SetValue(obj, 1337);
//
// int value = (int)fieldInfo.GetValue(obj)!;
//
// Console.WriteLine(value);
//
// // Console.WriteLine(fieldInfo.IsPrivate);
//

var metaAnal = new MetaAnalyzer();

metaAnal.Analyze<MyObject>();