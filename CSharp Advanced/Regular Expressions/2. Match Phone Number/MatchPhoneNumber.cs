namespace _2.Match_Phone_Number
{
    using System;
    using System.Text.RegularExpressions;

    public class MatchPhoneNumber
    {
        public static void Main()
        {
            var input = Console.ReadLine().Trim();
            var regex = new Regex(@"^\s*?\+359( |-)\d{1}\1\d{3}\1\d{4}\b");

            while (input != "end")
            {
                if (regex.IsMatch(input))
                {
                    Console.WriteLine(input);
                }
                input = Console.ReadLine().Trim();
            }
        }
    }
}

