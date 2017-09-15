namespace _03.Basic_Markup_Language
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class BasicMarkupLanguage
    {
        public static void Main()
        {
            var regex = new Regex(@"^\s*?<\s*?(reverse|inverse)\s+?content\s*?=\s*?""(.+?)""\s*?\/\s*?>\s*?$");
            var repeatRegex =
                new Regex(@"^\s*?<\s*?repeat\s+?value\s*?=\s*?""(.+?)""\s+?content\s*?=\s*?""(.+?)""\s*?\/\s*?>\s*?$");
            var input = Console.ReadLine();
            var couner = 1;
            while (input.Trim() != "<stop/>")
            {
                string result = null;
                var list = new List<char>();
                Match match = regex.Match(input);
                Match repeatMatch = repeatRegex.Match(input);

                if (match.Success)
                {
                    var operation = match.Groups[1].Value;
                    var content = match.Groups[2].Value.ToCharArray();
                    var onlyChar = content.ToString().Trim();
                    switch (operation)
                    {
                        case "inverse":
                            foreach (var symbol in content)
                            {
                                if (char.IsLetter(symbol))
                                {
                                    if (char.IsLower(symbol))
                                    {
                                        var letterToUp = char.ToUpper(symbol);
                                        list.Add(letterToUp);
                                    }
                                    else
                                    {
                                        var letterToLow = char.ToLower(symbol);
                                        list.Add(letterToLow);
                                    }
                                }
                                else
                                {
                                    list.Add(symbol);
                                }
                            }
                            result = string.Join("", list.ToArray());
                            break;
                        case "reverse": Array.Reverse(content); result = new string(content); break;
                    }
                    if (onlyChar.Length > 0)
                    {
                        Console.WriteLine($"{couner}. {result}");
                        couner++;
                    }
                }
                else if (repeatMatch.Success)
                {
                    var ways = int.Parse(repeatMatch.Groups[1].Value.Trim());
                    var content = repeatMatch.Groups[2].Value;
                    var onlyChar = content.Trim();
                    if (onlyChar.Length > 0)
                    {
                        for (int i = 0; i < ways; i++)
                        {
                            Console.WriteLine($"{couner}. {content}");
                            couner++;
                        }
                    }
                }
                input = Console.ReadLine();
            }
        }
    }
}
