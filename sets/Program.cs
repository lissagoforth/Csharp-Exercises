using System;
using System.Collections.Generic;
using System.Linq;

namespace sets
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> Showroom = new HashSet<string>();
            Showroom.Add("Agera");
            Showroom.Add("NSX");
            Showroom.Add("Spider");
            Showroom.Add("R8");
            Showroom.Add("Aventador");

            Console.WriteLine(Showroom.Count());
            
            Showroom.Add("R8");
            Console.WriteLine(Showroom.Count());

            HashSet<string> UsedLot = new HashSet<string>();
            UsedLot.Add("Corolla");
            UsedLot.Add("Camry");

            Showroom.UnionWith(UsedLot);
            Console.WriteLine(Showroom.Count());


            Showroom.Remove("Corolla");
            Console.WriteLine(Showroom.Count());

            HashSet<string> Junkyard = new HashSet<string>();
            Junkyard.Add("Camry");
            Junkyard.Add("Spider");
            Junkyard.Add("Maxima");
            Junkyard.Add("Fusion");
            Junkyard.Add("El Camino");
            Junkyard.Add("Mustang");
            Junkyard.Add("R8");

            Showroom.IntersectWith(Junkyard);
            foreach (string car in Showroom)
            {
                Console.WriteLine(car);
            }

            Showroom.UnionWith(Junkyard);
            Showroom.Remove("El Camino");

            foreach (string car in Showroom)
            {
                Console.WriteLine(car);
            }
            

        }
    }
}
