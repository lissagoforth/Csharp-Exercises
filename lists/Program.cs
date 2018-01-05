using System;
using System.Linq;
using System.Collections.Generic;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            //define planetList
            List<string> planetList = new List<string>() { "Mercury", "Mars" };
            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            //define lastPlanets
            List<string> lastPlanets = new List<string>()
            {
                "Uranus",
                "Neptune"
            };

            //add lastPlanets to planetList
            planetList.AddRange(lastPlanets);
            //add Venus to planetList
            planetList.Insert(1, "Venus");
            //add Earth to planetList
            planetList.Insert(2, "Earth");
            //add Pluto to planetList
            planetList.Add("Pluto");

            List<string> rockyPlanets = planetList.GetRange(0, 4);
            {
                //Pluto isn't a planet, take out of planetList
                planetList.Remove("Pluto");
            };

            foreach (string planet in planetList)
            {
                // Console.WriteLine(planet);  
            }

            // Create spacecraft list
            List<Dictionary<string, List<string>>> spacecraft = new List<Dictionary<string, List<string>>>();

            // Mariner info
            string mariner = "Mariner 10";
            List<string> marinerDestinations = new List<string> { "Mercury" };

            Dictionary<string, List<string>> mariner10 = new Dictionary<string, List<string>>();
            mariner10.Add(mariner, marinerDestinations);

            // Voyager1 info
            string voyager1 = "Voyager 1";
            List<string> voyager1Destinations = new List<string>{
                "Jupiter", "Saturn"
            };
            Dictionary<string, List<string>> voyager1Dict = new Dictionary<string, List<string>>();
            voyager1Dict.Add(voyager1, voyager1Destinations);

            // Voyager2 info
            string voyager2 = "Voyager 2";
            List<string> voyager2Destinations = new List<string>{
                "Jupiter", "Saturn", "Uranus", "Neptune"
            };
            Dictionary<string, List<string>> voyager2Dict = new Dictionary<string, List<string>>();
            voyager2Dict.Add(voyager2, voyager2Destinations);
    

            //Add all of the different spacecrafts to the spacecraft list
            spacecraft.Add(mariner10);
            spacecraft.Add(voyager1Dict);
            spacecraft.Add(voyager2Dict);

            foreach (string planet in planetList)
            {
                string satellite = "";
                foreach (Dictionary<string, List<string>> craft in spacecraft)
                {
                    foreach (KeyValuePair<string, List<string>> craftKVP in craft)
                    {
                        // Console.WriteLine(String.Join("," , craftKVP.Value));
                        if (craftKVP.Value.Contains(planet))
                        {
                            satellite += craftKVP.Key + " ";
                        }

                    };
                };
                        Console.WriteLine($"{planet}: {satellite}");
            }
        }
    }
}