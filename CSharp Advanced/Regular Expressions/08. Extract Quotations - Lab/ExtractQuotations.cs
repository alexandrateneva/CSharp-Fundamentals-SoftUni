namespace _08.Extract_Quotations___Lab
{
    using System;
    using System.Text.RegularExpressions;

    public class ExtractQuotations
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var regex = new Regex(@"('|"")(.*?)\1");
            var matches = regex.Matches(text);
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Groups[2].Value);
            }
        }
    }
}
