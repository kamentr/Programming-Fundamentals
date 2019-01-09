using System;
using System.Collections.Generic;
using System.Linq;

namespace SplitByWordCasing
{
    //, ; : . ! ( ) " ' \ / [ ] space

    class Program
        
    {
        static void Main(string[] args)
        {
            List<string> input = new List<string>();

            char[] charSeparators = new char[] { ',', ':',' ','.',' ',';','!','(',')','"','\'','\\','/','[',']' };
            input = Console.ReadLine().Split(charSeparators, StringSplitOptions.RemoveEmptyEntries).ToList();
            
            List<string> lowerCase = new List<string>();
            List<string> mixedCase = new List<string>();
            List<string> upperCase = new List<string>();

            for (int i = 0; i < input.Count; i++)
            {

                if (idDigit(input[i])) {
                    mixedCase.Add(input[i]);
                }
                  else if (isUpper(input[i]))
                {
                    upperCase.Add(input[i]);
                }
                 else if (isLower(input[i]))
                {
                    lowerCase.Add(input[i]);
                }
                 else
                {
                    mixedCase.Add(input[i]);
                }
            }
            

            Console.WriteLine("Lower-case: " + string.Join(", ", lowerCase));
            Console.WriteLine("Mixed-case: " + string.Join(", ", mixedCase));
            Console.WriteLine("Upper-case: " + string.Join(", ", upperCase));


        }

        private static bool idDigit(string word)
        {
            foreach (char letter in word)
            {
                if (char.IsDigit(letter) || char.IsSymbol(letter)||char.IsPunctuation(letter))
                {
                    return true;
                }
            }
            return false;
        }
        private static bool isLower(string word)
        {
            bool result = false;
            foreach (char letter in word)
            {   
                if (char.IsLower(letter))
                {
                    result = true;
                }else if (char.IsUpper(letter))
                {
                    return false;
                }
            }
            return result;
        }

        private static bool isUpper(string word)
        {
            bool result = false;
            foreach (char letter in word)
            {
                
                if (char.IsUpper(letter))
                {
                    result = true;
                }else if (char.IsLower(letter))
                {
                    return false;
                }
            }
            return result; 
        }
    }
}
