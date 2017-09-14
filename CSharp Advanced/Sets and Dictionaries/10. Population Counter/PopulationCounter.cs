namespace _10.Population_Counter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PopulationCounter
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var result = new Dictionary<string, Dictionary<string, long>>();
               
            while (input != "report")
            {
                var current = input.Split('|').ToArray();
                var city = current[0];
                var country = current[1];
                var population = int.Parse(current[2]);
                if (!result.ContainsKey(country))
                {
                    result[country] = new Dictionary<string, long>();
                    result[country][city] = population;
                }
                else
                {
                    if (!result[country].ContainsKey(city))
                    {
                        result[country][city] = population;
                    }
                    else
                    {
                        result[country][city] += population;
                    }
                }
                input = Console.ReadLine();
            }

            foreach (var country in result.OrderByDescending(x => x.Value.Values.Sum()))
            {
                Console.WriteLine($"{country.Key} (total population: {country.Value.Values.Sum()})");
                foreach (var city in country.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
                
            }
        }
    }
}
