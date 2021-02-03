using System;

namespace HandTestingCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            double a = 2;
            double b = 2;

            double add = calculator.Add(a,b);
            Console.WriteLine("The result of " + a + " puls " + b + " is equal to " + add);

            double substract = calculator.Substract(a, b);
            Console.WriteLine("The result of " + a + " minus " + b + " is equal to " + substract);

            double multiply = calculator.Multiply(a, b);
            Console.WriteLine("The result of " + a + " multiply " + b + " is equal to " + multiply);

            double power = calculator.Power(a, b);
            Console.WriteLine("The result of " + a + " powered " + b + " is equal to " + power);

        }
    }
}
