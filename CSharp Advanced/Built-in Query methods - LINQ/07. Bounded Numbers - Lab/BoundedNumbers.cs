namespace _07.Bounded_Numbers___Lab
{
    using System;
    using System.Linq;

    public class BoundedNumbers
    {
        public static void Main()
        {
            var bounds = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var min = Math.Min(bounds[0], bounds[1]);
            var max = Math.Max(bounds[0], bounds[1]);
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var result = numbers.Where(n => min <= n && n <= max).ToList();
            if (result.Count > 0)
            {

                Console.WriteLine(string.Join(" ", result));
            }
        }
    }
}
