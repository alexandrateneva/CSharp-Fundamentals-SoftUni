namespace _3.Periodic_Table
{
    using System;
    using System.Collections.Generic;

    public class PeriodicTable
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var elements = new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {
                var current = Console.ReadLine()
                    .Trim()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < current.Length; j++)
                {
                    elements.Add(current[j]);
                }
            }
            Console.WriteLine(string.Join(" ", elements));
        }
    }
}
