using System;
using System.Collections.Generic;
using System.Text;

namespace CodeSignal.Dictionary
{
    internal class WordCounterNaive
    {
        public void WordCounterNaiveA()
        {
            string text = "hello world hello";
            string[] words = text.Split(' ');
            List<string> wordsList = new List<string>();
            List<int> countsList = new List<int>();
            foreach (string word in words)
            {
                int index = wordsList.IndexOf(word);
                if (index != -1)
                {
                    countsList[index]++;
                }
                else
                {
                    wordsList.Add(word);
                    countsList.Add(1);
                }

            }
        }
    }
}
