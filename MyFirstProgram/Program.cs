var date = DateTime.Now;
string name = GetName();


Menu(name, date);

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

    var random = new Random();
    int firstNumber = random.Next(1, 9);
    int secondNumber = random.Next(1, 9);

    Console.WriteLine($"What is {firstNumber} + {secondNumber}?");
    var answer = Console.ReadLine();
    int sum = firstNumber + secondNumber;
    if (int.Parse(answer) == sum)
    {
        Console.WriteLine("Correct! Well done.");
    }
    else
    {
        Console.WriteLine($"Incorrect. The correct answer is {sum}.");
    }
}

void Menu(string name, DateTime date)
{
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

    switch (gameSelected.Trim().ToUpper())
    {
        case "A":
            AdditionGame("You have selected the Addition Game.");
            break;
        case "S":
            SubtractionGame("You have selected the Subtraction Game.");
            break;
        case "M":
            MultiplicationGame("You have selected the Multiplication Game.");
            break;
        case "D":
            DivisionGame("You have selected the Division Game.");
            break;
        case "Q":
            Console.WriteLine("Thank you for playing. Goodbye!");
            break;
        default:
            Console.WriteLine("Invalid selection. Please restart the program and choose a valid option.");
            break;
    }
}

string GetName()
{
    Console.WriteLine("Please type your name:");

    var name = Console.ReadLine();
    return name;
}