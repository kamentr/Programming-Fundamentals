using System;
using System.Collections.Generic;
using System.Linq;

namespace AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resourses = new Dictionary<string, int>();
            List<string> input = new List<string>();
            string command = Console.ReadLine();

            while (command != "stop")          // <--------
            {                                  // <--------
                input.Add(command);               
                command = Console.ReadLine();
            }

            for (int i = 0; i < input.Count; i+=2)
            {
                if (resourses.Keys.Contains(input[i]))
                {
                    resourses[input[i]] += int.Parse(input[i + 1]);
                }
                else
                {
                    resourses.Add(input[i], int.Parse(input[i+1]));
                }
            }
            foreach (var item in resourses)
            {
                Console.WriteLine(item.Key + " -> " + item.Value);
            }
        }
    }
}
