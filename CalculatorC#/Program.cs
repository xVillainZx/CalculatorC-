using System.ComponentModel.Design;

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
    Console.WriteLine($"Hello {name}! It's {date}. this is your math game. Thats great that you're improving yourself\n");
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
            AdditionGameMode("Addition game mode selected.");
            break;
        case "b":
            SubtractionGameMode("Subtraction game mode selected.");
            break;
        case "m":
            MultiplicationGameMode("Multiplication game mode selected.");
            break;
        case "d":
            DivisionGameMode("Division game mode selected.");
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
}

void DivisionGameMode(string message)
{
    Console.WriteLine(message);
}

void MultiplicationGameMode(string message)
{
    Console.WriteLine(message);
}

void SubtractionGameMode(string message)
{
    Console.WriteLine(message);
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
        firstNumber = random.Next(1, 9);
        secondNumber = random.Next(1, 9);

        Console.WriteLine($"{firstNumber} + {secondNumber}");
        var result = Console.ReadLine();

        if (int.Parse(result) == firstNumber + secondNumber)
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.WriteLine("Incorrect.");
        }
        if (i == 4) Console.WriteLine($"Your final score is {score}");
    }
}