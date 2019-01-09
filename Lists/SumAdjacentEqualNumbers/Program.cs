using System;
using System.Collections.Generic;
using System.Linq;

namespace SumAdjacentEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = new List<int>();
            input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 1; i < input.Count; i++)
            {
                if(input[i] == input[i - 1])
                {
                    input[i]= input[i] + input[i-1];
                    input.Remove(input[i-1]);
                    i = 0;
                }
            }
            Console.WriteLine(string.Join(' ', input));
        }
    }
}
