using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace CodeSignal.Dictionary
{
    internal class KeywordIndexCreator
    {
        public Dictionary<string, List<int>> CreateKeywordIndex(string[] docs)
        {
            var index = new Dictionary<string, List<int>>();
            for (int i = 0; i < docs.Length; i++)
            {

                string[] words = docs[i].Split(new char[] { ' ', ',', '.', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var word in words)
                {
                    if (!string.IsNullOrEmpty(word))
                    {
                        if (!index.TryGetValue(word, out var docindices))
                        {
                            docindices = new List<int>();
                            index.Add(word, docindices);
                        }


                        docindices.Add(i);

                    }
                }
            }
            return index;

        }
    }
}

/*
   string text = "Cosmo,is,strong,technical,with,with,very,strong,for,Cosmo,interviews.";

        KeywordIndexCreator ki = new KeywordIndexCreator();
        var index = new Dictionary<string, List<int>>();
        index = ki.CreateKeywordIndex(text.Split(','));
        foreach (var item in index)
        {
            Console.WriteLine($"{item.Key}: [{string.Join(", ", item.Value)}]");
        }

        List<int> li= new List<int>() { 1, 2, 3 };
        Console.WriteLine(string.Join(":", li));
*/