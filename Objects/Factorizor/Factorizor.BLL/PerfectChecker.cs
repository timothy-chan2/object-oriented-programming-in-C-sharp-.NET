using System.Collections.Generic;

namespace Factorizor.BLL
{
    public class PerfectChecker
    {
        public bool IsPerfectNumber(int userSelectedNumber, int countOfFactors, List<int> factorsOfNumber)
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
