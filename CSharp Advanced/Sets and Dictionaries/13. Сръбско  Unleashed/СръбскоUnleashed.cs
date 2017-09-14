namespace _13.Сръбско__Unleashed
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class СръбскоUnleashed
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var regex = new Regex(@"(.*) @(.*) (\d+) (\d+)");
            var result = new Dictionary<string, Dictionary<string, long>>();


            while (input != "End")
            {
                var currentLine = regex.Split(input).Where(s => s != String.Empty).ToArray();
                if (currentLine.Length == 4)
                {
                    var name = currentLine[0];
                    var place = currentLine[1];
                    var ticketsPrice = int.Parse(currentLine[2]);
                    var ticketsCount = int.Parse(currentLine[3]);
                    var sum = ticketsCount * ticketsPrice;

                    if (!result.ContainsKey(place))
                    {
                        result.Add(place, new Dictionary<string, long>());
                        result[place].Add(name, sum);
                    }
                    else
                    {
                        if (!result[place].ContainsKey(name))
                        {
                            result[place].Add(name, sum);
                        }
                        else
                        {
                            result[place][name] += sum;
                        }
                    }
                }                
                input = Console.ReadLine();
            }
            foreach (var place in result)
            {
                Console.WriteLine(place.Key);

                foreach (var singer in place.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {singer.Key} -> {singer.Value}");
                }
            }
        }
    }
}

