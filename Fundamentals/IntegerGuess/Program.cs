using System;

namespace IntegerGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numberGenerator = new Random();

            int randomInteger = numberGenerator.Next(-100, 101);
            int userValidatedGuess;
            Console.WriteLine(randomInteger);

            while (true)
            {
                ChangeFontColor("white");
                Console.WriteLine("Guess the random number between -100 and 100.");
                Console.Write("Enter your guess: ");
                string userGuess = Console.ReadLine();
                Console.WriteLine();

                if (int.TryParse(userGuess, out userValidatedGuess))
                {
                    if (userValidatedGuess == randomInteger)
                    {
                        ChangeFontColor("green");
                        Console.WriteLine("You guessed the right number!");
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
                    Console.WriteLine("Invalid input! You must enter a number.");
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
