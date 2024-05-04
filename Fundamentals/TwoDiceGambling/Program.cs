using System;

namespace TwoDiceGambling
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

            
                Console.Write("How many dollars do you want to bet? ");
                string userBalanceString = Console.ReadLine();

                if (int.TryParse(userBalanceString, out int userBalance))
                {
                    if (userBalance > 0)
                    {
                        Random rng = new Random();
                        int rollCounter = 0;
                        int diceOneRoll, diceTwoRoll;

                        while (userBalance > 0)
                        {
                            diceOneRoll = rng.Next(1, 7);
                            diceTwoRoll = rng.Next(1, 7);
                            rollCounter++;

                            if (diceOneRoll + diceTwoRoll == 7)
                            {
                                userBalance += 4;
                            }
                            else
                            {
                                userBalance--;
                            }
                        }

                        Console.WriteLine($"Your money was depleted after {rollCounter} rolls.");

                        Console.ReadLine();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                        Console.WriteLine("You must enter a positive integer.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                    Console.WriteLine("You must enter a positive integer.");
                }
            }
        }
    }
}
