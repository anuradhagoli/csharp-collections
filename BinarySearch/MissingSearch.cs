using System;
using System.Collections.Generic;
using System.Text;

namespace CodeSignal.BinarySearch
{
    internal class MissingSearch
    {
        public static int BinarySearch(int[] numbers, int start, int end, int target)
        {
            // TODO: Add base case condition to stop recursion
            if (start > end) return -1;
            int mid = start + (end - start) / 2;
            if (numbers[mid] == target) return mid; // Number found

            // TODO: Compare mid number to target number and finish the recursive call
            if (numbers[mid] > target)
                return BinarySearch(numbers, start, mid - 1, target);
            return BinarySearch(numbers, mid + 1, end, target);
        }
        public void Run()
        {
            int[] sortedArray = { 1, 3, 5, 7, 9, 11 };
            int numberToFind = 7; // Number we want to find
            int result = BinarySearch(sortedArray, 0, sortedArray.Length - 1, numberToFind);
            Console.WriteLine($"The number {numberToFind} is at index: {result}");
        }
    }
}
