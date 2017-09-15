using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Cubic_Assault
{
    public class CubicAssault
    {
        public static void Main()
        {
            var result = new Dictionary<string, Dictionary<string, long>>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "Count em all")
                {
                    break;
                }

                var tokens = input.Split(new[] {"->"}, StringSplitOptions.RemoveEmptyEntries);
                var region = tokens[0].Trim();
                var type = tokens[1].Trim();
                var amount = long.Parse(tokens[2].Trim());
                if (!result.ContainsKey(region))
                {
                    result.Add(region, new Dictionary<string, long>());
                    result[region].Add("Green", 0);
                    result[region].Add("Red", 0);
                    result[region].Add("Black", 0);
                }
                result[region][type] += amount;
                ReorderTypes(result, region, type);
                }
            foreach (var region in result.OrderByDescending(reg => reg.Value["Black"]).ThenBy(reg => reg.Key.Length).ThenBy(reg => reg.Key))
            {
                Console.WriteLine(region.Key);
                foreach (var type in region.Value.OrderByDescending(s => s.Value).ThenBy(s => s.Key))
                {
                    Console.WriteLine($"-> {type.Key} : {type.Value}");
                }
            }
        }

        public static void ReorderTypes( Dictionary<string, Dictionary<string, long>> result, string region, string type )
        {
            var num = result[region][type] / 1000000;
            if (num > 0)
            {
                if (type == "Green")
                {
                    result[region][type] -= num * 1000000;
                    result[region]["Red"] += num;
                    if (result[region]["Red"] / 1000000 > 0 )
                    {
                        ReorderTypes(result, region, "Red");
                    }
                }
                else if (type == "Red")
                {
                    result[region][type] -= num * 1000000;
                    result[region]["Black"]+= num;
                }
            }
        }
    }
}
