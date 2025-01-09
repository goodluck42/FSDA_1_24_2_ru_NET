using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;


// var files = Directory.GetFiles(@"C:\Users\Alex\WebstormProjects\FSDA_Oct_24_2_ru_HTML\Animations");
//
// foreach (var filePath in files)
// {
// 	var fileStream = new FileStream(filePath, FileMode.Truncate);
// 	
// 	fileStream.Close();
// }

//// Write string
// using var fileStream = new FileStream("data.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
//
// var message = "Hello World!";
// var bytes = Encoding.UTF8.GetBytes(message);
//
// fileStream.Write(bytes);

//// Write int
// using var fileStream = new FileStream("data.bin", FileMode.OpenOrCreate, FileAccess.ReadWrite);
//
// int value = 42;
// var bytes = BitConverter.GetBytes(value);
//
// fileStream.Write(bytes);



//// read int
// using var fileStream = new FileStream("data.bin", FileMode.OpenOrCreate, FileAccess.ReadWrite);
//
// var buffer = new byte[sizeof(int)];
//
// while (true)
// {
// 	int read = fileStream.Read(buffer);
//
// 	if (read == 0)
// 	{
// 		break;
// 	}
// }
//
// var result = BitConverter.ToInt32(buffer);
//
// Console.WriteLine(result);

// Directory.CreateDirectory("folder");
// Path.GetExtension("data.bin");
// File.Delete("data.bin");
// 
// using var streamWriter = new StreamWriter(@"folder\data2.txt");
//
// streamWriter.Write(42);

// using var streamReader = new StreamReader(@"folder\data2.txt");
//
//
// while (true)
// {
// 	var line = streamReader.ReadLine(); 
// 	
// 	if (line is null)
// 	{
// 		break;
// 	}
// 	Console.WriteLine(line);
// }

//// JSON serialization
// List<Game> games =
// [
// 	new Game
// 	{
// 		Id = 1,
// 		Name = "Rust",
// 		Genres = ["survival", "open-world", "action"],
// 		Year = 2016
// 	},
// 	new Game
// 	{
// 		Id = 2,
// 		Name = "Team Fortress 2",
// 		Genres = ["test1", "test2"],
// 		Year = 2025
// 	}
// ];
//
// var json = JsonSerializer.Serialize(games, new JsonSerializerOptions()
// {
// 	WriteIndented = false
// });
//
// Console.WriteLine(json);
//
// using Stream fileStream = new FileStream("games.json", FileMode.Truncate, FileAccess.Write);
// using var streamWriter = new StreamWriter(fileStream);
//
// streamWriter.Write(json);


//// JSON deserialization

// using Stream fileStream = new FileStream("games.json", FileMode.Open, FileAccess.Read);
// using var streamReader = new StreamReader(fileStream);
//
// var json = streamReader.ReadToEnd();
//
// List<Game>? games = JsonSerializer.Deserialize<List<Game>>(json);
//
// if (games is null)
// {
// 	Console.WriteLine("No games found.");
// }
// else
// {
// 	foreach (var game in games)
// 	{
// 		Console.WriteLine(game.Id);
// 		Console.WriteLine(game.Name);
//
// 		foreach (var genre in game.Genres)
// 		{
// 			Console.WriteLine(genre);
// 		}
// 		
// 		Console.WriteLine(game.Year);
//
// 		Console.WriteLine(new string('-', 16));
// 	}
// }

//// JSON deserialization 2

// using var gameManager = new FileGameManager();
// var games = gameManager.GetGames();
//
// foreach (var game in games)
// {
// 	Console.WriteLine(game.Id);
// 	Console.WriteLine(game.Name);
//
// 	foreach (var genre in game.Genres)
// 	{
// 		Console.WriteLine(genre);
// 	}
// 		
// 	Console.WriteLine(game.Year);
//
// 	Console.WriteLine(new string('-', 16));
// }



var bytes = Encoding.UTF8.GetBytes("mypassword");
var hashedBytes = SHA256.HashData(bytes);

string hex = BitConverter.ToString(hashedBytes).Replace("-", string.Empty).ToLower();

Console.WriteLine(hex);

interface IGameManager
{
	void AddGame(Game game);
	IEnumerable<Game> GetGames();
}

class FileGameManager : IGameManager, IDisposable
{
	private readonly Stream _fileStream;
	private readonly StreamReader _streamReader;
	private const string FileName = "games.json";
	
	public FileGameManager()
	{
		_fileStream = new FileStream(FileName, FileMode.Open, FileAccess.Read);
		_streamReader = new StreamReader(_fileStream);
	}
	
	public void AddGame(Game game)
	{
		throw new NotImplementedException();
	}

	public IEnumerable<Game> GetGames()
	{
		var json = _streamReader.ReadToEnd();

		List<Game>? games = JsonSerializer.Deserialize<List<Game>>(json);

		if (games is null)
		{
			throw new InvalidOperationException("No games found.");
		}

		if (_streamReader.BaseStream.CanSeek)
		{
			_streamReader.BaseStream.Seek(0, SeekOrigin.Begin);
		}
		
		return games;
	}

	public void Dispose()
	{
		_fileStream.Dispose();
		_streamReader.Dispose();
		// using (_fileStream) {}
		// using (_streamReader) {}
	}
}


class Game
{
	public int Id { get; set; }
	public string Name { get; set; } = string.Empty;
	public string[] Genres { get; set; } = [];
	public int Year { get; set; }
}

