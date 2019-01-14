using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split(' ').ToList();
            string command = Console.ReadLine();
            while (command!="3:1")
            {
                string[] comm = command.Split(' ');
                switch (comm[0])
                {
                    case "merge":
                        int startIndex = int.Parse(comm[1]);
                        int endIndex = int.Parse(comm[2]);
                        if (endIndex < startIndex)
                        {
                            Console.WriteLine("Error!");
                            break;
                        }
                        if(endIndex > words.Count)
                        {
                            endIndex = words.Count-1;
                        }
                        if(startIndex > words.Count)
                        {
                            startIndex = words.Count-1;
                        }else if(startIndex < 0)
                        {
                            startIndex = 0;
                        }
                        StringBuilder sb = new StringBuilder();                      
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            sb.Append(words[i]);                        
                        }
                        words.RemoveRange(startIndex, endIndex-startIndex+1);
                        string newWord = sb.ToString();
                        words.Insert(startIndex, newWord);                                                
                        break;

                    case "divide":
                        int wordIndex = int.Parse(comm[1]);
                        if (wordIndex > words.Count)
                        {
                            wordIndex = words.Count - 1;
                        }
                        int parts = int.Parse(comm[2]);
                        string word = words[wordIndex];
                        int count= word.Length / parts;
                        int index = 0;
                        if(word.Length % parts == 0)
                        {
                            for (int i = 0; i < word.Length; i += count)
                            {
                                words.Insert(wordIndex + index, word.Substring(i, count));
                                index++;
                            }
                            words.Remove(word);
                        }
                        else
                        {
                            for (int i = 0; i < word.Length; i += count)
                            {
                                if (i == word.Length - 2*count)
                                {
                                    words.Insert(wordIndex + index, word.Substring(i));
                                    break;
                                }
                                words.Insert(wordIndex + index, word.Substring(i, count));
                                index++;
                            }
                            words.Remove(word);
                        }
                        words.Remove(word);
                        break;
                    default:
                        Console.WriteLine("Invalid Command!");
                        break;
                }
                command = Console.ReadLine();
            }
            foreach (var word in words)
            {
                Console.Write(word + " ");
            }                
        }
    }
}
