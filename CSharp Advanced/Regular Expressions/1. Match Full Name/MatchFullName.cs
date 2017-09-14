namespace _1.Match_Full_Name
{
    using System;
    using System.Text.RegularExpressions;

    public class MatchFullName
    {
       public static void Main()
        {
            var input = Console.ReadLine().Trim();
            var regex = new Regex(@"\b[A-Z][a-z]+ [A-Z][a-z]+\b");

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
