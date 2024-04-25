using System;

namespace FactorsOfTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer: ");
            string userInput = Console.ReadLine();

            while (true)
            {
                if (int.TryParse(userInput, out int input))
                {
                    Console.WriteLine($"The factors of {input} are:");

                    
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. You must enter an integer number.");
                    Console.Write("Enter an integer: ");
                    userInput = Console.ReadLine();
                }
            }
            Console.ReadLine();
        }
    }
}
