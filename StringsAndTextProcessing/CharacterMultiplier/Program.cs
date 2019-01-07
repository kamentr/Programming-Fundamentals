using System;
using System.Linq;
using System.Text;

namespace CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            string str1 = input[0];
            string str2 = input[1];

            Console.WriteLine(MultiplyCharacters(str1, str2));
        }

        private static int MultiplyCharacters(string str1, string str2)
        {
            int sum = 0;
            int min = str1.Length;
            if(str1.Length == str2.Length)
            {
                for (int i = 0; i < str2.Length; i++)
                {
                    sum += (int)(str1[i]) * (int)(str2[i]);
                }
            }
            else
            {
                StringBuilder sb = new StringBuilder();
                if (min > str2.Length)
                {
                    min = str2.Length;
                    for (int i = 0; i < min; i++)
                    {
                        sum += (int)(str1[i]) * (int)(str2[i]);
                    }
                    for (int i = min+1; i < str1.Length; i++)
                    {
                        sb.Append((int)(str1[i]));
                    }
                }
                else
                {
                    for (int i = 0; i < min; i++)
                    {
                        sum += (int)(str1[i]) * (int)(str2[i]);
                    }
                    sb.Append(sum);
                    for (int i = min; i < str1.Length; i++)
                    {
                        sb.Append((int)(str2[i]));
                    }
                }
            }
            return sum;
        }
    }
}
