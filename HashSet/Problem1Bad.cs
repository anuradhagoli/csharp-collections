using System;
using System.Collections.Generic;
using System.Text;

namespace CodeSignal.HashSet
{
    internal class Problem1Bad
    {
        bool AreDisjoint(int[] arr1, int[] arr2)
        {
           
            foreach (int num1 in arr1)
            {
                foreach (int num2 in arr2)
                {

                    if (num1==num2)
                    {
                        return false;
                    }
                }
            }
          
            return true;
        }
    }
}
