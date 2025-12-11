using System.Threading.Tasks.Sources;

var date = DateTime.Now;
string name = GetName();


Menu(name, date);

void DivisionGame(string message)
{
    Console.Clear();
    Console.Write(message);
    var score = 0;
    for (int i = 0; i < 5; i++)
    {
        var divisionNumbers = GetDivisionNumbers();
        var firstNumber = divisionNumbers[0];
        var secondNumber = divisionNumbers[1];

        Console.WriteLine($"{firstNumber} / {secondNumber}");
        var result = Console.ReadLine();
        var sum = firstNumber / secondNumber;
        if (int.Parse(result) == sum)
        {
            Console.WriteLine("Correct! Well done. Type any key for the next question.");
            Console.ReadLine();
            score++;
        }
        else
        {
            Console.WriteLine($"Incorrect. The correct answer is {sum}. Type any key for the next question.");
            Console.ReadLine();
        }

        if (i == 4)
        {
            Console.WriteLine($"Game over! Your final score is {score}.");
        }
    }
}

void MultiplicationGame(string message)
{
    Console.Clear();
    Console.Write(message);

    var random = new Random();
    var score = 0;

    int firstNumber;
    int secondNumber;

    for (int i = 0; i < 5; i++)
    {
        firstNumber = random.Next(1, 51);
        secondNumber = random.Next(1, 51);

        Console.WriteLine($"What is {firstNumber} * {secondNumber}?");
        var answer = Console.ReadLine();
        int sum = firstNumber * secondNumber;
        if (int.Parse(answer) == sum)
        {
            Console.WriteLine("Correct! Well done. Type any key for the next question.");
            Console.ReadLine();
            score++;
        }
        else
        {
            Console.WriteLine($"Incorrect. The correct answer is {sum}. Type any key for the next question.");
            Console.ReadLine();
        }

        if (i == 4)
        {
            Console.WriteLine($"Game over! Your final score is {score}.");
        }
    }
}

void SubtractionGame(string message)
{
    Console.Clear();
    Console.Write(message);

    var random = new Random();
    var score = 0;

    int firstNumber;
    int secondNumber;

    for (int i = 0; i < 5; i++)
    {
        firstNumber = random.Next(1, 51);
        secondNumber = random.Next(1, 51);

        Console.WriteLine($"What is {firstNumber} - {secondNumber}?");
        var answer = Console.ReadLine();
        int sum = firstNumber - secondNumber;
        if (int.Parse(answer) == sum)
        {
            Console.WriteLine("Correct! Well done. Type any key for the next question.");
            Console.ReadLine();
            score++;
        }
        else
        {
            Console.WriteLine($"Incorrect. The correct answer is {sum}. Type any key for the next question.");
            Console.ReadLine();
        }

        if (i == 4)
        {
            Console.WriteLine($"Game over! Your final score is {score}.");
        }
    }
}

void AdditionGame(string message)
{
    Console.Clear();
    Console.Write(message);

    var random = new Random();
    var score = 0;

    int firstNumber;
    int secondNumber;

    for(int i=0; i < 5; i++)
    {
        firstNumber = random.Next(1, 51);
        secondNumber = random.Next(1, 51);

        Console.WriteLine($"What is {firstNumber} + {secondNumber}?");
        var answer = Console.ReadLine();
        int sum = firstNumber + secondNumber;
        if (int.Parse(answer) == sum)
        {
            Console.WriteLine("Correct! Well done. Type any key for the next question.");
            Console.ReadLine();
            score++;
        }
        else
        {
            Console.WriteLine($"Incorrect. The correct answer is {sum}. Type any key for the next question.");
            Console.ReadLine();
        }

        if (i == 4)
        {
            Console.WriteLine($"Game over! Your final score is {score}.");
        }
    }

}

void Menu(string name, DateTime date)
{
    Console.WriteLine("-------------------------------");
    Console.WriteLine($"Hello, {name}. It's {date.DayOfWeek}. This is your math game.\n");

    bool isGameOn = true;


    do
    {
        Console.Clear();
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
                isGameOn = false;
                break;
            default:
                Console.WriteLine("Invalid selection. Please choose a valid option.");
                break;
        }
    } while (isGameOn);
}

string GetName()
{
    Console.WriteLine("Please type your name:");

    var name = Console.ReadLine();
    return name;
}

int[] GetDivisionNumbers()
{
    var random = new Random();
    var firstNumber = random.Next(1, 99);
    var secondNumber = random.Next(1, 99);

    var result = new int[2];

    while (firstNumber % secondNumber != 0)
    {
        firstNumber = random.Next(1, 99);
        secondNumber = random.Next(1, 99);
        result[0] = firstNumber;
        result[1] = secondNumber;
    }

    result[0] = firstNumber;
    result[1] = secondNumber;

    return result;
}