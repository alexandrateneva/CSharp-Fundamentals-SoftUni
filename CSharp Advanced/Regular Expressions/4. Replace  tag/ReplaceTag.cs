namespace _4.Replace__tag
{
    using System;
    using System.Text.RegularExpressions;

    public class ReplaceTag
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            while (input != "end")
            {
                var pattern = @"<a.*?href.*?=(.*)>(.*?)<\/a>";
                var replace = @"[URL href=$1]$2[/URL]";

                var result = Regex.Replace(input, pattern, replace);
                Console.WriteLine(result);
                input = Console.ReadLine();
            }
        }
    }
}
