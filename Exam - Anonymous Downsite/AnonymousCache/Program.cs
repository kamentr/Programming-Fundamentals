using System;
using System.Collections.Generic;

namespace AnonymousCache
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, uint>> Data = new Dictionary<string, Dictionary<string, uint>>();
            Dictionary<string, Dictionary<string, uint>> cache = new Dictionary<string, Dictionary<string, uint>>();
            string command = Console.ReadLine();
            while (command != "thetinggoesskrra")
            {
                if (!command.Contains(">"))
                {
                    if (cache.ContainsKey(command))
                    {
                        Data.Add(command, cache[command]);
                    }
                    else
                    {
                        Data.Add(command, new Dictionary<string, uint>());
                    }
                }
                else
                {
                    string[] input = command.Split(new char[] { ' ', '-', '>', '|',',' }, StringSplitOptions.RemoveEmptyEntries);
                    if (Data.ContainsKey(input[2]))
                    {
                        Data[input[2]].Add(input[0], uint.Parse(input[1]));
                    }
                    else
                    {
                        if (!cache.ContainsKey(input[2]))
                        {
                            cache.Add(input[2], new Dictionary<string, uint>());
                            cache[input[2]].Add(input[0], uint.Parse(input[1]));
                        }
                        else
                        {
                            cache[input[2]].Add(input[0], uint.Parse(input[1]));
                        }
                    }
                }
                command = Console.ReadLine();
            }

            uint maxSum = 0;
            string keyWithMaxSum = string.Empty;
            foreach (var data in Data)
            {
                uint sum = 0;
                foreach (var d in Data[data.Key])
                {
                    sum += d.Value;
                }
                if (maxSum < sum)
                {
                    maxSum = sum;
                    keyWithMaxSum = data.Key;
                }
            }
            if (Data.Count > 0)
            {
                Console.WriteLine($"Data Set: {keyWithMaxSum}, Total Size: {maxSum}");
                foreach (var d in Data[keyWithMaxSum])
                {
                    Console.WriteLine($"$.{d.Key}");
                }
            }
        }

        }
    }

