using System;
using System.Collections.Generic;
using System.Text;

namespace CodeSignal.Recursion
{
    internal class CountDigits
    {

        // Recursive method to calculate the sum of digits of a number
        static int CountStars(int number)
        {
            int sum = 0;
            if (number == 0) return 0; // Base case: if number is 0, stop recursion
                                       // TODO: Add the recursive logic to sum up the digits of 'number'
            else

                return sum + number % 10 + CountStars(number / 10);
        }

        static void Run()
        {
            Console.WriteLine(CountStars(4042)); // Will print the sum of digits of the star code 4042
        }
    }
}
