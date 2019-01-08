using System;

namespace Reverse_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            foreach (var letter in input)

            for (int i = 1; i < input.Length; i++)
            {
                string pom;
                pom = input[i-1];
                input[i-1] = input[input.Length - i];
                input[input.Length - i] = pom;
            }
            foreach (var letter in input)
            {
                Console.Write(letter + " ");
            }

        }
    }
}
