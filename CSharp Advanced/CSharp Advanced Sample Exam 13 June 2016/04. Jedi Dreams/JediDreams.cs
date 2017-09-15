namespace _04.Jedi_Dreams
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class JediDreams
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var result = new Dictionary<string, List<string>>();
            var regex = new Regex(@"([a-zA-Z]*[A-Z]+[a-zA-Z]*)\s*\(");
            string methodName = null;
            for (int i = 0; i < n; i++)
            {
                var inputLine = Console.ReadLine();
                var matches = regex.Matches(inputLine);
                if (matches.Count > 0)
                {
                    if (inputLine.Trim().StartsWith("static"))
                    {
                        methodName = regex.Match(inputLine).Groups[1].Value;
                        result.Add(methodName, new List<string>());
                    }
                    else
                    {
                        foreach (Match match in matches)
                        {
                            result[methodName].Add(match.Groups[1].Value);
                        }
                    }
                }
            }
            foreach (var staticMethod in result.OrderByDescending(res => res.Value.Count).ThenBy(res => res.Key))
            {
                if (staticMethod.Value.Count > 0)
                {
                    Console.WriteLine($"{staticMethod.Key} -> {staticMethod.Value.Count} -> {string.Join(", ", staticMethod.Value.OrderBy(name => name))}");
                }
                else
                {
                    Console.WriteLine($"{staticMethod.Key} -> None");
                }
            }
        }
    }
}
