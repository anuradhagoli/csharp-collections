using System;
using System.Collections.Generic;
using System.Text;

namespace CodeSignal.Dictionary
{
    internal class WordFrequencies
    {
        public void revealWordFrequencies()
        {
            
            string text = "Cosmo,is,an,incredible,technical,companion,with,very,strong,skills,in,Algorithms,and,Data,Structures,and,a,great,teacher,for,technical,interviews.";
            // TODO: initialize the word count dictionary
            string[] words = text.Split(',');

            // TODO: count words and update the dictionary
            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach (string word in words)
            {
                int count = 1;
                if (dict.ContainsKey(word))
                {

                    count++;
                    dict[word] = count;

                }
                else
                {
                    count = 1;
                    dict.Add(word, count);

                }
            }
            // TODO: print the word frequency
            foreach (var str in dict)
            {
                Console.WriteLine(str.Key + ':' + str.Value);
            }
            // 
        }
    }
    
}
