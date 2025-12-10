Console.WriteLine("Please type your name:");

var name = Console.ReadLine();
var date = DateTime.Now;

Console.WriteLine("-------------------------------");
Console.WriteLine($"Hello, {name.ToUpper()}. It's {date.DayOfWeek}. This is your math game.");
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
    Console.WriteLine("You chose Addition!");
}
else if (gameSelected.ToUpper().Trim() == "S")
{
    Console.WriteLine("You chose Subtraction!");
}
else if (gameSelected.ToUpper().Trim() == "M")
{
    Console.WriteLine("You chose Multiplication!");
}
else if (gameSelected.ToUpper().Trim() == "D")
{
    Console.WriteLine("You chose Division!");
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