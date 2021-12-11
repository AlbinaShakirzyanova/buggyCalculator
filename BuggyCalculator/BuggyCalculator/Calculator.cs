using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuggyCalculator
{
    public class Calculator
    {
        public double Div(int number1, int number2)
        {
            return number1 / number2;
        }

        public int Multi(int number1, int number2)
        {
            return number1 * number2;
        }

        public int Sum(int number1, int number2)
        {
            return number1 + number2;
        }

        public int Sub(int number1, int number2)
        {
            return number1 - number2;
        }
    }
}
