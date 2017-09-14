namespace _9.Query_Mess
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Text.RegularExpressions;

    public class QueryMess
    {
        public static void Main()
        {
            var line = Console.ReadLine();
            var text = new StringBuilder();
            while (line != "END")
            {
                text.Append(line).Append(" ");
                line = Console.ReadLine();
            }
            var result = new Dictionary<string, List<string>>();
            var rows = text.ToString()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var row in rows)
            {
                var pairs = row.Split(new[] { '&', '?' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var pair in pairs)
                {
                    var tokens = pair.Split('=');
                    if (tokens.Length == 2)
                    {
                        var key = tokens[0].Replace("%20", " ");
                        key = key.Replace("+", " ").Trim();
                        key = Regex.Replace(key, @"\s+", " ");
                        var value = tokens[1].Replace("%20", " ");
                        value = value.Replace("+", " ").Trim();
                        value = Regex.Replace(value, @"\s+", " ");
                        if (!result.ContainsKey(key))
                        {
                            result.Add(key, new List<string>());
                        }
                        result[key].Add(value);
                    }
                }
                foreach (var pair in result)
                {
                    Console.Write($"{pair.Key}=[{string.Join(", ", pair.Value)}]");
                }
                Console.WriteLine();
                result.Clear();
            }
        }
    }
}
