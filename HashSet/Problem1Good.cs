using System;
using System.Collections.Generic;
using System.Text;

namespace CodeSignal.HashSet
{
    internal class Problem1Good
    {
        bool AreDisjoint(int[] arr1, int[] arr2)
        {
            HashSet<int> set = new HashSet<int>();
            foreach (int num in arr1)
            {
                set.Add(num); //Constant time checks
            }
            foreach (int num in arr2)
            {
                if (set.Contains(num))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
