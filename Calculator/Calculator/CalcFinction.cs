using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    public class CalcFinction
    {
        public double Summ(double x, double y)
        {
            return x + y;
        }

        public double Sub(double x, double y)
        {
            return x - y;
        }

        public double Mult(double x, double y)
        {
            return x * y;
        }

        public double Div (double x, double y)
        {
            return x / y; 
        }

        public double Exp (double x, int pow)
        {
            double exp = Math.Pow(x, pow);
            return exp;
        }

        public double Sqrt (double x)
        {
            double sqrt = Math.Sqrt(x);
            return sqrt;
        }

        public double Factorial (int x)
        {
            if (x == 1)
            {
                return 1;
            }
            else
            {
                double result = x * Factorial(x - 1);
                return result;
            }
        }


    }
}
