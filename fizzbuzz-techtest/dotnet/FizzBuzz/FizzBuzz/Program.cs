using FizzBuzz.Interface;
using System;
using System.Collections.Generic;

namespace FizzBuzz
{
    class Program
    {
        private readonly IFizzBuzzProvider _fizzBuzzProvider = new FizzBuzzProvider();
        private readonly IInputOutputProvider _inputOutputProvider = new InputOutputProvider();

        private void Run()
        {
            try
            {
                int number = _inputOutputProvider.ReadNumber();
                string result = _fizzBuzzProvider.FizzBuzz(number);
                _inputOutputProvider.Print(result);
            }
            catch(Exception ex)
            {
                _inputOutputProvider.Print(ex.Message);
            }
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();

        }
    }
}


