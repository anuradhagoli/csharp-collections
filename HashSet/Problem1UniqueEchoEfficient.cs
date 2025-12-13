using System;
using System.Collections.Generic;
using System.Text;

namespace CodeSignal.HashSet
{
    internal class Problem1UniqueEchoEfficient
    {
        void FindLastUniqueEchoWordEfficient(string[] words)
        {
            HashSet<string> wordsSet = new HashSet<string>();
            HashSet<string> duplicatesSet = new HashSet<string>();

            foreach (string word in words)
            {
                if (wordsSet.Contains(word))
                {
                    duplicatesSet.Add(word);
                }
                else
                {
                    wordsSet.Add(word);
                }

            }
            wordsSet.ExceptWith(duplicatesSet);
        }
    }
}
/*string lastUniqueWord = "";
for (int i = words.Length - 1; i >= 0; i--)
            {
                if (wordsSet.Contains(words[i]))
                {
                    return words[i];
break;
                }
}
return lastUniqueWord;*/

