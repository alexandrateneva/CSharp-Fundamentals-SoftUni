namespace _8.Custom_Comparator
{
    using System;
    using System.Linq;

    public class CustomComparator
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).OrderBy(n => n);
            var oddNums = numbers.Where(n => n % 2 != 0);
            var evenNums = numbers.Where(n => n % 2 == 0);
            Console.Write(string.Join(" ", evenNums) + " ");
            Console.WriteLine(string.Join(" ", oddNums));
        }
    }
}
