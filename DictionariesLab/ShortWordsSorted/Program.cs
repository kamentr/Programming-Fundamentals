using System;
using System.Collections.Generic;
using System.Linq;

namespace ShortWordsSorted
{
    class Program
    {
        static void Main(string[] args)
        {
            List <string> input = Console.ReadLine().Split(' ').OrderBy(x=>x).Where(x =>x.Length<5).ToList();
            Console.WriteLine(string.Join(", ", input));
        }
    }
}
