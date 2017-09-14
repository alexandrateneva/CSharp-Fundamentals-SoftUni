namespace _05.Min_Even_Number___Lab
{
    using System;
    using System.Linq;

    public class MinEvenNumber
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .Where(n => n % 2 == 0)
                .ToList();
            if (numbers.Count < 1)
            {
                Console.WriteLine("No match");
                return;
            }
            var min = numbers.Min();
            Console.WriteLine(min.ToString("F2"));
        }
    }
}
