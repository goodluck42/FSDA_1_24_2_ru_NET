namespace Generics;

public interface ILocalStorage<TModel> : IEnumerable<TModel>
{
	void Add(TModel model);
}