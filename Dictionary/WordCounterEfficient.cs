using System;
using System.Collections.Generic;
using System.Text;

namespace CodeSignal.Dictionary
{
    internal class WordCounterEfficient
    {
        public void WordCounterEfficientA()
        {
            string text = "hello world hello";
            string[] words = text.Split(' ');
            Dictionary<string, int> wordCounts = new Dictionary<string, int>();
            foreach (string word in words)
            {
                if (wordCounts.ContainsKey(word))
                {
                    wordCounts[word]++;
                }
                else
                {
                    wordCounts[word] = 1;
                }
            }
            Console.WriteLine(string.Join(",",wordCounts));
        }
    }
}
