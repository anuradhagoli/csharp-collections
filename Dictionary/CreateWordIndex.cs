using System;
using System.Collections.Generic;
using System.Text;

namespace CodeSignal.Dictionary
{
    internal class CreateWordIndex
    {
        public static Dictionary<string, int> CreateWordIndex1(string sentence)
        {
            Dictionary<string, int> index = new Dictionary<string, int>();

            string[] words = sentence.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // TODO: Implement this
            foreach (var i in words)
            {
                string s = i.ToLower();
                if (index.ContainsKey(s))
                {
                    index[s]++;
                }
                else
                {
                    index.Add(s, 1);
                }

            }
            return index;
        }


        public void run()
        {
            string sentence1 = "Hello Hello world world world";
            Dictionary<string, int> index1 = CreateWordIndex1(sentence1);
            foreach (var kvp in index1)
            {
                Console.WriteLine($"({kvp.Key} -> {kvp.Value})"); // Should print: (hello -> 2),  (world -> 3)
            }
            Console.WriteLine("----");

            string sentence2 = "";
            Dictionary<string, int> index2 = CreateWordIndex1(sentence2);
            foreach (var kvp in index2)
            {
                Console.WriteLine($"({kvp.Key} -> {kvp.Value})"); // Should print nothing as the sentence is empty.
            }
            Console.WriteLine("----");

            string sentence3 = "Quick Quick brown fox jumps over the lazy dog";
            Dictionary<string, int> index3 = CreateWordIndex1(sentence3);
            foreach (var kvp in index3)
            {
                Console.WriteLine($"({kvp.Key} -> {kvp.Value})");
                // Should print: (quick -> 2), (brown -> 1), (fox -> 1), (jumps -> 1), (over -> 1), (the -> 1), (lazy -> 1), (dog -> 1)
            }
            Console.WriteLine("----");
        }
    }
}
