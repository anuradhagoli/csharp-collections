using System;
using System.Collections.Generic;
using System.Text;

namespace CodeSignal.BinarySearch
{
    internal class BinarySearchRecursive
    {
        int BinarySearch(int[] arr, int start, int end, int target)
        {
            if (start > end) return -1;
            int mid = end - start / 2;
            if (arr[mid] == target) return mid;
            if (arr[mid] > target)
                return BinarySearch(arr, start, mid - 1, target);
            return BinarySearch(arr, mid + 1, end, target);

        }
        //O(log n) efficient for large data sets - search sorted list
        //Recursive is less memory efficient - Simpler and intuitive
       
    }
}
