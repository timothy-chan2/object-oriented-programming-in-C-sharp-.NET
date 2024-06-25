using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorizor.BLL
{
    class PerfectChecker
    {
        private bool IsPerfectNumber(int userSelectedNumber, int countOfFactors, List<int> factorsOfNumber)
        {
            int sum = 0;
            bool isPerfectNumber = false;

            for (int i = 0; i < countOfFactors - 1; i++)
            {
                sum += factorsOfNumber[i];
            }

            if (sum == userSelectedNumber)
            {
                isPerfectNumber = true;
            }

            return isPerfectNumber;
        }
    }
}
