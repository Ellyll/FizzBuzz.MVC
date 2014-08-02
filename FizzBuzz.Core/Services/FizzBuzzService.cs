using System;

namespace FizzBuzz.Core.Services
{
    public class FizzBuzzService : IFizzBuzzService
    {
        public string Check(int number)
        {
            if (number < 1 || number > 100)
            {
                throw new ArgumentOutOfRangeException(string.Format("Value must be between 1 and 100 but was {0}", number));
            }
            if (number % 15 == 0) return "FizzBuzz";
            if (number % 3 == 0) return "Fizz";
            if (number % 5 == 0) return "Buzz";
            return number.ToString();
        }
    }
}
