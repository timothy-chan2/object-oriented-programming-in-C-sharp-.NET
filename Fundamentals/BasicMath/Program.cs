using System;

namespace BasicMath
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte firstNumber = 1;
            sbyte secondNumber = 2;
            sbyte thirdNumber = 3;
            sbyte answer = (sbyte)(firstNumber + secondNumber + thirdNumber);

            Console.WriteLine(firstNumber + " + " + secondNumber + " + " + thirdNumber + " = " + answer);
            Console.ReadLine();
        }
    }
}
