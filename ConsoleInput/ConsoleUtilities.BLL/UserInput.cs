using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUtilities.BLL
{
    public class UserInput
    {
        public static int GetIntFromUser(string prompt)
        {
            bool isFirstAttempt = true;
            string userInputString;
            int IntUserInput;

            do
            {
                if (isFirstAttempt)
                {
                    isFirstAttempt = false;
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

                Console.Write(prompt);
                userInputString = Console.ReadLine();
            } while (!int.TryParse(userInputString, out IntUserInput));

            return IntUserInput;
        }
    }
}
