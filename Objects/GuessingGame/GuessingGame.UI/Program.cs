using GuessingGame.BLL;
using System;

namespace GuessingGame.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            GameFlow game = new GameFlow();
            game.PlayGame();
        }

        public class ConsoleInput
        {
            public static int GetIntFromUser(string prompt)
            {
                bool first = true;
                int result;
                string userInput;

                do
                {
                    if (!first)
                    {
                        Console.WriteLine("Invalid input!");
                    }

                    first = false;

                    Console.Write(prompt);
                    userInput = Console.ReadLine();
                } while (!int.TryParse(userInput, out result));

                return result;
            }

            public static int GetGuessFromUser()
            {
                Console.Clear();
                int integerGuess = GetIntFromUser($"Enter a guess between {GameManager.MinGuess} and {GameManager.MaxGuess}: ");

                return integerGuess;
            }
        }

        public class ConsoleOutput
        {
            public static void PressKeyToContinue(string prompt = "Press any key to continue...")
            {
                Console.WriteLine(prompt);
                Console.ReadKey();
            }
            
            public static void DisplayTitle()
            {
                Console.Clear();
                Console.WriteLine("The Guessing Integer Number Game\n");
                PressKeyToContinue("Press any key to start the game...");
            }

            public static void DisplayGuessMessage(GuessResult result)
            {
                string message = String.Empty;

                switch (result)
                {
                    case GuessResult.Invalid:
                        message = $"Your guess is invalid as it is not in the range {GameManager.MinGuess} to {GameManager.MaxGuess}.";
                        break;
                    case GuessResult.Higher:
                        message = $"Your guess too low.";
                        break;
                    case GuessResult.Lower:
                        message = $"Your guess too high.";
                        break;
                    case GuessResult.Equal:
                        message = $"You guessed the right number!";
                        break;
                }

                Console.WriteLine(message);
                PressKeyToContinue();
            }
        }

        public class GameFlow
        {
            GameManager _manager;

            public void PlayGame()
            {
                CreateManagerInstance();
                ConsoleOutput.DisplayTitle();

                GuessResult result;

                do
                {
                    int guess = ConsoleInput.GetGuessFromUser();
                    result = _manager.ProcessGuess(guess);
                    ConsoleOutput.DisplayGuessMessage(result);
                } while (result != GuessResult.Equal);
            }

            private void CreateManagerInstance()
            {
                _manager = new GameManager();
                _manager.Start();
            }
        }
    }
}
