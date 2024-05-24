using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactList.UI
{
    public class UserIO
    {
        public string ReadString(string prompt)
        {
            string userInput = "";

            while (userInput == "")
            {
                Console.WriteLine(prompt);
                userInput = Console.ReadLine().Trim();

                if (userInput == "")
                {
                    Console.WriteLine("Invalid input!");
                }
            }

            return userInput;
        }

        public int ReadInt(string prompt, int min, int max)
        {
            int output;

            while (true)
            {
                Console.WriteLine(prompt);
                string userInput = Console.ReadLine();

                if (int.TryParse(userInput, out output))
                {
                    if (output >= min && output <= max)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"The number is outside of the range {min} to {max}.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input! Please enter an integer.");
                }
            }
            return output;
        }
    }
}
