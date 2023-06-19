using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_Calculator
{
    public static class Calculator
    {
        public static double Add(double a, double b) { return a + b; }

        public static double Subtract(double a, double b) { return a - b; }

        public static double Multiply(double a, double b) { return a * b; }

        public static double Divide(double dividend, double divisor)
        {
            if(divisor == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            else
            {
                return (double)dividend / divisor;
            }
        }

        public static double Pow(double baseNum, int Exponent)
        {
            if(baseNum == 0)
            {
                return 0;
            }
            else if(Exponent == 0)
            {
                return 1;
            }
            else if(Exponent >0 )
            {
                double result = 1;
                for(int i = 1; i < Exponent; i++)
                {
                    result *= baseNum;
                }
                return result;
            }
            else
            {
                double recBase = 1 / baseNum;
                double result = 1;
                for(int i = 0; i<Exponent; i++)
                {
                    result *= recBase;
                }
                return result;
            }
        }
        public static double Sqrt(double a)
        {
            if(a<0)
            {
                throw new ArgumentOutOfRangeException("Can't calculate square root for negative number");
            }
            double guess = a / 2;
            double result = 0;
            while (result != guess)
            {
                result = guess;
                guess = (guess + a / guess) / 2;
            }

            return result;
        }
    }
}