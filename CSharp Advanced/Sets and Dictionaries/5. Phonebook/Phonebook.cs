namespace _5.Phonebook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Phonebook
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var phonebook = new Dictionary<string, string>();

            while (input != "search")
            {
                var result = input.Split('-');

                if (result[0].Any() && result[1].Any())
                {
                    var name = result[0];
                    var number = result[1];

                    phonebook[name] = number;
                }
                input = Console.ReadLine();
            }
            input = Console.ReadLine();
            while (input != "stop")
            {
                if (phonebook.ContainsKey(input))
                {
                    Console.WriteLine($"{input} -> {phonebook[input]}");
                }
                else
                {
                    Console.WriteLine($"Contact {input} does not exist.");
                }
                input = Console.ReadLine();
            }
        }
    }
}
