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
                if (devisor == 0)
                {
                    throw new myDivsionByZeroException("Du har divideret med 0 din idiot!");
                }
                result = devidend / devisor;

                Accumulator = result;
            }
            catch (myDivsionByZeroException e)
            {
                Accumulator = result;
                Console.WriteLine(e.ErrorMessage);
            }

            return result;
        }

        public double Divide(double devisor)
        {
            double result = 0;
            try
            {
                if (devisor == 0)
                {
                    throw new myDivsionByZeroException("Du har divideret med 0 din idiot!");
                }
                result = Accumulator  / devisor;
                Accumulator = result;
            }
            catch (myDivsionByZeroException e)
            {
                Accumulator = 0;
                Console.WriteLine(e.ErrorMessage);
            }

            return Accumulator;
        }


        public double Power(double exp)
        {
            double result = Math.Pow(Accumulator, exp);
            Accumulator = result;
            return result;
        }
    }
}
