using System;

namespace HandTestingCalculator
{
    public class myDivsionByZeroException : Exception
    {
        public string ErrorMessage { get; set; }
        public myDivsionByZeroException(string message)
        {
            ErrorMessage = message;

        }
    }
}