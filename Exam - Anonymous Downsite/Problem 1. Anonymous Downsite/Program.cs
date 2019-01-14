using System;
using System.Collections.Generic;

namespace Anonymous_Downsite
{
    class Program
    {
        public class Site
        {
            public string Name { get; set; }
            public ulong Visits { get; set; }
            public decimal CommercialPricePerVisit { get; set; }
            public decimal loss { get; set; }
        }

        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int securityKey = int.Parse(Console.ReadLine());
            List<Site> sites = new List<Site>();
            decimal totalSumLost = 0;
            for (int i = 0; i < N; i++)
            {
                string[] command = Console.ReadLine().Split(' ');
                Site site = new Site();
                site.Name = command[0];
                site.Visits = ulong.Parse(command[1]);
                site.CommercialPricePerVisit = decimal.Parse(command[2]);
                site.loss = site.Visits * site.CommercialPricePerVisit;
                sites.Add(site);
            }
            foreach (var site in sites)
            {
                Console.WriteLine(site.Name);
            }
            foreach (var site in sites)
            {
                totalSumLost += site.loss;
            }
            Console.WriteLine($"Total Loss: {totalSumLost:f20}");
            Console.WriteLine($"Security Token: {Math.Pow(securityKey,N)}");
        }

    }
}
