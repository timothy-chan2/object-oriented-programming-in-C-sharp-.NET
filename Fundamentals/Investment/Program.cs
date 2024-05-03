using System;

namespace Investment
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter the initial investment amount: ");
                string initialInvestmentString = Console.ReadLine();

                if (decimal.TryParse(initialInvestmentString, out decimal investmentBalance))
                {
                    if (investmentBalance > 0)
                    {
                        while (true)
                        {                     
                            Console.Write("Enter the number of years of investment: ");
                            string yearsOfInvestmentString = Console.ReadLine();

                            if (int.TryParse(yearsOfInvestmentString, out int yearsOfInvestment))
                            {
                                if (yearsOfInvestment > 0)
                                {
                                    while (true)
                                    {
                                        Console.Write("Enter the annual interest rate %: ");
                                        string annualInterestRateString = Console.ReadLine();

                                        if (int.TryParse(annualInterestRateString, out int annualInterestRate))
                                        {
                                            if (annualInterestRate > 0)
                                            {
                                                Console.WriteLine();
                                                Console.WriteLine("Calculating...");

                                                investmentBalance = decimal.Round(investmentBalance, 2);
                                                decimal quarterlyInterestRate = (decimal)(annualInterestRate / 4.0);

                                                for (int year = 1; year <= yearsOfInvestment; year++)
                                                {
                                                    decimal initialInvestmentBalance = investmentBalance;

                                                    Console.WriteLine($"Year {year}:");
                                                    Console.WriteLine($"Starting amount is {investmentBalance:C}");

                                                    for (int i = 0; i < 4; i++)
                                                    {
                                                        investmentBalance = investmentBalance * (1 + (quarterlyInterestRate / 100));
                                                    }

                                                    Console.WriteLine($"Gained {investmentBalance - initialInvestmentBalance:C}");
                                                    Console.WriteLine($"Ending amount is {investmentBalance:C}");
                                                    Console.WriteLine();
                                                }

                                                Console.ReadLine();
                                                break;
                                            }
                                            else
                                            {
                                                InvalidAnswerReminder("integer");
                                            }
                                        }
                                        else
                                        {
                                            InvalidAnswerReminder("integer");
                                        }
                                    }
                                    break;
                                }
                                else
                                {
                                    InvalidAnswerReminder("integer");
                                }
                            }
                            else
                            {
                                InvalidAnswerReminder("integer");
                            }
                        }
                        break;
                    }
                    else
                    {
                        InvalidAnswerReminder("number");
                    }
                }
                else
                {
                    InvalidAnswerReminder("number");
                }
            }
        }

        static void InvalidAnswerReminder(string correctType)
        {
            Console.WriteLine("Invalid input!");
            Console.WriteLine($"You must enter a positive {correctType}.");
        }
    }
}
