using FizzBuzz.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzzProvider : IFizzBuzzProvider
    {
        public string FizzBuzz(int number)
        {
            string result = string.Empty;

            if (number % 3 == 0) result = "Fizz";
            if (number % 5 == 0) result += "Buzz";

            return result;
        }
    }
}
