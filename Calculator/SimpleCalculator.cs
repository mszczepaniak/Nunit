﻿namespace Calculator
{
    public class SimpleCalculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Multiply(int a, int b)
        {
            // intentional bug
            return a * b;
        }
    }
}