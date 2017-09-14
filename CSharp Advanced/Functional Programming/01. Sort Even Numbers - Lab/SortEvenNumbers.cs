namespace _01.Sort_Even_Numbers___Lab
{
    using System;
    using System.Linq;

    public class SortEvenNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse);

            var evenNums = numbers.Where(n => n % 2 == 0);
            Console.WriteLine(string.Join(", ", evenNums.OrderBy(n => n)));
        }
    }
}
