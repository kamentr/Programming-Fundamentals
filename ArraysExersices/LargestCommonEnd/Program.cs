using System;

namespace LargestCommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstInput = Console.ReadLine().Split(' ');
            string[] secondInput = Console.ReadLine().Split(' ');
            int length = Math.Min(firstInput.Length, secondInput.Length);
            int countLefttoRight = 0;
            int countRightToLeft = 0;
            for (int i = 0; i < length; i++)
            {
                if (firstInput[i].Equals(secondInput[i]))
                    countLefttoRight++;
                if (firstInput[firstInput.Length - i - 1].Equals(secondInput[secondInput.Length - i - 1]))
                    countRightToLeft++;
            }

            Console.WriteLine(Math.Max(countLefttoRight, countRightToLeft));
        }
    }
}
