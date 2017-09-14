namespace _3.Series_of_Letters
{
    using System;
    using System.Text.RegularExpressions;

    public class SeriesOfLetters
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            //var result = new Stack<char>();
            //if (input.Length >= 1)
            //{
            //    result.Push(input[0]);
            //}
            //for (int i = 1; i < input.Length; i++)
            //{
            //    if (!input[i].Equals(result.Peek()))
            //    {
            //        result.Push(input[i]);
            //    }
            //}
            //Console.WriteLine(string.Join("", result.Reverse().ToArray()));

            var pattern = @"(.)\1+";
            Console.WriteLine(Regex.Replace(input, pattern, "$1"));
        }
    }
}
