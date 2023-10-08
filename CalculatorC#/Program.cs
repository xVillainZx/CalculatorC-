using System.Threading.Channels;

Console.WriteLine("Please type your name");

var name = Console.ReadLine();
var date = DateTime.UtcNow;

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

if (gameSelected == "a")
{
    Console.WriteLine("Addition game mode selected.");
}
else if (gameSelected == "s")
{
    Console.WriteLine("Subtraction game mode selected.");
}
else if (gameSelected == "m")
{
    Console.WriteLine("Multiplication game mode selected.");
}
else if (gameSelected == "d")
{
    Console.WriteLine("Division game mode selected.");
}
else
{
    Console.WriteLine("Goodbye ;)")
    Environment.Exit(1);
}
Console.ReadLine();
