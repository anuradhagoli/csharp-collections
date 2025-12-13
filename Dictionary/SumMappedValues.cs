using System;
using System.Collections.Generic;
using System.Text;

namespace CodeSignal.Dictionary
{
    internal class SumMappedValues
    {
        Dictionary<string, int> map = new Dictionary<string, int>()
        {
            {"apple", 2},
            {"banana", 3},
            {"orange", 4},
            {"grape", 5}
        };  
        public int SumValues(string[] items)
        {
            int sum = 0;
          /*  foreach (string item in items)
            {
                if (map.ContainsKey(item))
                {
                    sum += map[item];
                }
            }*/
          foreach (int value in map.Values)
            {                
                sum += value;
            }
            return sum;
        }
    }
}
