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

        public double Sub(int x, int y)
        {
            return x - y;
        }

        public double Mult(int x, int y)
        {
            return x * y;
        }

        public double Div (int x, int y)
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
            double result = 1;

            while (x != 1)
            {
                result = x * x;
                x = x - 1;
            }

            return result;
        }


    }
}
