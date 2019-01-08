using System;

namespace PrimeNums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n= ");
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = i+1;
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(numbers[i] + ' ');
            }
            //Console.WriteLine();
            //int increment;
            //for (int i = 1; i < n; i=i+increment)
            //{
            //    increment = numbers[i];
            //    numbers[i] = 0;

            //}

            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write(numbers[i] + ' ');
            //}
        }
    }
}
