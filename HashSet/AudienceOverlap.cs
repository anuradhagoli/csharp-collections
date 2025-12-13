using System;
using System.Collections.Generic;
using System.Text;

namespace CodeSignal.HashSet
{
    internal class AudienceOverlap
    {
        public static bool AudienceOverlapm(int[] event1, int[] event2)
        {

            HashSet<int> visitorSet = new HashSet<int>();

            // TODO: Implement this
            foreach (int i in event1)
            {
                visitorSet.Add(i);
            }
            foreach (int i in event2)
            {
                if (visitorSet.Contains(i)) return true;

            }

            return false;
        }
    }
}

/*
public static void Main(string[] args)
{
    int[] event1 = { 1, 2, 3, 4, 5 };
    int[] event2 = { 6, 7, 8, 9, 10 };

    if (AudienceOverlap(event1, event2))
        Console.Write("Yes, there is an audience overlap between both events.");
    else
        Console.Write("No, there is no audience overlap between both events.");
}
*/