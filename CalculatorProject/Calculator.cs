using System;

namespace CalculatorProject
{
    public class Calculator
    {

        public int Addition(int first, int second)
        {
            return first + second;
        }

        public int Substraction (int first, int second)
        {
            if (first < second)
                throw new ArgumentException($"First number is less than second number {second}");
            return first - second;

        }
    }

}
