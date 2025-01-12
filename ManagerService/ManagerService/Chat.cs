namespace ManagerService;

public class Chat
{
	private List<string> _messages = [];

	public void SendMessage(string message)
	{
		_messages.Add(message);
	}
	
	public IEnumerable<string> GetMessages() => _messages;
}