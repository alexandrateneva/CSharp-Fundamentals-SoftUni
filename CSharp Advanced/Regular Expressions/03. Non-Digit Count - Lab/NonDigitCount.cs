﻿namespace _03.Non_Digit_Count___Lab
{
    using System;
    using System.Text.RegularExpressions;

    public class NonDigitCount
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var regex = new Regex(@"[^0-9]");
            var matches = regex.Matches(text);
            Console.WriteLine($"Non-digits: {matches.Count}");
        }
    }
}
