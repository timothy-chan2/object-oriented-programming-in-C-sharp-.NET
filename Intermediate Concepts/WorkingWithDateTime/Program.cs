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

            //August 6th, 2024 11:45:10 AM
            nullableDate = new DateTime(2024, 8, 6, 11, 45, 10);
        }
    }
}
