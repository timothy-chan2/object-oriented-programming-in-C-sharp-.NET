using System;

namespace StarshipMadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            string noun1, noun2;
            string pluralNoun1, pluralNoun2, pluralNoun3;
            string adjective1, adjective2;
            int number;
            string verbPresentTense, sameVerbButPastTense;

            Console.WriteLine("Let\'s play Starship Mad Libs!\n");
            Console.Write("A noun starting with a capital letter: ");
            noun1 = Console.ReadLine();

            Console.Write("An adjective: ");
            adjective1 = Console.ReadLine();

            Console.Write("A different noun with a capital letter: ");
            noun2 = Console.ReadLine();

            Console.Write("A number: ");
            number = Convert.ToInt32(Console.ReadLine());

            Console.Write("A different adjective: ");
            adjective2 = Console.ReadLine();

            Console.Write("A plural noun: ");
            pluralNoun1 = Console.ReadLine();

            Console.Write("A second plural noun: ");
            pluralNoun2 = Console.ReadLine();

            Console.Write("A third plural noun: ");
            pluralNoun3 = Console.ReadLine();

            Console.Write("A verb in present tense: ");
            verbPresentTense = Console.ReadLine();

            Console.Write("The same verb but in past tense: ");
            sameVerbButPastTense = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine($"{noun1}: the {adjective1} frontier. These are the voyages of the starship {noun2}. Its {number}-year mission: to explore strange {adjective2} {pluralNoun1}, to seek out {adjective2} {pluralNoun2} and {adjective2} {pluralNoun3}, to boldly {verbPresentTense} where no one has {sameVerbButPastTense} before.");
            Console.ReadLine();
        }
    }
}
