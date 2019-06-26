using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorAppPractice2
{
    public class Calculator
    {
        public double firstNumber;
        public double secondNumber;

        public double Add()
        {
            return firstNumber + secondNumber;
        }

        public double Subtract()
        {
            return firstNumber - secondNumber;
        }

        public double Multiply()
        {
            return firstNumber * secondNumber;
        }

        public double Devide()
        {
            return firstNumber / secondNumber;
        }
    }
}
