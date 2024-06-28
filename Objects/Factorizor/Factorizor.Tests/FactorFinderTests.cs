using NUnit.Framework;
using Factorizor.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorizor.Tests
{
    [TestFixture]
    public class FactorFinderTests
    {
        [Test]
        public void validInputTest()
        {
            FactorFinder factorFinderInstance = new FactorFinder();
            int userSelectedNumber = 12;
            List<int> expected = new List<int>() { 1, 2, 3, 4, 6, 12 };

            List<int> actual = factorFinderInstance.CreateListOfFactors(userSelectedNumber);
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
