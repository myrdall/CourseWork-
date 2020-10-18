using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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

        public double Log(double x, double y)
        {
            double log = Math.Log(x, y);
            return log;
        }

        public double Log10(double x)
        {
            double log10 = Math.Log(x);
            return log10;
        }

        //Triganometric
        public double Cos (double x)
        {
            double cos = Math.Cos(x);
            return cos;
        }

        public double Sin (double x)
        {
            double sin = Math.Sin(x);
            return sin;
        }

        public double Tg (double x)
        {
            double tg = Math.Tan(x);
            return tg;
        }

        public double Ctg (double x)
        {
            double ctg = 1 / Math.Tan(x);
            return ctg;
        }
    }

  
}
