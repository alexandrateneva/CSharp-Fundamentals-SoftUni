namespace _03.Group_Numbers___Lab
{
    using System;
    using System.Linq;

    public class GroupNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new string[] {", "}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var remainderZero = numbers.Where(n => Math.Abs(n) % 3 == 0);
            var remainderOne = numbers.Where(n => Math.Abs(n) % 3 == 1);
            var remainderTwo = numbers.Where(n => Math.Abs(n) % 3 == 2);

            Console.WriteLine(string.Join(" ",remainderZero));
            Console.WriteLine(string.Join(" ", remainderOne));
            Console.WriteLine(string.Join(" ", remainderTwo));
        }
    }
}
