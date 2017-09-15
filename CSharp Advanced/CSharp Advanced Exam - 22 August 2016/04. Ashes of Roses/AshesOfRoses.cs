namespace _04.Ashes_of_Roses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class AshesOfRoses
    {
        public static void Main()
        {
            var roses = new Dictionary<string, Dictionary<string, long>>();
            var regex = new Regex(@"^Grow <([A-Z][a-z]+)> <([A-Za-z0-9]+)> ([\d]+)$");
            var input = Console.ReadLine();
            while (input != "Icarus, Ignite!")
            {
                var match = regex.Match(input);
                if (match.Success)
                {
                    var region = match.Groups[1].Value;
                    var color = match.Groups[2].Value;
                    var amount = long.Parse(match.Groups[3].Value);
                    if (!roses.ContainsKey(region))
                    {
                        roses.Add(region, new Dictionary<string, long>());
                    }
                    if (!roses[region].ContainsKey(color))
                    {
                        roses[region].Add(color, 0);
                    }
                    roses[region][color] += amount;
                }
                input = Console.ReadLine();
            }
            foreach (var region in roses.OrderByDescending(n => n.Value.Values.Sum()).ThenBy(n => n.Key))
            {
                Console.WriteLine(region.Key);
                foreach (var color in region.Value.OrderBy(m => m.Value).ThenBy(m => m.Key))
                {
                    Console.WriteLine($"*--{color.Key} | {color.Value}");
                }
            }
        }
    }
}
