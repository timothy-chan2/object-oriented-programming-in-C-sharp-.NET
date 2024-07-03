using NUnit.Framework;
using Factorizor.BLL;

namespace Factorizor.Tests
{
    [TestFixture]
    class PrimeCheckerTests
    {
        [Test]
        public void NotPrimeNumberTest()
        {
            FactorFinder factorFinderInstance = new FactorFinder();
            PrimeChecker primeCheckerInstance = new PrimeChecker();
            int userSelectedNumber = 12;

            factorFinderInstance.CreateListOfFactors(userSelectedNumber);
            int numberOfFactors = factorFinderInstance.numberOfFactors;

            bool actual = primeCheckerInstance.IsPrimeNumber(userSelectedNumber, numberOfFactors);
            Assert.That(actual, Is.EqualTo(false));
        }

        [Test]
        public void PrimeNumberTest()
        {
            FactorFinder factorFinderInstance = new FactorFinder();
            PrimeChecker primeCheckerInstance = new PrimeChecker();
            int userSelectedNumber = 13;

            factorFinderInstance.CreateListOfFactors(userSelectedNumber);
            int numberOfFactors = factorFinderInstance.numberOfFactors;

            bool actual = primeCheckerInstance.IsPrimeNumber(userSelectedNumber, numberOfFactors);
            Assert.That(actual, Is.EqualTo(true));
        }
    }
}
