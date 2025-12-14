using System;
using System.Collections.Generic;
using System.Text;

namespace CodeSignal.BinarySearch
{
    internal class InsertionIndex
    {
        public  int BinarySearch(int[] arr, int start, int end, int target)
            {
                if (start > end) return start; // Base case
                int mid = start + (end - start) / 2; // Find the midpoint
                if (arr[mid] == target) return mid; // Target found
                if (arr[mid] > target) // If the target is less than the midpoint
                    return BinarySearch(arr, start, mid - 1, target); // Search the left half
                return BinarySearch(arr, mid + 1, end, target); // Search the right half
            }
        public void Run()
        {
            int[] numbers = { 1, 3, 5, 6, 9, 12, 15, 18, 21 };
            int searchNumber = 14;
            int targetIndex = BinarySearch(numbers, 0, numbers.Length - 1, searchNumber);
            if (numbers[targetIndex] == searchNumber)
                Console.WriteLine("Number " + searchNumber + " is at index: " + targetIndex);
            else
                Console.WriteLine("Number " + searchNumber + " can be inserted at index: " + targetIndex);
        }

        
    }
}
