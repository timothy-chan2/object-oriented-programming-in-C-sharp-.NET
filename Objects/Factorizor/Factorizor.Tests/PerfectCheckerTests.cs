using NUnit.Framework;
using Factorizor.BLL;
using System.Collections.Generic;

namespace Factorizor.Tests
{
    [TestFixture]
    public class PerfectCheckerTests
    {
        [Test]
        public void NotPerfectNumberTest()
        {
            FactorFinder factorFinderInstance = new FactorFinder();
            PerfectChecker perfectCheckerInstance = new PerfectChecker();
            int userSelectedNumber = 12;

            List<int> factors = factorFinderInstance.CreateListOfFactors(userSelectedNumber);
            int numberOfFactors = factorFinderInstance.numberOfFactors;

            bool actual = perfectCheckerInstance.IsPerfectNumber(userSelectedNumber, numberOfFactors, factors);
            Assert.That(actual, Is.EqualTo(false));
        }

        [Test]
        public void PerfectNumberTest()
        {
            FactorFinder factorFinderInstance = new FactorFinder();
            PerfectChecker perfectCheckerInstance = new PerfectChecker();
            int userSelectedNumber = 28;

            List<int> factors = factorFinderInstance.CreateListOfFactors(userSelectedNumber);
            int numberOfFactors = factorFinderInstance.numberOfFactors;

            bool actual = perfectCheckerInstance.IsPerfectNumber(userSelectedNumber, numberOfFactors, factors);
            Assert.That(actual, Is.EqualTo(true));
        }
    }
}
