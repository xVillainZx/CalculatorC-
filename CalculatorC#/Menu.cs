namespace CalculatorC_
{
    internal class Menu
    {
        GameEngine gameEngine = new();
        internal void ShowMenu(string name, DateTime date)
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine($"Hello {name}! It's {date}. this is your math game. Thats great that you're improving yourself!\n");
            Console.ReadLine();

            var isGameOn = true;
            do
            {
                Console.WriteLine($@"what game mode would you like to play today? Choose from the options below:
v - View previous games
a - Addition
s - Subtraction
m - Multiplication
d - Division
q - Quit the program :(");
                Console.WriteLine("-----------------------------------------------");

                var gameSelected = Console.ReadLine();

                switch (gameSelected.Trim().ToLower())
                {
                    case "v":
                        Helpers.PrintGames();
                        break;
                    case "a":
                        gameEngine.AdditionGameMode("Addition game mode.");
                        break;
                    case "s":
                        gameEngine.SubtractionGameMode("Subtraction game mode.");
                        break;
                    case "m":
                        gameEngine.MultiplicationGameMode("Multiplication game mode.");
                        break;
                    case "d":
                        gameEngine.DivisionGameMode("Division game mode.");
                        break;
                    case "q":
                        Console.WriteLine("Goodbye.");
                        isGameOn = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            } while (isGameOn);
        }
    }
}
