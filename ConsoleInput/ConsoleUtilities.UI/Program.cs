using System;
using ConsoleUtilities.BLL;

namespace ConsoleUtilities.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = UserInput.GetIntFromUser("Enter your age: ");

            Console.WriteLine($"You are {age} years old.");
            Console.ReadLine();
        }
    }
}
