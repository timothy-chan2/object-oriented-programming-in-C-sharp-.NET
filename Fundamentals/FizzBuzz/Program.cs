using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentCount = 0;
            int countGoal;

            Console.Write("How many fizz and buzz do you want to see? ");
            string countGoalAsString = Console.ReadLine();

            if (int.TryParse(countGoalAsString, out countGoal))
            {
                int maxRange = countGoal * 5;

                for (int i = 0; i < maxRange; i++)
                {
                    if (i == 0)
                    {
                        Console.WriteLine(i);
                    }
                    else
                    {
                        if (i % 3 == 0 && i % 5 == 0)
                        {
                            Console.WriteLine("fizzbuzz");
                            currentCount++;
                        }
                        else if (i % 3 == 0)
                        {
                            Console.WriteLine("fizz");
                            currentCount++;
                        }
                        else if (i % 5 == 0)
                        {
                            Console.WriteLine("buzz");
                            currentCount++;
                        }
                        else
                        {
                            Console.WriteLine(i);
                        }

                        if (currentCount == countGoal)
                        {
                            break;
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("You entered an invalid input. You must enter a number.");
            }
            Console.ReadLine();
        }
    }
}
