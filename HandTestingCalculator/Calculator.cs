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
                    Accumulator = 0;
                    throw new DivisionByZeroException("Illegal action - devision by zero. Calculator is set to zero");
                }
                else
                {
                    result = devidend / devisor;
                    Accumulator = result;
                }
            }
            catch (DivisionByZeroException e)
            {
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
                    Accumulator = 0;
                    throw new DivisionByZeroException("Illegal action - devision by zero. Calculator is set to zero");
                }
                else
                {
                    result = Accumulator / devisor;
                    Accumulator = result;
                }
            }
            catch (DivisionByZeroException e)
            {
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
