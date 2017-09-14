namespace _02.Vowel_Count___Lab
{
    using System;
    using System.Text.RegularExpressions;

    public class VowelCount
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var regex = new Regex(@"[AaEeIiOoUuYy]");
            var matches = regex.Matches(text);
            Console.WriteLine($"Vowels: {matches.Count}");
        }
    }
}
