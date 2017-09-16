namespace _3.Telephony.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using _3.Telephony.Interfaces;

    public class Smartphone : IBrowsable, ICallable
    {
        public void Browse(List<string> URLs)
        {
            var regex = new Regex("\\d+");
            foreach (var URL in URLs)
            {
                if (regex.IsMatch(URL))
                {
                    Console.WriteLine("Invalid URL!");
                }
                else
                {
                    Console.WriteLine($"Browsing: {URL}!");
                }
            }
        }

        public void Call(List<string> numbers)
        {
            var regex = new Regex("[^\\d+]+");
            foreach (var number in numbers)
            {
                if (regex.IsMatch(number))
                {
                    Console.WriteLine("Invalid number!");
                }
                else
                {
                    Console.WriteLine($"Calling... {number}");
                }
            }
        }
    }
}
