using System;
using System.Collections.Generic;
using System.Text;

namespace CodeSignal.HashSet
{
    internal class FindAnagramsReport
    {
        // Method to return a unique character signature for each string.
        static string SortCharacters(string input)
        {
            char[] chars = input.ToCharArray();
            Array.Sort(chars);
            return new string(chars);
        }


        // Method to find unique words from report2 that have an anagram in report1 
        public static int FindAnagrams(string[] report1, string[] report2)
        {
            HashSet<string> sortedWordsInReport1 = new HashSet<string>();
            // TODO: fill in sortedWordsInReport1
            foreach (string s in report1)
            {
                sortedWordsInReport1.Add(SortCharacters(s));
            }

            HashSet<string> anagramsMatched = new HashSet<string>();
            int lengthSum = 0;

            foreach (string word in report2)
            {
                //ensure that only unique words from report2 are counted. If a word appears more than once in report2, its length is added multiple times.

                if (sortedWordsInReport1.Contains(SortCharacters(word)) && !anagramsMatched.Contains(word))
                {
                    anagramsMatched.Add(word);
                    lengthSum += word.Length;
                }
                // implement this
            }

            return lengthSum;
        }

    }
}
/*Imagine you're a code analyst tasked with deciphering two sets of reports. 
 * Each report is an array of strings. Your mission is to identify the unique 
 * strings from the second report that have an anagram match in the first report 
 * and return the sum of their lengths as an integer. Remember, anagrams are words 
 * formed by rearranging the letters of another. Now, if a string doesn't find 
 * an anagram in the other report or isn't unique, move on. Whether the reports are 
 * short or extensive, ensure your code efficiently calculates this cosmic string sum!

 public static void Main(string[] args) {
        string[] report1 = {"cat", "dog", "tac", "god", "act"};
        string[] report2 = {"tca", "ogd", "atc", "taco"};
        int result = FindAnagrams(report1, report2);
        Console.WriteLine(result);   // output: 9

        // additional test samples
        string[] report3 = {"rat", "tar", "bat", "tab","bats"};
        string[] report4 = {"tra", "art", "abr"};
        int result2 = FindAnagrams(report3, report4);
        Console.WriteLine(result2);  // output: 6
    }
 
 */