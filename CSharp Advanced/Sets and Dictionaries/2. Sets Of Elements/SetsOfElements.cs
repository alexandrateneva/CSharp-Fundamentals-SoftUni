namespace _2.Sets_Of_Elements
{
    using System;
    using System.Collections.Generic;

    public class SetsOfElements
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ');
            var firstSet = new HashSet<int>();
            var secondSet = new HashSet<int>();

            for (int i = 0; i < int.Parse(input[0]); i++)
            {
                var current = int.Parse(Console.ReadLine());
                if (firstSet.Contains(current))
                {
                    firstSet.Remove(current);
                }
                else
                {
                    firstSet.Add(current);
                }
            }
            for (int i = 0; i < int.Parse(input[1]); i++)
            {
                var current = int.Parse(Console.ReadLine());
                if (secondSet.Contains(current))
                {
                    secondSet.Remove(current);
                }
                else
                {
                    secondSet.Add(current);
                }
            }
            foreach (var num in firstSet)
            {
                if (secondSet.Contains(num))
                {
                    Console.Write($"{num} ");
                }
            }
            Console.WriteLine();
        }
    }
}
