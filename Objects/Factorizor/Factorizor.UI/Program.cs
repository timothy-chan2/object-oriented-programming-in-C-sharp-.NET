using Factorizor.BLL;
using System;
using System.Collections.Generic;

namespace Factorizor.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkFlow factorizor = new WorkFlow();
            factorizor.StartProgram();
        }

        public class ConsoleInput
        {
            public static int GetPositiveIntFromUser(string prompt)
            {
                bool first = true;
                int integerUserInput;
                string userInput;

                do
                {
                    do
                    {
                        if (!first)
                        {
                            Console.WriteLine("Invalid input!");
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                        }

                        first = false;

                        Console.Write(prompt);
                        userInput = Console.ReadLine();
                    } while (!int.TryParse(userInput, out integerUserInput));
                } while (integerUserInput <= 0);

                return integerUserInput;
            }

            public static int GetIntegerInputFromUser()
            {
                Console.Clear();
                int validUserInput = GetPositiveIntFromUser("Enter an integer greater than 0: ");

                return validUserInput;
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
                Console.WriteLine("Welcome to Factorizor!\n\n");
                PressKeyToContinue("Press any key to start...");
            }

            public static void DisplayFactorResults(int input, int numberOfFactors, List<int> factors)
            {
                Console.WriteLine($"\nThe factors of {input} are:");
                for (int i = 0; i < numberOfFactors; i++)
                {
                    Console.Write($"{factors[i]} ");
                }

                Console.WriteLine($"\n{input} has {numberOfFactors} factors.");
            }

            public static void DisplayPerfectAndPrimeResults(int input, bool isPerfectNumber, bool isPrimeNumber)
            {
                string perfectNumberStatus, primeNumberStatus;

                if (isPerfectNumber)
                {
                    perfectNumberStatus = "is";
                }
                else
                {
                    perfectNumberStatus = "is not";
                }

                if (isPrimeNumber)
                {
                    primeNumberStatus = "is";
                }
                else
                {
                    primeNumberStatus = "is not";
                }

                Console.WriteLine($"{input} {perfectNumberStatus} a perfect number.");
                Console.WriteLine($"{input} {primeNumberStatus} a prime number.");
                Console.ReadLine();
            }
        }

        public class WorkFlow
        {
            FactorFinder _factorFinder;
            PerfectChecker _perfectChecker;
            PrimeChecker _primeChecker;

            public void StartProgram()
            {
                CreateBusinessLogicInstance();
                ConsoleOutput.DisplayTitle();

                int validInput = ConsoleInput.GetIntegerInputFromUser();
                List<int> factors = _factorFinder.CreateListOfFactors(validInput);
                int numberOfFactors = _factorFinder.numberOfFactors;

                bool isPerfectNumber = _perfectChecker.IsPerfectNumber(validInput, numberOfFactors, factors);
                bool isPrimeNumber = _primeChecker.IsPrimeNumber(validInput, numberOfFactors);

                ConsoleOutput.DisplayFactorResults(validInput, numberOfFactors, factors);
                ConsoleOutput.DisplayPerfectAndPrimeResults(validInput, isPerfectNumber, isPrimeNumber);
            }

            private void CreateBusinessLogicInstance()
            {
                _factorFinder = new FactorFinder();
                _perfectChecker = new PerfectChecker();
                _primeChecker = new PrimeChecker();
            }
        }
    }
}
