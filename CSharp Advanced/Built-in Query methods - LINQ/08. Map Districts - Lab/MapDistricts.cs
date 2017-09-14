namespace _08.Map_Districts___Lab
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MapDistricts
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var bound = long.Parse(Console.ReadLine());
            var cities = new Dictionary<string, List<long>>();
            foreach (var part in input)
            {
                var parts = part.Split(':').ToList();
                var city = parts[0];
                var population = long.Parse(parts[1]);
                if (!cities.ContainsKey(city))
                {
                    cities.Add(city, new List<long>());
                }
                cities[city].Add(population);
            }
            foreach (var city in cities.Where(n => n.Value.Sum() >= bound).OrderByDescending(n => n.Value.Sum()).ToList())
            {
                var district = city.Value.OrderByDescending(n => n).Take(5).ToList();
                Console.WriteLine($"{city.Key}: {string.Join(" ", district)}");
            }
        }
    }
}
