using System;
using System.Text.RegularExpressions;

public class Example
{
    public static void Main()
    {
        string pattern = @"\w+\@\w+.\w+";
        string input = @"Please contact us at: support@github.com.
Just send email to s.miller@mit.edu and
 j.hopking@york.ac.uk for more information.
Many users @ SoftUni confuse email addresses. We @ Softuni.BG provide high-quality training @ home or @ class. –- steve.parker@softuni.de.
";
        //RegexOptions options = RegexOptions.Multiline;

        foreach (Match m in Regex.Matches(input, pattern))
        {
            Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
        }
    }
}
