using System;
using System.Collections.Generic;
using System.Text;

namespace CodeSignal.Recursion
{
    internal class DigitTally
    {
        static int countDigits(int num)
        {
            if (num < 10)
            {
                return 1;
            }
            else
            {
                return 1 + countDigits(num / 10); // Recursive operation to scan further digits
            }
        }

        static void run()
        {
            Console.WriteLine(countDigits(98762));
        }
    }
}
