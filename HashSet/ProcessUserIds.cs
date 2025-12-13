using System;
using System.Collections.Generic;
using System.Text;

namespace CodeSignal.HashSet
{
    internal class ProcessUserIds
    {
        static int[] ProcessUserIdsa(int[] userIds)
        {
            HashSet<int> userSet = new HashSet<int>();

            // TODO: Add each userId to the userSet
            foreach (int user in userIds)
                userSet.Add(user);

            int[] result = new int[userSet.Count];

            // TODO: Populate the result array with unique IDs
            int i = 0;
            foreach (int user in userSet)
                result[i++] = user;

            return result;
        }
    }
}
/*  static void Main(string[] args) {
        int[] userIds = {1, 2, 3, 2, 1, 5, 3, 1, 2, 1, 4, 5, 6};
        int[] uniqueUserIds = ProcessUserIds(userIds);
        Console.WriteLine(string.Join(", ", uniqueUserIds));   // Expected output: '1, 2, 3, 5, 4, 6'
    }*/