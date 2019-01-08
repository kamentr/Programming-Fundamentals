using System;
using System.Linq;

namespace FoldingArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = input.Length / 4;
            int[] firstColumn = new int[k * 2];
            int[] secondColumn = new int[k * 2];
            int[] sum = new int[k*2];

            //5 2 3 6   k=1
            //0 1 2 3 
            for (int i = 0; i <= k; i++)
            {
                firstColumn[i] = input[i];
                secondColumn[i] = input[i + k];
                sum[i] = firstColumn[i] + secondColumn[i];    
            }
            for (int i = 0; i < k*2; i++)
            {
                Console.WriteLine(sum[i] + ' ');
            }
        }
    }
}
