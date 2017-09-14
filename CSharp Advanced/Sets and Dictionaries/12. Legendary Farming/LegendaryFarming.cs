namespace _12.Legendary_Farming
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LegendaryFarming
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var keyMaterials = new Dictionary<string, int>();
            keyMaterials.Add("shards", 0);
            keyMaterials.Add("fragments", 0);
            keyMaterials.Add("motes", 0);
            var junkMaterials = new Dictionary<string, int>();
            var noWin = true;
            string winner = null;

            while (noWin)
            {
                var current = input.Split(' ').ToArray();

                for (int i = 0; i < current.Length; i++)
                {
                    if (i % 2 != 0 && keyMaterials.ContainsKey(current[i].ToLower()))
                    {
                        keyMaterials[current[i].ToLower()] += int.Parse(current[i - 1]);
                        if (keyMaterials[current[i].ToLower()] >= 250)
                        {
                            switch (current[i].ToLower())
                            {
                                case "shards": winner = "Shadowmourne"; break;
                                case "fragments": winner = "Valanyr"; break;
                                case "motes": winner = "Dragonwrath"; break;
                            }

                            keyMaterials[current[i].ToLower()] -= 250;
                            noWin = false;
                            break;
                        }
                    }
                    else if (i % 2 != 0 && !junkMaterials.ContainsKey(current[i].ToLower()))
                    {
                        junkMaterials.Add(current[i].ToLower(), int.Parse(current[i - 1]));
                    }
                    else if (i % 2 != 0 && junkMaterials.ContainsKey(current[i].ToLower()))
                    {
                        junkMaterials[current[i].ToLower()] += int.Parse(current[i - 1]);
                    }
                }
                if (noWin)
                {
                    input = Console.ReadLine();
                }
            }
            Console.WriteLine($"{winner} obtained!");
            foreach (var material in keyMaterials.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{material.Key}: {material.Value}");
            }
            foreach (var material in junkMaterials.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{material.Key}: {material.Value}");
            }
        }
    }
}
