using System;
using System.Collections.Generic;
using System.Text;

namespace CodeSignal.HashSet
{
    internal class Problem2AnagramMatcherEfficient
    {
       List<string> FindAnagramEfficient(string[] array1, string[] array2)
        {
            HashSet<string> sortedWordsInArray2 = new HashSet<string>();
            foreach (string word in array2)
            {
                sortedWordsInArray2.Add(SortCharacters(word));
            }
            HashSet<string> anagramsMatched = new HashSet<string>();
            List<string> result = new List<string>();
            foreach (string word in array1)
            { 
                if (sortedWordsInArray2.Contains(SortCharacters(word)) && !anagramsMatched.Contains(word))
                {
                    result.Add(word);
                    anagramsMatched.Add(word);
                }
            }
            return result;
        }
        private static string SortCharacters(string word)
        {
            char[] chars = word.ToCharArray();
            Array.Sort(chars);
            return new string(chars);
        }
    }
}
