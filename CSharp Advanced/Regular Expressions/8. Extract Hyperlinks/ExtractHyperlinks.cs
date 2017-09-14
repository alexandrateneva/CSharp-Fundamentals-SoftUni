namespace _8.Extract_Hyperlinks
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    public class ExtractHyperlinks
    {
        public static void Main()
        {
            var regex = new Regex(@"<a[^><]*?href\s*=([\s""'])*(.*?)(\1|>).*?<\/a>");
            var text = new StringBuilder();
            var line = Console.ReadLine();
            while (line != "END")
            {
                text.Append(line).Append(" ");
                line = Console.ReadLine();
            }
            var matches = regex.Matches(text.ToString());
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Groups[2].Value);
            }
        }
    }
}
