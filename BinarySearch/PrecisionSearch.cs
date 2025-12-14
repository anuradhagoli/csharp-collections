using System;
using System.Collections.Generic;
using System.Text;

namespace CodeSignal.BinarySearch
{
    internal class PrecisionSearch
    {
        static int FindNumber(int[] array, int targetNumber)
        {
            int start = 0;
            int end = array.Length - 1;

            while (start <= end)
            {
                // TODO: implement this
                int mid = start + (end - start) / 2;
                if (array[mid] == targetNumber) return mid;
                else if (array[mid] < targetNumber) start = mid + 1;
                else end = mid - 1;

            }

            return -1; // Number not found
        }

        public void Run()
        {
            int[] sortedArray = { 3, 7, 10, 20, 35, 40, 52, 60, 75 };
            int targetNumber = 20;
            Console.WriteLine("Number found at index: " + FindNumber(sortedArray, targetNumber));
        }
    }
}