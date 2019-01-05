using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> input = new List<double>();
            input = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            SortedDictionary<double, int> counts = new SortedDictionary<double, int>();

            foreach(double num in input)
            {
                if (counts.Keys.Contains(num))
                {
                    counts[num] ++;
                }
                else
                {
                    counts[num] = 0;
                }
            }
            Console.WriteLine(string.Join(+);
        }
    }
}
