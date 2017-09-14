namespace _5.Extract_Emails
{
    using System;
    using System.Text.RegularExpressions;

    public class ExtractEmails
    {
        public static void Main()
        {
            var regex = new Regex(@"(\s|^)[A-Za-z0-9]+[-_\.]*[A-Za-z0-9]+@[A-Za-z]+[\-]*[A-Za-z]+(?:\.[A-Za-z]+)+\b");
            var input = Console.ReadLine();
            var matches = regex.Matches(input);
            foreach (var match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}
