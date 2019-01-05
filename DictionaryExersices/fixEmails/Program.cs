using System;
using System.Collections.Generic;
using System.Linq;

namespace AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> emails = new Dictionary<string, string>();
            List<string> input = new List<string>();
            string command = Console.ReadLine();

            while (command != "stop")          // <--------
            {                                  // <--------
                input.Add(command);
                command = Console.ReadLine();
            }

            for (int i = 0; i < input.Count; i += 2)
            {
                if (emails.Keys.Contains(input[i]))
                {
                    emails[input[i]] += int.Parse(input[i + 1]);
                }
                else
                {
                    emails.Add(input[i], (input[i + 1]));
                }
            }
            foreach (var item in emails)
            {
                if(!(item.Value.EndsWith("us")) && !(item.Value.EndsWith("uk")))
                {
                    Console.WriteLine(item.Key + " -> " + item.Value);
                }
            }
            
            
                
        }
    }
}
