using System;
using System.Collections.Generic;
using System.Linq;

namespace dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> stocks = new Dictionary<string, string>();
            stocks.Add("GM", "General Motors");
            stocks.Add("CAT", "Caterpillar");
            stocks.Add("AAPL", "Apple");
            stocks.Add("TWTR", "Twitter");
            stocks.Add("AMZN", "Amazon");
            stocks.Add("TSLA", "Tesla");

            List<(string ticker, int shares, double price)> purchases = new List<(string, int, double)>();

            purchases.Add((ticker:"GM" ,shares: 23,price: 21.54));
            purchases.Add((ticker:"GM" ,shares: 12,price: 21.60));
            purchases.Add((ticker: "CAT",shares: 20,price: 14.53));
            purchases.Add((ticker: "CAT",shares: 14,price: 15.74));
            purchases.Add((ticker: "AAPL",shares: 67,price: 25.65));
            purchases.Add((ticker: "AAPL",shares: 54,price: 27.32));
            purchases.Add((ticker: "TWTR",shares: 13,price: 15.67));
            purchases.Add((ticker: "TWTR",shares: 11,price: 15.63));
            purchases.Add((ticker: "AMZN",shares: 22,price: 18.43));
            purchases.Add((ticker: "AMZN",shares: 25,price: 18.78));
            purchases.Add((ticker: "TSLA",shares: 57,price: 24.76));
            purchases.Add((ticker: "TSLA",shares: 53,price: 24.89));

            Dictionary<string, double> ownershipReport = new Dictionary<string, double>();

            foreach ((string ticker, int shares, double price) purchase in purchases)
                {
                    string companyName = stocks[purchase.ticker];
                    double stockValuation = purchase.shares * purchase.price;
                    // Does the company name key already exist in the report dictionary?
                    if (!ownershipReport.ContainsKey(companyName)) {
                    // Add the new key and set its value    
                    ownershipReport.Add(companyName, stockValuation);
                    } else {
                    // Update the total valuation
                    ownershipReport[companyName] += stockValuation; 
                    }

                }
            foreach (KeyValuePair<string, double> item in ownershipReport)
            {
            Console.WriteLine(item);
            }
        }
    }
}
