namespace _01.Take_Two___Lab
{
    using System;
    using System.Linq;

    public class TakeTwo
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            numbers.Where(n => 10 <= n && n <= 20)
            .Distinct()
            .Take(2)
            .ToList()
            .ForEach(num => Console.Write(num + " "));
        }
    }
}
