using System.ComponentModel.Design;
using System.Numerics;
using static System.Formats.Asn1.AsnWriter;

var date = DateTime.UtcNow;

string name = GetName();

Menu(name);

string GetName()
{
    Console.WriteLine("Please type your name");
    var name = Console.ReadLine();
    return name;
}

void Menu(string name)
{
    Console.WriteLine("-----------------------------------------------");
    Console.WriteLine($"Hello {name}! It's {date}. this is your math game. Thats great that you're improving yourself!\n");

    var isGameOn = true;
    {
        Console.WriteLine($@"what game mode would you like to play today? Choose from the options below:
a - Addition
s - Subtraction
m - Multiplication
d - Division
q - Quit the program :(");
        Console.WriteLine("-----------------------------------------------");

        var gameSelected = Console.ReadLine();

        switch (gameSelected.Trim().ToLower())
        {
            case "a":
                AdditionGameMode("Addition game mode.");
                break;
            case "s":
                SubtractionGameMode("Subtraction game mode.");
                break;
            case "m":
                MultiplicationGameMode("Multiplication game mode.");
                break;
            case "d":
                DivisionGameMode("Division game mode.");
                break;
            case "q":
                Console.WriteLine("Goodbye");
                Environment.Exit(1);
                break;
            default:
                Console.WriteLine("Invalid input please try one of the displayed letters.");
                Environment.Exit(1);
                break;
        }
    } while 
}

void DivisionGameMode(string message)
{
    for (int i = 0; i <5; i++)
    {
        Console.Clear();
        Console.WriteLine(message);

        var divisionNumbers = GetDivisionNumbers();
        var firstNumber = divisionNumbers[0];
        var secondNumber = divisionNumbers[1];
        var score = 0;

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
        if (i == 4) Console.WriteLine($"Your final score is {score}");
    }

}

void MultiplicationGameMode(string message)
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
        if (i == 4) Console.WriteLine($"Your final score is {score}");
    }
}

void SubtractionGameMode(string message)
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
        if (i == 4) Console.WriteLine($"Your final score is {score}");
    }
}

void AdditionGameMode(string message)
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
        if (i == 4) Console.WriteLine($"Your final score is {score}");
    }
}

int[] GetDivisionNumbers()
{
    var random = new Random();
    var firstNumber = random.Next(0, 99);
    var secondNumber = random.Next(0, 99);

    var result = new int[2];

    while (firstNumber % secondNumber != 0)
    {
        firstNumber = random.Next(1, 99);
        secondNumber = random.Next(1, 99);
    }

    result[0] = firstNumber;
    result[1] = secondNumber;

    Console.WriteLine(result);

    return result;
}