namespace _11.Semantic_HTML
{
    using System;
    using System.Text.RegularExpressions;

    public class SemanticHTML
    {
        public static void Main()
        {
            var openPattern = @"<div\s*(.*)(?:id|class)\s*=\s*""(.*?)""(.*?)>";
            var closePattern = @"<\/div>\s*<!--\s*(.*?)\s*-->";
            var input = Console.ReadLine();

            while (input != "END")
            {
                var openTag = Regex.Match(input, openPattern);
                var closeTag = Regex.Match(input, closePattern);
                if (openTag.Success)
                {
                    input = $"{openTag.Groups[2].Value} {openTag.Groups[1].Value} {openTag.Groups[3].Value}".Trim();
                    input = "<" + Regex.Replace(input, @"\s+", " ") + ">";
                }

                if (closeTag.Success)
                {
                    input = $"</{closeTag.Groups[1].Value}>";
                }

                Console.WriteLine(input);
                input = Console.ReadLine();
            }
        }
    }
}
