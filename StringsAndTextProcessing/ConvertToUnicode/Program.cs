using System;
using System.Text;

namespace ConvertToUnicode
{
    class Program
    {
        public static string GetUnicodeString(string s)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in s)
            {
                sb.Append("\\u");
                sb.Append(String.Format("{0:x4}", (int)c));
            }
            return sb.ToString();
        }

        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(GetUnicodeString(input));
        }
    }
}
