namespace MyFirstProgram
{
    internal class Menu
    {
        GameEngine gameEngine = new();
        internal void ShowMenu(string name, DateTime date)
        {

            Console.Clear();
            Console.WriteLine($"Hello {name.ToUpper()}. It's {date.DayOfWeek}. This is a really stupid math game. Imagine playing this garbage. Also fuck you Zach.\n");
            Console.WriteLine("Press any key to show menu");
            Console.ReadLine();
            Console.WriteLine("\n");


            bool isGameOn = true;

            do
            {
                Console.Clear();
                Console.WriteLine(@"
What game would you like to play today? Ch0ose from the options below:
V- View Previous Games
A - Addition
S - Subtraction
M - Multiplication
D - Division
Q - Quit the program");

                Console.WriteLine("----------------------------------------");

                var gameSelected = Console.ReadLine().ToLower().Trim();

                switch (gameSelected)
                {
                    case "v":
                        Helpers.PrintGames();
                        break;
                    case "a":
                        gameEngine.AdditionGame("Addition game");
                        break;
                    case "s":
                        gameEngine.SubtractionGame("Subtraction game");
                        break;
                    case "m":
                        gameEngine.MultiplicationGame("Multiplication game");
                        break;
                    case "d":
                        gameEngine.DivisionGame("Division game");
                        break;
                    case "q":
                        Console.WriteLine("Goodbye");
                        isGameOn = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            } while (isGameOn);


        }
    }
}
