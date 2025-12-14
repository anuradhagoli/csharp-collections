using System;
using System.Collections.Generic;
using System.Text;

namespace CodeSignal.BinarySearch
{
    internal class BinarySearchIterative
    {
        int BinarySearch(int[] arr, int target)
        {
            int start = 0;
            int end = arr.Length - 1;
            while (start <= end)
            {
                int mid = start + (end - start) / 2;
                if (arr[mid] == target) return mid;
                if (arr[mid] < target)
                    start = mid + 1;
                else return mid - 1;
            }
            return -1;
            //O(log n) 

        }
    }
}
