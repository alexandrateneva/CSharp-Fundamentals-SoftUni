﻿namespace _05.Extract_Tags___Lab
{
    using System;
    using System.Text.RegularExpressions;

    public class ExtractTags
    {
        public static void Main()
        {
            var regex = new Regex(@"<.+?>");
            var input = Console.ReadLine();

            while (input != "END")
            {
                var matches = regex.Matches(input);
                foreach (var match in matches)
                {
                    Console.WriteLine(match);
                }
                input = Console.ReadLine();
            }
        }
    }
}
