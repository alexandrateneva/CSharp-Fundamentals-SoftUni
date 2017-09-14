namespace _01.Match_Count___Lab
{
    using System;
    using System.Text.RegularExpressions;

    public class MatchCount
    {
        public static void Main()
        {
            var pattern = Console.ReadLine();
            var text = Console.ReadLine();
            var regex = new Regex(pattern);
            var matches = regex.Matches(text);
            Console.WriteLine(matches.Count);
        }
    }
}
