using System;

namespace RandomShortStory
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numberGenerator = new Random();
            string color = RandomColor(numberGenerator);
            string animal = RandomAnimal(numberGenerator);
            string secondColor = RandomColor(numberGenerator);
            int weight = numberGenerator.Next(5, 200);
            int distance = numberGenerator.Next(10, 20);
            int number = numberGenerator.Next(10000, 20000);
            int time = numberGenerator.Next(2, 6);

            Console.WriteLine("Once, when I was very young...");

            Console.WriteLine($"I was chased by a {color}, {weight}lb miniature {animal} for over {distance} kilometers!");

            Console.WriteLine($"I had to hide in a field of over {number} {secondColor} flowers for nearly {time} hours until it left me alone!");

            Console.WriteLine($"\nIt was quite the experience, let me tell you!");
            Console.ReadLine();
        }

        public static string RandomColor(Random randomize)
        {
            string[] colors = new string[] { "red", "green", "blue", "yellow", "purple" };
            int randomColorIndex = randomize.Next(5);

            return colors[randomColorIndex];
        }

        public static string RandomAnimal(Random randomize)
        {
            string[] animals = new string[] { "tiger", "lion", "zebra", "giraffe", "buffalo" };
            int randomAnimalIndex = randomize.Next(5);

            return animals[randomAnimalIndex];
        }
    }
}
