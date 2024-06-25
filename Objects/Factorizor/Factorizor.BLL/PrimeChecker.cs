using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorizor.BLL
{
    class PrimeChecker
    {
        private bool IsPrimeNumber(int userSelectedNumber, int countOfFactors)
        {
            bool isPrimeNumber = false;

            if (userSelectedNumber > 1 && countOfFactors == 2)
            {
                isPrimeNumber = true;
            }

            return isPrimeNumber;
        }
    }
}
