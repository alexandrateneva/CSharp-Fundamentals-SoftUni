namespace _03.Jedi_Code_X
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public class JediCode
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var jedis = new List<string>();
            var messages = new List<string>();

            var sb = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                sb.Append(Console.ReadLine());
            }

            var firstPattern = Console.ReadLine();
            var secondPattern = Console.ReadLine();
            var indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();


            var text = sb.ToString();
            var matchesName = Regex.Matches(text, @"(" + firstPattern + ")([a-zA-Z]{" + firstPattern.Length + "})(?![a-zA-Z])");
            var matchesMessage = Regex.Matches(text, @"(" + secondPattern + @")([a-zA-Z\d]{" + secondPattern.Length + @"})(?![a-zA-Z\d])");

            foreach (Match matchName in matchesName)
            {
                jedis.Add(matchName.Groups[2].Value);
            }
            foreach (Match matchMessage in matchesMessage)
            {
                messages.Add(matchMessage.Groups[2].Value);
            }

            int index = 0;
            foreach (var jedi in jedis)
            {
                for (int i = index; i < indexes.Length; i++)
                {
                    index++;
                    if (messages.Count >= indexes[i])
                    {
                        Console.WriteLine($"{jedi} - {messages[indexes[i] - 1]}");
                        break;
                    }
                }
            }
        }
    }
}
