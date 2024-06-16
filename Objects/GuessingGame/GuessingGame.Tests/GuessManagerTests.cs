using NUnit.Framework;
using GuessingGame.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame.Tests
{
    [TestFixture]
    public class GuessManagerTests
    {
        private int _middleOfRange;

        public GuessManagerTests()
        {
            _middleOfRange = (GameManager.MinGuess + GameManager.MaxGuess) / 2;
        }
        
        [Test]
        public void InvalidGuessTest()
        {
            GameManager gameInstance = new GameManager();
            gameInstance.Start();

            GuessResult actual = gameInstance.ProcessGuess(GameManager.MaxGuess + 1);
            Assert.That(actual, Is.EqualTo(GuessResult.Invalid));
        }

        [Test]
        public void HigherGuessResultTest()
        {
            GameManager gameInstance = new GameManager();
            gameInstance.Start(_middleOfRange);

            GuessResult actual = gameInstance.ProcessGuess(_middleOfRange - 1);
            Assert.That(actual, Is.EqualTo(GuessResult.Higher));
        }

        [Test]
        public void LowerGuessResultTest()
        {
            GameManager gameInstance = new GameManager();
            gameInstance.Start(_middleOfRange);

            GuessResult actual = gameInstance.ProcessGuess(_middleOfRange + 1);
            Assert.That(actual, Is.EqualTo(GuessResult.Lower));
        }

        [Test]
        public void EqualGuessResultTest()
        {
            GameManager gameInstance = new GameManager();
            gameInstance.Start(_middleOfRange);

            GuessResult actual = gameInstance.ProcessGuess(_middleOfRange);
            Assert.That(actual, Is.EqualTo(GuessResult.Equal));
        }
    }
}
