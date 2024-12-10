namespace Exceptions;

class UninitializedMemberException : Exception
{
	private const string DefaultMessage = "Member {0} is uninitialized.";

	public UninitializedMemberException(string name) : base(string.Format(DefaultMessage, name))
	{
	}

	public UninitializedMemberException(string name, Exception? innerException) : base(
		string.Format(DefaultMessage, name), innerException)
	{
	}
}