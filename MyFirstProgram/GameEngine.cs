using MyFirstProgram.Models;

namespace MyFirstProgram
{
    internal class GameEngine
    {
        internal void DivisionGame(string message)
        {
            Console.Clear();
            Console.Write(message);
            var score = 0;
            for (int i = 0; i < 5; i++)
            {
                var divisionNumbers = Helpers.GetDivisionNumbers();
                var firstNumber = divisionNumbers[0];
                var secondNumber = divisionNumbers[1];

                Console.WriteLine($"{firstNumber} / {secondNumber}");
                var result = Console.ReadLine();
                result = Helpers.ValidateResult(result);
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

            Helpers.AddToHistory(score, GameType.Division);
        }

        internal void MultiplicationGame(string message)
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
                var result = Console.ReadLine();
                result = Helpers.ValidateResult(result);
                int sum = firstNumber * secondNumber;
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

            Helpers.AddToHistory(score, GameType.Multiplication);
        }

        internal void SubtractionGame(string message)
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
                var result = Console.ReadLine();
                result = Helpers.ValidateResult(result);
                int sum = firstNumber - secondNumber;
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

            Helpers.AddToHistory(score, GameType.Subtraction);
        }

        internal void AdditionGame(string message)
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

                Console.WriteLine($"What is {firstNumber} + {secondNumber}?");
                var result = Console.ReadLine();
                result = Helpers.ValidateResult(result);
                int sum = firstNumber + secondNumber;
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

            Helpers.AddToHistory(score, GameType.Addition);

        }


    }
}
