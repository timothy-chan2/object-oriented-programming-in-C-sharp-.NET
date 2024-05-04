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
                        int[] maxUserBalanceData = { 0, userBalance };

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

                            if (userBalance > maxUserBalanceData[1])
                            {
                                maxUserBalanceData[0] = rollCounter;
                                maxUserBalanceData[1] = userBalance;
                            }
                        }

                        Console.WriteLine($"Your money was depleted after {rollCounter} rolls.");
                        Console.WriteLine($"You had the highest balance after {maxUserBalanceData[0]} rolls with {maxUserBalanceData[1]:C}.");

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
