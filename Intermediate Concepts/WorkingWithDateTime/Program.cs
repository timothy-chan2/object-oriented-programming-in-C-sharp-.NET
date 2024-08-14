using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mark the variable declaration as nullable if you might need to set it as null
            DateTime? nullableDate = null;

            Console.Write("Enter a date: ");
            string input = Console.ReadLine();

            nullableDate = DateTime.TryParse(input, out DateTime parseDate) ? parseDate : (DateTime?)null;

            // Current date
            // With time to the millisecond
            Console.WriteLine(DateTime.Now);

            // With time as 12:00:00 AM
            Console.WriteLine(DateTime.Today);

            // With time to the millisecond in UTC
            Console.WriteLine(DateTime.UtcNow);

            // August 6th, 2024 11:45:10 AM
            DateTime date = new DateTime(2024, 8, 6, 11, 45, 10);

            Console.WriteLine(date.Year);    // 2024
            Console.WriteLine(date.Month);   // 8
            Console.WriteLine(date.Day);     // 6
            Console.WriteLine(date.Hour);    // 11
            Console.WriteLine(date.Minute);  // 45
            Console.WriteLine(date.Second);  // 10
            Console.WriteLine(date.DayOfWeek);  // DayOfWeek.Tuesday
            Console.WriteLine(date.DayOfYear);  // Shows how many days into the calendar year
        }
    }
}
