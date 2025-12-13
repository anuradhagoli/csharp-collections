using System;
using System.Collections.Generic;
using System.Text;

namespace CodeSignal.HashSet
{
    internal class Problem2Good
    {
        int[] RemoveDuplicates(int[] arr)
        {
            //Add and contains are O(1) operations on average for Hashset
            HashSet<int> nums = new HashSet<int>();
            foreach (int num in arr)
            {
            
                    nums.Add(num);
                
            }

            int[] result = new int[nums.Count];
            int i = 0;
            foreach (int num in nums)
            {
                result[i++] = num;
            }
            return result;
        }
    }
}
