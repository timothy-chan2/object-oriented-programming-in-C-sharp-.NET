using System;
using System.Collections.Generic;

namespace FactorsOfTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = RequestUserIntegerInput(false);

            while (true)
            {
                if (int.TryParse(userInput, out int input))
                {
                    if (input > 0)
                    {
                        int rangeMax = (int)Math.Sqrt(input);
                        int numberOfFactors;
                        List<int> factors = new List<int>();

                        for (int potentialFactor = 1; potentialFactor <= rangeMax; potentialFactor++)
                        {
                            if (input % potentialFactor == 0)
                            {
                                factors.Add(potentialFactor);
                                if (input / potentialFactor != potentialFactor)
                                {
                                    factors.Add(input / potentialFactor);
                                }
                            }
                        }
                        
                        factors.Sort();
                        numberOfFactors = factors.Count;

                        Console.WriteLine($"The factors of {input} are:");
                        for (int i = 0; i < numberOfFactors; i++)
                        {
                            Console.Write($"{factors[i]} ");
                        }
                        Console.WriteLine();

                        Console.WriteLine($"{input} has {numberOfFactors} factors.");

                        PerfectNumberCheck(input, numberOfFactors, factors);
                        PrimeNumberCheck(input, numberOfFactors);

                        break;
                    }
                    else
                    {
                        userInput = RequestUserIntegerInput(true);
                    }
                }
                else
                {
                    userInput = RequestUserIntegerInput(true);
                }
            }
            Console.ReadLine();
        }

        static string RequestUserIntegerInput(bool isRepeatedAttempt)
        {
            if (isRepeatedAttempt)
            {
                Console.WriteLine("Invalid input.");
            }
            
            Console.Write("Enter a positive integer greater than 0: ");
            string input = Console.ReadLine();

            return input;
        }

        static void PerfectNumberCheck(int userSelectedNumber, int countOfFactors, List<int> factorsOfNumber)
        {
            int sum = 0;
            string perfectNumberStatus;

            for (int i = 0; i < countOfFactors - 1; i++)
            {
                sum += factorsOfNumber[i];
            }

            if (sum == userSelectedNumber)
            {
                perfectNumberStatus = "is";
            }
            else
            {
                perfectNumberStatus = "is not";
            }

            Console.WriteLine($"{userSelectedNumber} {perfectNumberStatus} a perfect number.");
        }

        static void PrimeNumberCheck(int userSelectedNumber, int countOfFactors)
        {
            string primeNumberStatus;

            if (userSelectedNumber > 1 && countOfFactors == 2)
            {
                primeNumberStatus = "is";
            }
            else
            {
                primeNumberStatus = "is not";
            }

            Console.WriteLine($"{userSelectedNumber} {primeNumberStatus} a prime number.");
        }
    }
}
