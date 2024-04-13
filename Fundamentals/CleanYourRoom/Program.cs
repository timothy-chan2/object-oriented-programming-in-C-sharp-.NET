using System;

namespace CleanYourRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            int timesRepeated = 1;
            double chanceOfCleaningTheRoom = 0.0;
            double increaseInChanceOfCleaning;
            Random numberGenerator = new Random();

            do
            {
                Console.WriteLine($"Request to clean your room is expressed! (x{timesRepeated})");
                timesRepeated++;

                increaseInChanceOfCleaning = numberGenerator.NextDouble() * ((25 - 10) + 10) / 100;
                chanceOfCleaningTheRoom += increaseInChanceOfCleaning;
            } while (chanceOfCleaningTheRoom < 1.0 && timesRepeated < 9);

            Console.WriteLine("Acknowledged. I will proceed with cleaning my room.");
            Console.ReadLine();
        }
    }
}
