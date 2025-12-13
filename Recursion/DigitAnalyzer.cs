using CodeSignal.Dictionary;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeSignal.Recursion
{
    internal class DigitAnalyzer
    {
        public int CountDigits(int num)
        {
            if (num == 0)
            {
                return 0;
            }
            else
            {
                // Recursive case: reduce the number by dividing by 10 and count the rest
                // TODO: Count only the even numbers
                int lastdigit = num % 10;
                if (lastdigit % 2 == 0)
                    return 1 + CountDigits(num / 10);
                else
                    return CountDigits(num / 10);
            }
        }
    }
}

/*Console.WriteLine("The number of digits in the 'diameter of Mars': " + CountDigits(7623));*/