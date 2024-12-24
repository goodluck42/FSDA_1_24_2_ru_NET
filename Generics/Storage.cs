using System.Collections;

namespace Generics;

public class Storage<TModel> : IStorage<TModel>
	where TModel : ISerializable, new()
{
	private const string FileName = "data.bin";

	public Storage()
	{
		var instance = new TModel();
	}
	
	public void Add(TModel model)
	{
		var bytes = model.Serialize();
		
		File.WriteAllBytes(FileName, bytes);
	}
}