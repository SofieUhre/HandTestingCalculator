using System;

namespace HandTestingCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            double a = 4.2;
            double b = 4.5;
            double c = 0.1;
            double d = 3.2;
            double e = 10.4;
            double f = 8.0;

            //Tester Add()
            Console.WriteLine("Testing Add()");
            Console.WriteLine("Add({0}, {1}) = {2}", a, b, calculator.Add(a, b));
            Console.WriteLine("Add({0}, {1}) = {2}", c, d, calculator.Add(c, d));
            Console.WriteLine("Add({0}, {1}) = {2}", e, f, calculator.Add(e, f));

            //Tester Substract()
            Console.WriteLine("\nTesting Substact()");
            Console.WriteLine("Substract({0}, {1}) = {2}", a, b, calculator.Subtract(a, b));
            Console.WriteLine("Substract({0}, {1}) = {2}", c, d, calculator.Subtract(c, d));
            Console.WriteLine("Substract({0}, {1}) = {2}", e, f, calculator.Subtract(e, f));

            //Tester Multiply()
            Console.WriteLine("\nTesting Multiply()");
            Console.WriteLine("Multiply({0}, {1}) = {2}", a, b, calculator.Multiply(a, b));
            Console.WriteLine("Multiply({0}, {1}) = {2}", c, d, calculator.Multiply(c, d));
            Console.WriteLine("Multiply({0}, {1}) = {2}", e, f, calculator.Multiply(e, f));

            //Tester Power()
            Console.WriteLine("\nTesting Power()");
            Console.WriteLine("Power({0}, {1}) = {2}", a, b, calculator.Power(a, b));
            Console.WriteLine("Power({0}, {1}) = {2}", c, d, calculator.Power(c, d));
            Console.WriteLine("Power({0}, {1}) = {2}", e, f, calculator.Power(e, f));
            
        }
    }
}
