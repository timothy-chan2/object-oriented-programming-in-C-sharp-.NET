using System;

namespace IntegerGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numberGenerator = new Random();

            int randomInteger = numberGenerator.Next(-100, 101);
            int attemptCounter = 0;

            while (true)
            {
                ChangeFontColor("white");
                Console.WriteLine("Guess the random number between -100 and 100.");
                Console.WriteLine("Enter Q as the guess to exit the game.");
                Console.Write("Enter your guess: ");
                string userGuess = Console.ReadLine();
                Console.WriteLine();

                if (userGuess == "Q")
                {
                    Console.WriteLine($"You chose to exit the game after {attemptCounter} attempts.");
                    break;
                }

                if (int.TryParse(userGuess, out int userValidatedGuess))
                {
                    attemptCounter++;
                    
                    if (userValidatedGuess == randomInteger)
                    {
                        ChangeFontColor("green");
                        Console.WriteLine($"You guessed the right number after {attemptCounter} attempts!");
                        break;
                    }
                    else if (userValidatedGuess < randomInteger)
                    {
                        Console.WriteLine("Too low.");
                    }
                    else
                    {
                        Console.WriteLine("Too high.");
                    }
                }
                else
                {
                    ChangeFontColor("red");
                    Console.WriteLine("Invalid input! You must enter an integer.");
                }
            }
            
            Console.ReadLine();
        }

        static void ChangeFontColor(string newColor)
        {
            if (newColor == "white")
            {
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (newColor == "red")
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else if (newColor == "green")
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
        }
    }
}
