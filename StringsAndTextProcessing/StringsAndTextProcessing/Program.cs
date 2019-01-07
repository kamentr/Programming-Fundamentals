using System;
using System.Linq;
using System.Text;

namespace StringsAndTextProcessing
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

            int N = int.Parse(input[0]);
            string num = input[1];
            
                
           // ConvertNumToBaseN(N, num);
            ConvertFromBaseToNum(N, num);
        }
        //13
        private static void ConvertFromBaseToNum(int n, string num)
        {
            double result = 0;
            double number = double.Parse(num);
            double i = 0;
            while (number > 0)
            {
                int digit = (int)number % 10;
                number = number / 10;
                result += digit * Math.Pow((double)(n), (i));
                i++;
            }
            
            Console.WriteLine(result);
        }

        private static void ConvertNumToBaseN(int n, int num)
        {
            StringBuilder result = new StringBuilder();
            while (num > 0)
            {
                result.Append(num % n);
                num =num/n;
            }
            for (int i = result.Length-1; i >= 0; i--)
            {
                Console.Write(result[i]);
            }
            Console.WriteLine();
        }
    }
}
