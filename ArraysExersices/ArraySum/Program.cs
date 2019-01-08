using System;
using System.Linq;

namespace ArraySum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine();
            int maxLength = Math.Max(arr1.Length, arr2.Length);

            for (int i = 0; i < maxLength; i++)
            {
                Console.Write(arr1[i] + arr2[i] + " ");
                
            }
        }
    }
}
