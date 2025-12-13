using System;
using System.Collections.Generic;
using System.Text;

namespace CodeSignal.HashSet
{
    //HashSet doesn't keep order, so the result might be off.
    internal class FirstUniqueHashSet
    {

        public static string FindFirstDuplicateWord(string[] words)
        {
            HashSet<string> wordSet = new HashSet<string>();

            // TODO: Find the word that appears more than once and return it
            foreach (string s in words)
            {
                if (wordSet.Contains(s))
                {
                    return s;
                }
                else
                {
                    wordSet.Add(s);
                }
            }


            // Return an empty string if no duplicate words are found
            return "";
        }


    }


}

/*
 * 
 * Imagine you have a list of words, each completely unique at first glance. 
 * But, as you browse through this list, your mission is to find the first word that 
 * actually appears more than once. If every word is unique, or the list happens to be empty,
 * simply return an empty string. Ensure the solution provides the duplicated word 
 * or an empty string as a result if no duplicate exists.
 * 
 * 
 public static void Main(string[] args) {
        Console.WriteLine(FindFirstDuplicateWord(new string[] { "apple", "banana", "cherry", "banana", "durian", "cherry" })); // Expected "banana"
        Console.WriteLine(FindFirstDuplicateWord(new string[] { "pear", "grape", "pear", "orange" })); // Expected "pear"
        Console.WriteLine(FindFirstDuplicateWord(new string[] { "kiwi", "mango", "kiwi", "melon" })); // Expected "kiwi"
    }
 */
