using System;
using System.Text.RegularExpressions;

public class Example
{
    public static void Main()
    {
        string pattern = @"[^.?!]*(?<=[.?\s!])to(?=[\s.?!])[^.?!]*[.?!]";
        string input = Console.ReadLine();
        //RegexOptions options = RegexOptions.Multiline;

        foreach (Match m in Regex.Matches(input, pattern))
        {
            Console.WriteLine(m.Value);
        }
    }
}