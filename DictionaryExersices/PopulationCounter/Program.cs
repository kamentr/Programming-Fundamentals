using System;
using System.Collections.Generic;
using System.Linq;

namespace PopulationCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,  Dictionary<string, int>> countries = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, int> countryPopulation = new Dictionary<string, int>();
            string[] input = Console.ReadLine().Split('|').ToArray();

            //Sofia | Bulgaria | 1000000
            //report
            
            while (input[0] != "report")
            {
                string city = input[0];
                string country = input[1];
                int population = int.Parse(input[2]);

                if(countries.Keys.Contains(country))
                {
                    countries[country].Add(city, population);
                        if (countryPopulation.Keys.Contains(country))
                        {
                        countryPopulation[country] += population;
                        }
                        else
                        {
                            countryPopulation[country] = population;
                        }
                }
                else
                {
                    countries[country] = new Dictionary<string, int>(){ { city, population } } ;
                }

                input = Console.ReadLine().Split('|').ToArray();
            }
                   foreach (var c in countries)
                {
                    Console.WriteLine(c.Key + "(total population: " + getPopulation(countries[c.Key]) + ")");
                    foreach (var City in countries[c.Key])
                    {
                        Console.WriteLine("=> " + City.Key +" : " + City.Value);
                    }
                }
        }

        private static int getPopulation(Dictionary<string, int> dictionary)
        {
            int sum = 0;
            foreach (var city in dictionary)
            {
                sum += city.Value;
            }
            return sum;
        }
    }
}
