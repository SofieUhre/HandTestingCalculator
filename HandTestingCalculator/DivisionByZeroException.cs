using System;

namespace HandTestingCalculator
{
    public class DivisionByZeroException : Exception
    {
        public string ErrorMessage { get; set; }
        public DivisionByZeroException(string message)
        {
            ErrorMessage = message;
        }
    }
}