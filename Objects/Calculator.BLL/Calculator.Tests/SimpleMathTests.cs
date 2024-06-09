using NUnit.Framework;
using System;

namespace Calculator.Tests
{
    [TestFixture]
    public class SimpleMathTests
    {
        [Test]
        public void IntegerDivisionSingleTest()
        {
            SimpleMath math = new SimpleMath();
            int result = math.Divide(5, 2);

            Assert.That(result, Is.EqualTo(2));
        }

        [TestCase(4, 2, 2)]
        [TestCase(13, 6, 2)]
        [TestCase(-20, 5, -4)]
        public void IntegerDivisionUsingTestCases(int x, int y, int expected)
        {
            SimpleMath math = new SimpleMath();
            int actual = math.Divide(x, y);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void DivideByZeroTest()
        {
            SimpleMath math = new SimpleMath();
            Assert.Throws<DivideByZeroException>(() => math.Divide(10, 0));
        }
    }
}
