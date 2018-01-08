using System;
using System.Collections.Generic;
using System.Linq;

namespace ListsAndDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given the following list:
            // Iterate over the list and write only odd numbers to the console
            // The output should be on the same line.
            List<int> numbers = new List<int>(){1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20};

            // Add some more integers to the list
            numbers.Add(21);
            numbers.Add(22);
            numbers.Add(23);
            numbers.Add(24);
            numbers.Add(25);
            
            foreach (int n in numbers){
                if(n % 2 != 0) {
                    Console.WriteLine(n + " ");
                }
            }

            // Given the following dictionary:
            Dictionary<string, int> transports = new Dictionary<string, int>(){{"bicycle", 2}};

            // Add some more items to the dictionary.
            // Iterate over the dictionary and write 'A ____ has ____ wheels' to the console.
            // Each transport should be on a new line.
            transports.Add("car", 4);
            transports.Add("Vespa", 2);
            transports.Add("tricycle", 3);
            transports.Add("unicycle", 1);

            foreach (KeyValuePair<string, int> x in transports) {
                Console.WriteLine($"A {x.Key} has {x.Value} wheels.");
            }
            
        }
    }
}
