using System;
using System.Collections.Generic;
using System.Text;

namespace CodeSignal.HashSet
{
    internal class Problem1UniqueEchoNaive
    {
        string FindLastUniqueEchoWordNaive(string[] words)
        { 
            for (int i = words.Length - 1; i >= 0; i--) //0(n^2)
            {
                bool isUnique = true;
                for(int j = 0; j < words.Length; j++)
                {
                    if (i != j && words[i] == words[j])
                    {
                        isUnique = false;
                        break;
                    }
                }
                if (isUnique)
                {
                    return words[i];
                }
            }
            return null;
        }
    }
}
