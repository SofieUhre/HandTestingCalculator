using System;
using System.Collections.Generic;
using System.Text;

namespace HandTestingCalculator
{
    public class Calculator

    {
        public double Accumulator { get; private set; }

        public void Clear()
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

        public double Subtract(double a, double b)
        {
            double result = a - b;
            Accumulator = result;
            return result;
        }

        public double Subtract(double a)
        {
            Accumulator = Accumulator - a;
            return Accumulator;
        }

        public double Multiply(double a, double b)
        {
            double result = a * b;
            Accumulator = result;
            return result;
        }

        public double Multiply(double a)
        {
            Accumulator = Accumulator * a;
            return Accumulator;
        }

        public double Power(double x, double exp)
        {
            double result = Math.Pow(x, exp);
            Accumulator = result;
            return result;
        }

        public double Power(double exp)
        {
            double result = Math.Pow(Accumulator, exp);
            Accumulator = result;
            return result;
        }

        public double Divide(double devidend, double devisor)
        {
            decimal result = 0;
            try
            {

                result = (decimal)devidend / (decimal)devisor;

                Accumulator = (double)result;
            }
            catch (Exception e)
            {
                Accumulator = 0;
                throw;
            }
            

            return (double)result;
        }

        public double Divide(double devisor)
        {
            decimal result = 0;
            try
            {

                result = (decimal) Accumulator / (decimal) devisor;
                
                Accumulator = (double)result;
            }
            catch (DivideByZeroException e)
            {
                Accumulator = 0;
                throw;
            }

            return Accumulator;
        }
    }
}
