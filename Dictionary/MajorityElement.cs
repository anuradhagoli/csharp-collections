using System;
using System.Collections.Generic;
using System.Text;

namespace CodeSignal.Dictionary
{
    internal class MajorityElement
    {
        public void FindMajorityElement(int[] arr)
        {
            Dictionary<int, int> countMap = new Dictionary<int, int>();
            int majorityThreshold = arr.Length / 2;
            foreach (var num in arr)
            {
                if (countMap.TryGetValue(num,out int count))
                {
                    countMap[num]++;
                }
                else
                {
                    countMap[num] = 1;
                }
                if (countMap[num] > majorityThreshold)
                {
                    Console.WriteLine($"The majority element is: {num}");
                    return;
                }
            }
            Console.WriteLine("No majority element found.");
        }

        public void FindMajorityElement_Naive(int[] arr)
        {
            int count = 0;
            int candidate = -1;
            foreach (var num in arr)
            {
                if (count == 0)
                {
                    candidate = num;
                }
                count += (num == candidate) ? 1 : -1;
            }
            // Verify if the candidate is indeed the majority element
            count = 0;
            foreach (var num in arr)
            {
                if (num == candidate)
                {
                    count++;
                }
            }
            if (count > arr.Length / 2)
            {
                Console.WriteLine($"The majority element is: {candidate}");
            }
            else
            {
                Console.WriteLine("No majority element found.");
            }
        }
    }
}
