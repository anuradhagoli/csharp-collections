using System;
using System.Collections.Generic;
using System.Text;

namespace CodeSignal.Dictionary
{
    public class FrequentBookAccess
    {
        public void FrequentBookAccessq()
        {
            int[] checkOuts1 = { 1, 2, 3, 1, 2, 3, 1, 2, 3, 1 };
            int frequentBook1 = FrequentBook(checkOuts1);
            Console.WriteLine("Frequent Book: " + frequentBook1);  // Expected output: 1

            int[] checkOuts2 = { 5, 0, 5, 0, 5, 0, 5, 0, 1, 1, 1, 1, 1 };
            int frequentBook2 = FrequentBook(checkOuts2);
            Console.WriteLine("Frequent Book: " + frequentBook2);  // Expected output: 5

            int[] checkOuts3 = { 3, 2, 2, 1, 3, 2, 3, 0, 0, 1, 4, 1 };
            int frequentBook3 = FrequentBook(checkOuts3);
            Console.WriteLine("Frequent Book: " + frequentBook3);  // Expected output: -1
        }


        public int FrequentBook(int[] checkOuts)
        {
            Dictionary<int, int> countMap = new Dictionary<int, int>();
            int frequentCheckOutThreshold = checkOuts.Length / 4;

            // TODO: Implement the solution to return the frequently checked out book identifier
            foreach (var i in checkOuts)
            {
               
                if (i != 0)
                {
                    if (!countMap.ContainsKey(i))
                    { 
                        countMap.Add(i, 1);

                    }
                    else
                    {
                        
                        countMap[i]++;
                    }
                    if (countMap[i] > frequentCheckOutThreshold)
                    {
                        return i;
                    }
                }
                 
               
            }
            foreach (var k in countMap)
            {
                Console.WriteLine( k.Key +":"+ k.Value);
            }
          return -1;

        }
    }
}
