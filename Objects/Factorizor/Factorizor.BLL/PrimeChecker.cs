namespace Factorizor.BLL
{
    public class PrimeChecker
    {
        public bool IsPrimeNumber(int userSelectedNumber, int countOfFactors)
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
