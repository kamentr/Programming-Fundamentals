using System;
using System.Collections.Generic;
using System.Linq;

namespace DictionaryExersices
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, string> phoneBook = new SortedDictionary<string, string>();
            List<string> command = Console.ReadLine().Split(' ').ToList();
            
            while(command[0] != "END" && command[0] != "end")
            {
                switch (command[0])
                {
                    case "A":
                        string name = command[1];
                        string phoneNumber = command[2];
                        if (phoneBook.Keys.Contains(name))
                        {
                            phoneBook[name] = phoneNumber;
                        }else
                        phoneBook.Add(name, phoneNumber);
                        break;
                    case "S":
                        name = command[1];
                        if (phoneBook.Keys.Contains(name))
                        {
                            Console.WriteLine(name + " -> " + phoneBook[name]);
                        }
                        else
                        {
                            Console.WriteLine("Contact " + name + " does not exist.");
                        }
                        break;
                    case "ListAll":
                        
                        foreach (var contact in phoneBook)
                        {
                            Console.WriteLine(contact.Key + " -> " + contact.Value);
                        }
                            break;
                    default:
                        Console.WriteLine("Invalid Command!");
                        break;
                }
                command = Console.ReadLine().Split(' ').ToList();
            }
        }
    }
}
