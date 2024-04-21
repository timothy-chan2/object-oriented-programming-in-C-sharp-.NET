using System;

namespace FindTheBolt
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] hidingSpots = new string[100];
            int numberOfHidingSpots = hidingSpots.Length;

            Random numberGenerator = new Random();
            int randomSpot = numberGenerator.Next(numberOfHidingSpots);
            hidingSpots[randomSpot] = "Bolt";

            Console.WriteLine("The bolt has been hidden.");
            Console.WriteLine("Searching...");

            for (int i = 0; i < numberOfHidingSpots; i++)
            {
                if (hidingSpots[i] == "Bolt")
                {
                    Console.WriteLine($"Location found. It's hidden at index {i}.");
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
