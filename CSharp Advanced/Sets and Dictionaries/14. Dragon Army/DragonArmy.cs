namespace _14.Dragon_Army
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DragonArmy
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var result = new Dictionary<string, SortedDictionary<string, Dictionary<string, int>>>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ').ToArray();
                if (input.Length == 5)
                {
                    var type = input[0];
                    var name = input[1];
                    var damage = 0;
                    var health = 0;
                    var armor = 0;
                    damage = input[2] == "null" ? 45 : int.Parse(input[2]);
                    health = input[3] == "null" ? 250 : int.Parse(input[3]);
                    armor = input[4] == "null" ? 10 : int.Parse(input[4]);

                    if (!result.ContainsKey(type))
                    {
                        result.Add(type, new SortedDictionary<string, Dictionary<string, int>>());
                        result[type].Add(name, new Dictionary<string, int>());
                        result[type][name].Add("damage", damage);
                        result[type][name].Add("health", health);
                        result[type][name].Add("armor", armor);
                    }
                    else
                    {
                        if (!result[type].ContainsKey(name))
                        {
                            result[type].Add(name, new Dictionary<string, int>());
                            result[type][name].Add("damage", damage);
                            result[type][name].Add("health", health);
                            result[type][name].Add("armor", armor);
                        }
                        else
                        {
                            result[type][name]["damage"] = damage;
                            result[type][name]["health"] = health;
                            result[type][name]["armor"] = armor;
                        }
                    }                
                }
            }
            foreach (var dragonType in result)
            {
                var averageDamage = dragonType.Value.Select(x => x.Value["damage"]).Average();
                var averageHealth = dragonType.Value.Select(x => x.Value["health"]).Average();
                var averageArmor = dragonType.Value.Select(x => x.Value["armor"]).Average();

                Console.WriteLine($"{dragonType.Key}::({averageDamage:0.00}/{averageHealth:0.00}/{averageArmor:0.00})");

                foreach (var dragon in dragonType.Value)
                {
                    Console.WriteLine($"-{dragon.Key} -> damage: {dragon.Value["damage"]}, health: {dragon.Value["health"]}, armor: {dragon.Value["armor"]}");
                }
            }
        }
    }
}
