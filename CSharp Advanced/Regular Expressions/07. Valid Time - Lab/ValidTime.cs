namespace _07.Valid_Time___Lab
{
    using System;
    using System.Text.RegularExpressions;

    public class ValidTime
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var regex = new Regex(@"^((1[0-2]|0[0-9]):([0-5][0-9]):([0-5][0-9]) (?:AM|PM))$");
            while (input != "END")
            {
                if (regex.IsMatch(input))
                {
                    Console.WriteLine("valid");
                }
                else
                {
                    Console.WriteLine("invalid");
                }
                input = Console.ReadLine();
            }
        }
    }
}
