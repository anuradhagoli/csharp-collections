using System;
using System.Collections.Generic;
using System.Text;

namespace CodeSignal.HashSet
{
    internal class Problem2Bad
    {
        int[] RemoveDuplicates(int[] arr)
            {
            List<int> result = new List<int>();
            foreach (int num in arr)
            {
                if (!result.Contains(num))
                {
                    result.Add(num);
                }
            }
            return result.ToArray();
        }
    }
}
