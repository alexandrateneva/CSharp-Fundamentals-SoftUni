namespace _04.Extract_Integer_Numbers___Lab
{
    using System;
    using System.Text.RegularExpressions;

    public class ExtractIntegerNumbers
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var regex = new Regex(@"\d+");
            var matches = regex.Matches(text);
            foreach (var match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}
