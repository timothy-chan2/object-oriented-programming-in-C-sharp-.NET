using System;

namespace ArraySum
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter the length of the array: ");
                string arrayLengthString = Console.ReadLine();

                if (int.TryParse(arrayLengthString, out int arrayLength) && arrayLength > 0)
                {
                    int arrayIndex = 0;
                    int[] userArray = new int[arrayLength];

                    Console.WriteLine();

                    while (true)
                    {
                        Console.Write($"Enter the integer at index {arrayIndex}: ");
                        string arrayElementString = Console.ReadLine();

                        if (int.TryParse(arrayElementString, out int arrayElement))
                        {
                            userArray[arrayIndex] = arrayElement;
                            arrayIndex++;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input! You must enter an integer.");
                        }

                        if (arrayIndex > arrayLength - 1)
                        {
                            break;
                        }
                    }

                    Console.WriteLine();
                    SumOfArray(userArray);

                    Console.ReadLine();
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input! You must enter a positive integer.");
                }
            }
        }

        static void SumOfArray(int[] arrayOfInts)
        {
            int sum = 0;
            
            for (int i = 0; i < arrayOfInts.Length; i++)
            {
                sum += arrayOfInts[i];
            }

            Console.WriteLine($"The sum of the array is {sum}.");
        }
    }
}
