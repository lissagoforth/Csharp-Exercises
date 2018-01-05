using System;
using System.Collections.Generic;
using System.Linq;

namespace tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            List<(string product, double amount, int quantity)> transactions = new List<(string, double, int)>();
            transactions.Add(("Hat", 6.99, 8));
            transactions.Add(("Gloves", 5.99, 5));
            transactions.Add(("Scarf", 11.99, 6));
            transactions.Add(("Jacket", 58.99, 3));
            transactions.Add(("Boots", 74.99, 1));
            transactions.Add(("Wool Socks", 4.99, 10));
            
            int itemsSold = 0;
            double dailyRevenue = 0;
            
            foreach ((string product, double amount, int quantity) t in transactions)
            {
               // Logic goes here to look up quantity and amount in each transaction
                dailyRevenue += (t.amount * t.quantity);
                itemsSold += t.quantity;

            }           
            Console.WriteLine($@"
            Items sold today: {itemsSold}
            Total Revenue: ${dailyRevenue}"
            );
        }
    }
}
