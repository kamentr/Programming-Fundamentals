using System;
using System.Collections.Generic;
using System.Linq;

namespace OddOccurrances
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().ToLower().Split(' ').ToList();
            Dictionary<string, int> counts = new Dictionary<string, int>();

            foreach (var word in input)
            {
                if (counts.Keys.Contains(word))
                {
                    counts[word]++;
                }
                else
                {
                    counts[word] = 1;
                }
            }
            List<string> result = new List<string>();
            foreach (var word in counts)
            {
                if(word.Value % 2 != 0)
                {
                    result.Add(word.Key);
                }
            }
            Console.WriteLine(string.Join(", ", result));

            
        }
    }
}
