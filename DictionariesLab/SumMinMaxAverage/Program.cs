using System;
using System.Collections.Generic;
using System.Linq;

namespace SumMinMaxAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = new List<int>();
            input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            Console.WriteLine("Sum= " + input.Sum());
            Console.WriteLine("Min= " + input.Min());
            Console.WriteLine("Max= " + input.Max());
            Console.WriteLine("Avg= " + input.Average());

        }
    }
}
