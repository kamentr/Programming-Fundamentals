using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogsAggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> people = new Dictionary<string, Dictionary<string, int>>();  // --> person, ip , duration 
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < n; i++)
            {
            string[] input = Console.ReadLine().Split(' ').ToArray();
                string ip = input[0];
                string name = input[1];
                int duration = int.Parse(input[2]);
                var list = new List<string> { ip };
                if (!people.ContainsKey(name))
                {
                    people.Add(name, new Dictionary<string, int>());
                }
                if (!people[name].ContainsKey(ip))
                {
                    people[name].Add(ip, 0);
                }
                people[name][ip] += duration;
                     
            }
            StringBuilder sb = new StringBuilder();
            foreach (var person in people)
            {
                Console.Write(person.Key + ": " );

                foreach (var ipAndDuration in person.Value)
                {
                    
                    sb.Append(" [ " + ipAndDuration.Key + " ], ");
                      
                }
                sb.Remove(sb.Length - 2, 2);
                Console.Write(sb);  
                Console.WriteLine();
            }
        }

       
    }
}
