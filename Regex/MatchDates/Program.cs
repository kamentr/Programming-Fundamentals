using System;
using System.Text.RegularExpressions;

public class Example
{
    public static void Main()
    {
        string pattern = @"\b(?<days>\d{2})([-.\/])(?<month>[A-Z][a-z]{2})\2(?<years>\d{4})";
        string input = @"13/Jul/1928, 10-Nov-1934, 25.Dec.1937
01/Jan-1951, 23/sept/1973, 1/Feb/2016";
        RegexOptions options = RegexOptions.Multiline;

        foreach (Match m in Regex.Matches(input, pattern, options))
        {
            var days = m.Groups["days"].Value;
            var months = m.Groups["months"].Value;
            Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
        }
    }
}