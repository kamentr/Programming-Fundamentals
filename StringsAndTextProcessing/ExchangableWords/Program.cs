using System;
using System.Linq;

namespace ExchangableWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            string wordOne = input[0];
            string wordTwo = input[1];

            Console.WriteLine(AreExchangable(wordOne, wordTwo)); 
        }

        private static bool AreExchangable(string wordOne, string wordTwo)
        {
            for (int i = 0; i < wordOne.Length; i++)
            {
                wordOne = wordOne.Replace(wordOne[i], wordTwo[i]);
            }
            if (wordOne != wordTwo) { return false; }
            return true;
        }
    }
}
