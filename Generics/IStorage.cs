namespace Generics;

public interface IStorage<TModel>
	where TModel : ISerializable
{
	void Add(TModel model);
}

// public class StringStorage : IStorage<string>
// {
// 	
// }