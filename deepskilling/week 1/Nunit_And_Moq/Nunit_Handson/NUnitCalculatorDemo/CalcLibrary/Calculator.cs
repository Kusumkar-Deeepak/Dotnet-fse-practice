using System;

namespace CalcLibrary
{
    public class Calculator
    {
        private int result;

        public int GetResult
        {
            get { return result; }
        }

        public int Add(int num1, int num2)
        {
            result = num1 + num2;
            return result;
        }

        public int Subtract(int num1, int num2)
        {
            result = num1 - num2;
            return result;
        }

        public int Multiply(int num1, int num2)
        {
            result = num1 * num2;
            return result;
        }

        public int Divide(int num1, int num2)
        {
            if (num2 == 0)
            {
                throw new ArgumentException("Division by zero");
            }

            result = num1 / num2;
            return result;
        }

        public void AllClear()
        {
            result = 0;
        }

        private int Square(int num)
        {
            return num * num;
        }
    }
}