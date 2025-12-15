
namespace MyFirstProgram
{
    internal class Menu
    {
        GameEngine engine = new();
        internal void ShowMenu(string name, DateTime date)
        {
            Console.Clear();
            Console.WriteLine("-------------------------------");
            Console.WriteLine($"Hello, {name}. It's {date.DayOfWeek}. This is your math game.\n");

            bool isGameOn = true;


            do
            {
                Console.Clear();
                Console.WriteLine($@"What game would you like to play today? Choose from the options below:
        V - View Previous Games
        A - Addition
        S - Subtraction
        M - Multiplication
        D - Division
        Q - Quit the program");
                Console.WriteLine("-------------------------------");
                var gameSelected = Console.ReadLine();

                switch (gameSelected.Trim().ToUpper())
                {
                    case "V":
                        Helpers.GetGames();
                        break;
                    case "A":
                        engine.AdditionGame("You have selected the Addition Game.\n");
                        break;
                    case "S":
                        engine.SubtractionGame("You have selected the Subtraction Game.\n");
                        break;
                    case "M":
                        engine.MultiplicationGame("You have selected the Multiplication Game.\n");
                        break;
                    case "D":
                        engine.DivisionGame("You have selected the Division Game.\n");
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

    }
}
