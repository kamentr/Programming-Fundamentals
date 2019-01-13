using System;
using System.Collections.Generic;
using System.Linq;

namespace Ladybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[] ladybirdIndex = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            List<byte> ladyBugs = new List<byte>(new byte[size]);
 

            for (int i = 0; i < ladybirdIndex.Length; i++)
            {
                if(ladybirdIndex[i] < ladyBugs.Count && ladybirdIndex[i]>=0)
                {
                    ladyBugs[ladybirdIndex[i]] = 1;
                }
            }
          //  Console.WriteLine("\n\nStart: \n" + String.Join(" ", ladyBugs));

            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] comm = command.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                switch (comm[1])
                {
                    case "right":
                        int index = int.Parse(comm[0]);
                        int steps = int.Parse(comm[2]);

                        if (index >= 0 && index < size && ladyBugs[index] == 1)
                        {
                                ladyBugs[index] = 0;
                                for (int j = index + steps; j < size; j += steps)
                                {
                                    if (ladyBugs[j] == 0)
                                    {
                                        ladyBugs[j] = 1;
                                    break;
                                    }
                                }
                         //   Console.WriteLine("Next Step: \n" + String.Join(" ", ladyBugs));
                        }
                        break;
                    case "left":
                        index = int.Parse(comm[0]);
                        steps = int.Parse(comm[2]);

                        if (index >= 0 && index < size && ladyBugs[index] == 1)
                        {

                                ladyBugs[index] = 0;
                                for (int j = index-steps; j >= 0; j -= steps)
                                {
                                    if (ladyBugs[j] == 0)
                                    {
                                        ladyBugs[j] = 1;
                                    break;
                                    }
                                }   
                          //  Console.WriteLine("Next Step: \n" + String.Join(" ", ladyBugs));
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid Command!");
                        break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", ladyBugs));
        }
    }
}
