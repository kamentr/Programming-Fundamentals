using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace NetherRealms
{
    class Program
    {
        static void Main(string[] args)
        {
            string matchLetters = @"[A-Za-z]";
            string matchDigits = @"(-?\d*\.?\d*)";
            string matchSymbols = @"[\*\/]";
            string[] input = Console.ReadLine().Split(new char[] {' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            SortedDictionary<string, Dictionary<int, double>> demons = new SortedDictionary<string, Dictionary<int, double>>();
            
            foreach (var demon in input)
            {
                MatchCollection letters = Regex.Matches(demon, matchLetters);
                MatchCollection digits = Regex.Matches(demon, matchDigits);
                MatchCollection symbols = Regex.Matches(demon, matchSymbols);
                List<char[]> healthCalc = new List<char[]>();
                if (!demons.ContainsKey(demon))
                {
                    int health = 0;
                    double damage = 0;
                    demons.Add(demon, new Dictionary<int, double>());
                    foreach (Match match in letters)
                    {
                        char[] hp = match.ToString().ToCharArray();
                        health += (int)(hp[0]);
                    }

                    foreach (Match match in digits)
                    {
                        if (match.ToString() != "" && match.ToString() != "-" && match.ToString() != "+" && match.ToString() != ".")
                        {
                            string dmg = match.ToString();

                            if (dmg.EndsWith("."))
                            {
                                dmg = dmg.Substring(0, dmg.Length - 1);
                            }
                            if (dmg.StartsWith("-"))
                            {
                                damage -= double.Parse(dmg.Substring(1));
                            }
                            else
                            {
                                damage += double.Parse(dmg);
                            }
                        }
                    }
                    if (damage != 0)
                    {
                        foreach (Match symbol in symbols)
                        {
                            string sym = symbol.ToString();
                            if (sym == "/")
                            {
                                damage /= 2;
                            }
                            else
                            {
                                damage *= 2;
                            }
                        }
                    }

                    demons[demon].Add(health, damage);
                }
            }

            foreach (var demon in demons)
            {
                Console.Write(demon.Key);
                foreach (var HealthAndDamage in demons[demon.Key])
                {
                    Console.WriteLine($" - {HealthAndDamage.Key} health, {HealthAndDamage.Value:f2} damage ");
                }
            }
        }
    }
}
