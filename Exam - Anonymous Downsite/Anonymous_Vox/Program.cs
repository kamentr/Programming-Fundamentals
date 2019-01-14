using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Anonymous_Vox
{
    class Program
    {
        static void Main(string[] args)
        {
            string matchReplacer = @"([A-Za-z]+)(.+)(\1+)";     //([A-Z]?[a-z]+)(.*)\1 //([a-z]+)(?<replace>.*)\1
            string matchWords = @"{(.*?)}";
            string encodedText = Console.ReadLine();
            string wordsInput = Console.ReadLine();
            RegexOptions options = RegexOptions.Multiline;
            MatchCollection placeholders = Regex.Matches(wordsInput, matchWords, options);
            List<string> wordsToReplaceWith = new List<string>();
            foreach (Match match in placeholders)
            {
                string word = match.Groups[1].ToString();
                if (word.Contains("{"))
                {                    
                    word =  word.Remove(word.IndexOf("{"), 1);
                }
                if (word.Contains("}"))
                {
                    word = word.Remove(word.IndexOf("}"),1);
                }
                wordsToReplaceWith.Add(word);
            }
            MatchCollection wordsToReplace = Regex.Matches(encodedText, matchReplacer , options);
            int length = wordsToReplace.Count;
            if (length > wordsToReplaceWith.Count)
            {
                length = wordsToReplaceWith.Count;
            }           
            for (int i = 0; i < length; i++)
            {
              encodedText = encodedText.Replace(wordsToReplace[i].Groups[2].ToString(), wordsToReplaceWith[i]);
            }
            Console.WriteLine(encodedText);
        }
    }
}
