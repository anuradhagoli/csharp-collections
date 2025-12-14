using System;
using System.Collections.Generic;
using System.Text;

namespace CodeSignal.Recursion
{
    internal class StarPyramid
    {
        public void PrintPyramid(int n )
        {
            if (n == 0) return;
            PrintPyramid(n - 1);
            for (int i = 1; i <= n; i++)
            {               
                Console.Write("*");              
            }
            Console.WriteLine();

        }
    }
}
