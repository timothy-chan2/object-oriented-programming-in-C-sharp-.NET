using System;

namespace TextBasedGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You are standing in an open field west of a white house,");
            Console.WriteLine("With a boarded front door.");
            Console.WriteLine("There is a small mailbox here.");
            Console.Write("Go to the house, or open the mailbox? ");

            String action = Console.ReadLine();

            if (action.Equals("open the mailbox"))
            {
                Console.WriteLine("You open the mailbox.");
                Console.WriteLine("It's really dark in there.");
                Console.Write("Look inside or stick your hand in? ");
                action = Console.ReadLine();

                if (action.Equals("look inside"))
                {
                    Console.WriteLine("You peer inside the mailbox.");
                    Console.WriteLine("It's really very dark. So ... so very dark.");
                    Console.Write("Run away or keep looking? ");
                    action = Console.ReadLine();

                    if (action.Equals("keep looking"))
                    {
                        Console.WriteLine("Turns out, hanging out around dark places isn't a good idea.");
                        Console.WriteLine("You've been eaten by a grue.");
                        Console.ReadLine();
                    }
                    else if (action.Equals("run away"))
                    {
                        Console.WriteLine("You run away screaming across the fields - looking very foolish.");
                        Console.WriteLine("But you're alive. Possibly a wise choice.");
                        Console.ReadLine();
                    }
                }
                else if (action.Equals("stick your hand in"))
                {
                    Console.WriteLine("You feel a bite and lose consciousness.");
                    Console.ReadLine();
                }
            }
            else if (action.Equals("go to the house"))
            {
                Console.WriteLine("You enter the house and go to bed since you're feeling tired.");
                Console.ReadLine();
            }
        }
    }
}
