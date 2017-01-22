using FizzBuzz.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class InputOutputProvider : IInputOutputProvider
    {
        public void Print(string value)
        {
            Console.WriteLine(value);
            Console.ReadKey();
        }

        public int ReadNumber()
        {
            int number;
            Console.WriteLine("Input number:");
            string input = Console.ReadLine();

            if (!Int32.TryParse(input, out number))
            {
                throw new Exception("Invalid input!");
            }          

            return number;
        }
    }
}
