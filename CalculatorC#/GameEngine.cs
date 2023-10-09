using CalculatorC_.Models;
using static System.Formats.Asn1.AsnWriter;

namespace CalculatorC_
{
    internal class GameEngine
    {
       internal void DivisionGameMode(string message)
        {
            var score = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                var divisionNumbers = Helpers.GetDivisionNumbers();
                var firstNumber = divisionNumbers[0];
                var secondNumber = divisionNumbers[1];

                Console.WriteLine($"{firstNumber} / {secondNumber}");
                var result = Console.ReadLine();

                if (int.Parse(result) == firstNumber / secondNumber)
                {
                    Console.WriteLine("Correct! Press any key to continue.");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Incorrect. Press any key to continue.");
                    Console.ReadLine();
                }
                if (i == 4)
                {
                    Console.WriteLine($"Your final score is {score}! press any key to return to the main menu.");
                    Console.ReadLine();
                }
            }

            Helpers.AddToHistory(score, GameType.Division);
        }

       internal void MultiplicationGameMode(string message)
        {
            Console.WriteLine(message);
            var random = new Random();
            var score = 0;

            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);

                Console.WriteLine($"{firstNumber} * {secondNumber}");
                var result = Console.ReadLine();

                if (int.Parse(result) == firstNumber * secondNumber)
                {
                    Console.WriteLine("Correct! Press any key to continue.");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Incorrect. Press any key to continue.");
                    Console.ReadLine();
                }
                if (i == 4)
                {
                    Console.WriteLine($"Your final score is {score}! press any key to return to the main menu.");
                    Console.ReadLine();
                }
            }

            Helpers.AddToHistory(score, GameType.Multiplication);
        }

       internal void SubtractionGameMode(string message)
        {
            Console.WriteLine(message);
            var random = new Random();
            var score = 0;

            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);

                Console.WriteLine($"{firstNumber} - {secondNumber}");
                var result = Console.ReadLine();

                if (int.Parse(result) == firstNumber - secondNumber)
                {
                    Console.WriteLine("Correct! Press any key to continue.");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Incorrect. Press any key to continue.");
                    Console.ReadLine();
                }
                if (i == 4)
                {
                    Console.WriteLine($"Your final score is {score}! press any key to return to the main menu.");
                    Console.ReadLine();
                }
            }
            
            Helpers.AddToHistory(score, GameType.Subtraction);

        }

        internal void AdditionGameMode(string message)
        {
            Console.WriteLine(message);

            var random = new Random();
            var score = 0;

            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);

                Console.WriteLine($"{firstNumber} + {secondNumber}");
                var result = Console.ReadLine();

                if (int.Parse(result) == firstNumber + secondNumber)
                {
                    Console.WriteLine("Correct! Press any key to continue.");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Incorrect. Press any key to continue.");
                    Console.ReadLine();
                }
                if (i == 4)
                {
                    Console.WriteLine($"Your final score is {score}! press any key to return to the main menu.");
                    Console.ReadLine();
                }
            }

            Helpers.AddToHistory(score, GameType.Addition);
        }
    }
}
