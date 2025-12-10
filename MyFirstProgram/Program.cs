Console.WriteLine("Please type your name:");

var name = Console.ReadLine();
var date = DateTime.Now;

Console.WriteLine("-------------------------------");
Console.WriteLine($"Hello, {name}. It's {date.DayOfWeek}. This is your math game.");
Console.WriteLine($@"What game would you like to play today? Choose from the options below:
A - Addition
S - Subtraction
M - Multiplication
D - Division
Q - Quit the program");
Console.WriteLine("-------------------------------");
var gameSelected = Console.ReadLine();

if (gameSelected.ToUpper().Trim() == "A")
{
    AdditionGame("You chose Addition");
}
else if (gameSelected.ToUpper().Trim() == "S")
{
    SubtractionGame("You chose Subtraction");
}
else if (gameSelected.ToUpper().Trim() == "M")
{
    MultiplicationGame("You chose Multiplication");
}
else if (gameSelected.ToUpper().Trim() == "D")
{
    DivisionGame("You chose Division");
}
else if (gameSelected.ToUpper().Trim() == "Q")
{
    Console.WriteLine("You chose to Quit. Goodbye!");
    Environment.Exit(1);
}
else
{
    Console.WriteLine("Invalid choice. Please restart the program and choose a valid option.");
}

void DivisionGame(string message)
{
    Console.WriteLine(message);
}

void MultiplicationGame(string message)
{
    Console.WriteLine(message);
}

void SubtractionGame(string message)
{
    Console.WriteLine(message);
}

void AdditionGame(string message)
{
    Console.WriteLine(message);
}