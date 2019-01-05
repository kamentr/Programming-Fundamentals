using System;
using System.Collections.Generic;
using System.Linq;

namespace HandsOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> handsOfCards= new Dictionary<string, int>();

            string input = Console.ReadLine();
            while (input != "JOKER")
            {
                string name = input.Substring(0, input.IndexOf(':'));
                List<string> cards = input.Substring(input.IndexOf(':') + 1).Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Distinct().ToList();
                int power = getPower(cards);
                if (handsOfCards.Keys.Contains(name))
                {
                    handsOfCards[name] = 0;
                    handsOfCards[name] += power;
                }
                else
                {
                    handsOfCards.Add(name, power);
                }
  
                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(' ', handsOfCards));
        }




        private static int getPower(List<string> cards)
        {
            int power = 0;
            foreach (var card in cards)
            {
                switch ((int)card[0])
                {
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9':
                   
                        power += (int)card[0] -48;
                        break;
                    case '1':
                            power += 10;
                        break;
                    case 'J':
                        power += 11;
                        break;
                    case 'Q':
                        power += 12;
                        break;
                    case 'K':
                        power += 13;
                        break;
                    case 'A':
                        power += 14;
                        break;
                        
                }
                switch (card[card.Length - 1])
                {
                    case 'S':
                        power *= 4;
                        break;
                    case 'H':
                        power *= 3;
                        break;
                    case 'D':
                        power *= 2;
                        break;
                    case 'C':
                        power *= 1;
                        break;
                }
            }
                return power; 
            
        }
    }
}
