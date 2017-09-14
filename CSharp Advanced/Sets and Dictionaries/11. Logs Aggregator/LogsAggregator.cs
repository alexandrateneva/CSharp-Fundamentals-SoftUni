namespace _11.Logs_Aggregator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LogsAggregator
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var result = new SortedDictionary<string, SortedDictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ').ToArray();
                var ip = input[0];
                var name = input[1];
                var time = int.Parse(input[2]);

                if (!result.ContainsKey(name))
                {
                    result.Add(name, new SortedDictionary<string, int>());
                    result[name].Add(ip, time);
                }
                else
                {
                    if (result[name].ContainsKey(ip))
                    {
                        result[name][ip] += time;
                    }
                    else
                    {
                        result[name].Add(ip, time);
                    }
                }
            }
            foreach (var man in result)
            {
                Console.Write($"{man.Key}: {man.Value.Values.Sum()} ");

                Console.WriteLine("[" + string.Join(", ", man.Value.Keys) + "]");
            }
        }
    }
}
