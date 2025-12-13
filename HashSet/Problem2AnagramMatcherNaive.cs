using System;
using System.Collections.Generic;
using System.Text;

namespace CodeSignal.HashSet
{
    internal class Problem2AnagramMatcherNaive
    {
        List<string> FindAnagramNaive(string[] array1, string[] array2)
        {
            List<string> result = new List<string>();
            foreach (string word1 in array1)
            {                
                foreach (string word2 in array2)
                {
                    if (SortCharacters(word1)== SortCharacters(word2))
                    {
                        result.Add(word1);
                        break;
                    }
                }
            }
            return result.Distinct().ToList();
        }

        private static string SortCharacters(string word1)
        {
            char[] chars = word1.ToCharArray();
            Array.Sort(chars);
            return new string(chars);
        }
    }
}
