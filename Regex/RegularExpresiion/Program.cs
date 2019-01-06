using System;
using System.Text.RegularExpressions;

public class Example
{
    public static void Main()
    {
        string pattern = @"\b0?x?[0-9A-F]+\b";
        string input = @"0x10 0xAB 0x1F 10 AB 1F FF	

0xG G 0x4G 4G 0xFG FG";
        RegexOptions options = RegexOptions.Multiline;

        foreach (Match m in Regex.Matches(input, pattern, options))
        {
            Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
        }
    }
}