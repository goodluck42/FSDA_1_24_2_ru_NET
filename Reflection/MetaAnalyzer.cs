using System.Reflection;
using System.Text;

namespace Reflection;

public class MetaAnalyzer
{
	public void Analyze<T>()
		where T : class
	{
		Type type = typeof(T);

		var attributes = type.GetCustomAttributes(false);

		if (!HasMetaAttribute<MetaClassAttribute>(attributes))
		{
			return;
		}

		CreateClassFolder(type.Name);
		CreateMemberFiles(type.Name, FilterMethods(type.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)));
		CreateMemberFiles(type.Name, FilterFields(type.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)));
	}

	private void CreateClassFolder(string name)
	{
		Directory.CreateDirectory(name);
	}

	private List<MethodInfo> FilterMethods(MethodInfo[] methods)
	{
		var filteredMethods = new List<MethodInfo>();

		foreach (var method in methods)
		{
			var attributes = method.GetCustomAttributes(false);

			if (!HasMetaAttribute<MetaMemberAttribute>(attributes))
			{
				continue;
			}

			filteredMethods.Add(method);
		}

		return filteredMethods;
	}

	private List<FieldInfo> FilterFields(FieldInfo[] fields)
	{
		var filteredFields = new List<FieldInfo>();

		foreach (var field in fields)
		{
			var attributes = field.GetCustomAttributes(false);

			if (!HasMetaAttribute<MetaMemberAttribute>(attributes))
			{
				continue;
			}

			filteredFields.Add(field);
		}

		return filteredFields;
	}

	private bool HasMetaAttribute<TAttribute>(object[] attributes)
		where TAttribute : MetaAttribute
	{
		foreach (var attribute in attributes)
		{
			if (attribute is TAttribute)
			{
				return true;
			}
		}

		return false;
	}

	private void CreateMemberFiles(string dir, List<MethodInfo> methods)
	{
		var stringBuilder = new StringBuilder();

		foreach (var method in methods)
		{
			stringBuilder.AppendLine($"Return type: {method.ReturnType.Name}");

			var @params = method.GetParameters();
			int paramNumber = 0;

			foreach (var param in @params)
			{
				stringBuilder.AppendLine($"[{paramNumber++}] {param.ParameterType.Name} {param.Name}");
			}

			File.WriteAllText($"{dir}/{method.Name}.method", stringBuilder.ToString());

			stringBuilder.Clear();
		}
	}

	private void CreateMemberFiles(string dir, List<FieldInfo> fields)
	{
		var stringBuilder = new StringBuilder();

		foreach (var field in fields)
		{
			stringBuilder.AppendLine($"Field type: {field.FieldType.Name}");
			stringBuilder.AppendLine($"Field name: {field.Name}");

			File.WriteAllText($"{dir}/{field.Name}.field", stringBuilder.ToString())
				;

			stringBuilder.Clear();
		}
	}
}