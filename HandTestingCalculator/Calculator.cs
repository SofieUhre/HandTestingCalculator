using System;
using System.Collections.Generic;
using System.Text;

namespace HandTestingCalculator
{
    public class Calculator

    {
        public double Accumulator { get; private set; }

        public void clear()
        {
            Accumulator = 0;
        }
         
        public double Add(double a, double b)
        {
            double result = a + b;
            Accumulator = result;
            return result;
        }

        public double Add(double added)
        {
            double result = Accumulator + added;
            Accumulator = result;
            return result;
        }

        public double Substract(double a, double b)
        {
            double result = a - b;
            return result;
        }

        public double Multiply(double a, double b)
        {
            double result = a * b;
            return result;
        }

        public double Power(double x, double exp)
        {
            double result = Math.Pow(x, exp);
            return result;
        }

        public double Divide(double devidend, double devisor)
        {
            double result = 0;
            
            try
            {
                result = devidend / devisor;
                Accumulator = result;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e);
            }

            return result;
        }

<<<<<<< HEAD

        public double Power(double exp)
        {
            double result = Math.Pow(Accumulator, exp);
            Accumulator = result;
            return result;
=======
        public double Devide(double devisor)
        {
            try
            {
                double result = Accumulator/devisor;
                Accumulator = result;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e);
            }

            return Accumulator;


>>>>>>> 8d95a6d8698542e4956ae1fb6d8c6f4c27ff3f90
        }
    }
}
