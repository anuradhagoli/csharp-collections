using System;
using System.Collections.Generic;
using System.Text;

namespace CodeSignal.Recursion
{
    internal class RecursionPractice
    {
        public void RecursiveFunction(int x)
        {
            if (x <= 0)
            {
                Console.WriteLine("Base case reached");
            }
            else
            {
                Console.WriteLine(x);
                RecursiveFunction(x - 1); 
            }
        }
        public int factorial(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            else
            {
                return n * factorial(n - 1);
            }
        }
        public int SumofDigits(int n)
        {
            if (n == 0)
                return 0;
            else if (n < 10)
                return n;
            else
                return n % 10 + SumofDigits(n / 10);
        }
    }
}
// RecursiveFunction(5);
// factorial(5);
// SumofDigits(1234);