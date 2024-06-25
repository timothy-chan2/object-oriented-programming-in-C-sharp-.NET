using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorizor.BLL
{
    public class FactorFinder
    {
        public int numberOfFactors;

        private List<int> CreateListOfFactors(int input)
        {
            int rangeMax = (int)Math.Sqrt(input);
            List<int> factors = new List<int>();

            for (int potentialFactor = 1; potentialFactor <= rangeMax; potentialFactor++)
            {
                if (input % potentialFactor == 0)
                {
                    factors.Add(potentialFactor);
                    if (input / potentialFactor != potentialFactor)
                    {
                        factors.Add(input / potentialFactor);
                    }
                }
            }

            factors.Sort();
            numberOfFactors = factors.Count;

            return factors;
        }
    }
}
