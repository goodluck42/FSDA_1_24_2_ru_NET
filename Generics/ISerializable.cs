namespace Generics;

public interface ISerializable
{
	byte[] Serialize();
	// TObject Deserialize<TObject>();
}

// public interface IDeserializable<T>
// {
// 	T Deserialize(byte[] data);
// }