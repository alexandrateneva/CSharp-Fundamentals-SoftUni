namespace _3.Froggy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var lake = new Lake(numbers);
            var result = new List<int>();

            foreach (var stone in lake)
            {
                result.Add(stone);
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
