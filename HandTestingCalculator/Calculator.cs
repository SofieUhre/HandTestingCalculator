﻿using System;
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
            return result;
        }

        public double Add(double added)
        {
            double result = Accumulator + added;
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
            double result = devidend / devisor;
            return result;
        }
    }
}
