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

            Console.WriteLine("Guess the random number between -100 and 100.");
            Console.Write("Enter your guess: ");
            string userGuess = Console.ReadLine();
            Console.WriteLine();

            if (int.TryParse(userGuess, out userValidatedGuess))
            {
                if (userValidatedGuess == randomInteger)
                {
                    Console.WriteLine("You guessed the right number!");
                }
                else if (userValidatedGuess < randomInteger)
                {
                    Console.WriteLine("Too low. You have have one more guess.");
                    Console.Write("Enter your guess: ");
                    userGuess = Console.ReadLine();
                    Console.WriteLine();

                    if (int.TryParse(userGuess, out userValidatedGuess))
                    {
                        if (userValidatedGuess == randomInteger)
                        {
                            Console.WriteLine("You guessed the right number!");
                        }
                        else
                        {
                            Console.WriteLine("You guessed wrong. Game over!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input! You must enter a number.");
                    }
                }
                else
                {
                    Console.WriteLine("Too high. You have have one more guess.");
                    Console.Write("Enter your guess: ");
                    userGuess = Console.ReadLine();
                    Console.WriteLine();

                    if (int.TryParse(userGuess, out userValidatedGuess))
                    {
                        if (userValidatedGuess == randomInteger)
                        {
                            Console.WriteLine("You guessed the right number!");
                        }
                        else
                        {
                            Console.WriteLine("You guessed wrong. Game over!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input! You must enter a number.");
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid input! You must enter a number.");
            }
            Console.ReadLine();
        }
    }
}
