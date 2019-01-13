using System;
using System.Collections.Generic;
using System.Linq;

namespace RoliTheCoder
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Dictionary<string, List<string>>> events = new Dictionary<int, Dictionary<string, List<string>>>();
            //ID -> (EventName -> List <Participants>)

            string input = Console.ReadLine();
            while (input != "Time for Code")
            {
                string[] command = input.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                int ID = int.Parse(command[0]);
                string EventName = command[1];
                List<string> participants = new List<string>();
                if (command[1].StartsWith("#"))
                {
                    if (!events.ContainsKey(ID))
                    {
                        bool nameIsTaken = true;
                        foreach (var name in events.Values)
                        {
                            if (name.ContainsKey(EventName))
                            {
                                nameIsTaken = false;
                                break;
                            }
                        }
                        if (nameIsTaken)
                        {
                            events.Add(ID, new Dictionary<string, List<string>>());
                            for (int i = 2; i < command.Length; i++)
                            {
                                if (command[i].StartsWith("@"))
                                {
                                    participants.Add(command[i]);
                                }
                            }
                            events[ID].Add(EventName, participants);
                        }
                    }
                    else
                    {

                        if (events[ID].ContainsKey(EventName))
                        {
                            for (int i = 2; i < command.Length; i++)
                            {
                                if (!events[ID][EventName].Contains(command[i]) && command[i].StartsWith("@"))
                                {
                                        events[ID][EventName].Add(command[i]);                                   
                                }
                            }
                        }

                    }
                }
                    input = Console.ReadLine();
                
            }



            foreach (var item in events.OrderByDescending(x => x.Value.Values.Sum(y => y.Count)).ToDictionary(x => x.Key, x => x.Value))
            {
                int id = item.Key;
                
                foreach (var Event in events[id])
                {
                    string eventName = Event.Key;
                    Console.WriteLine($"{Event.Key.Substring(1)} - {Event.Value.Count}");
                    foreach (var participant in events[id][eventName].OrderBy(x => x))
                    {
                        Console.WriteLine(participant);
                    }
                }
            }
        }
    }
}
