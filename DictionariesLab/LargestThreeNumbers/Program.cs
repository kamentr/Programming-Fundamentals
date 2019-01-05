using System;
using System.Collections.Generic;
using System.Linq;

namespace LargestThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).OrderByDescending(x => x).ToList();
            if(input.Count >= 3)
            {
                input = input.Take(3).ToList();
            }
            else
            {
                input = input.Take(input.Count).ToList();
            }

            Console.WriteLine(string.Join(' ', input));

        }
    }
}
