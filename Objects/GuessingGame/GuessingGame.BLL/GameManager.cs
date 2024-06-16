using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame.BLL
{
    public class GameManager
    {
        public const int MinGuess = 1;
        public const int MaxGuess = 20;

        private int _answer;

        private bool IsValidGuess(int guess)
        {
            bool isValid = false;

            if (guess >= MinGuess && guess <= MaxGuess)
            {
                isValid = true;
            }

            return isValid;
        }

        private void CreateRandomAnswer()
        {
            Random rng = new Random();
            _answer = rng.Next(MinGuess, MaxGuess + 1);
        }

        public GuessResult ProcessGuess(int guess)
        {
            GuessResult guessResult = GuessResult.Invalid;

            if (IsValidGuess(guess))
            {
                if (guess < _answer)
                {
                    guessResult = GuessResult.Higher;
                }
                else if (guess > _answer)
                {
                    guessResult = GuessResult.Lower;
                }
                else
                {
                    guessResult = GuessResult.Equal;
                }
            }

            return guessResult;
        }

        public void Start()
        {
            CreateRandomAnswer();
        }

        // This method is for used when doing unit tests so the answer in known
        public void Start(int answer)
        {
            _answer = answer;
        }
    }
}
