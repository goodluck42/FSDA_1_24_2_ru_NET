using Inheritance;

char x = '\u1230';

double x2 = 2.0;

while (true)
{
	_ = Console.ReadKey();
	var rnd = GenerateTwoRandoms();

	Console.WriteLine($"{rnd.Item1} to {rnd.Item2}");
}


(int, int) GenerateTwoRandoms()
{
	const int min = 1, max = 10;

	var first = Random.Shared.Next(min, max);
	var second = Random.Shared.Next(min, max);

	if (first == second || first == 2 || first == 9 || second == 2 || second == 9)
	{
		return GenerateTwoRandoms();
	}

	return (first, second);
}


// var buttons = new List<Button>();

// buttons.Add(new LinuxButton(50, 20));
// buttons.Add(new WindowsButton(42, 9));

// WindowsButton wButton = new WindowsButton(50, 20);
// Console.WriteLine(wButton.GetClicked());

// foreach (var button in buttons)
// {
// 	button.Click();
// 	Console.WriteLine(button.GetClicked());
// }

void ShowButton(Button button)
{
	Console.WriteLine(button);
}

public abstract class Animal
{
	public abstract void Move();
}

public class Cat : Animal
{
	public override void Move()
	{
		Console.WriteLine("Cat is moving");
	}
}

public class Dog : Animal
{
	public override void Move()
	{
		Console.WriteLine("Dog is moving");
	}
}

public class Fish : Animal
{
	public override void Move()
	{
		Console.WriteLine("Fish is moving");
	}
}

public class Bird : Animal
{
	public override void Move()
	{
		Console.WriteLine("Bird is moving");
	}
}