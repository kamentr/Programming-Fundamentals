using System;
using System.Collections.Generic;
using System.Linq;

namespace Biliard
{
    class Customer
    {
        public string Name { get; set; }
        public Dictionary<string, int> ShopList { get; set; }
        public decimal bill { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> shop = new Dictionary<string, decimal>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] comm = Console.ReadLine().Split('-', StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (!shop.ContainsKey(comm[0]))
                {
                    shop.Add(comm[0], decimal.Parse(comm[1]));
                }
                else
                {
                    shop[comm[0]] = decimal.Parse(comm[1]);
                }
            }
            List<Customer> customers = new List<Customer>();
            string command = Console.ReadLine();
            while(command != "end of clients")
            {
                string[] comm = command.Split(new char[] { '-', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                Customer customer = new Customer();
                customer.Name = comm[0];
                
                if (shop.ContainsKey(comm[1]))
                {
                    customer.ShopList = new Dictionary<string, int>();
                    customer.ShopList.Add(comm[1], int.Parse(comm[2]));
                }
                    customers.Add(customer);

                command = Console.ReadLine();
            }
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Name);
                foreach (KeyValuePair<string,int> item in customer.ShopList)
                {
                    Console.WriteLine($"--{item.Key} - {item.Value}");
                }
                Console.WriteLine($"Bill: {customer.bill:F2}");
            }
        }
    }
}
