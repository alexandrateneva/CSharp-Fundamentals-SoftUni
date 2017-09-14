namespace _06.Find_and_Sum_Integers___Lab
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FindAndSumIntegers
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ');
            var numbers = new List<long>();
            foreach (var element in input)
            {
                long number = 0;
                var parsed = long.TryParse(element, out number);
                if (parsed)
                {
                    numbers.Add(number);
                }
            }
            if (numbers.Count > 0)
            {
                Console.WriteLine(numbers.Sum());
            }
            else
            {
                Console.WriteLine("No match");
            }
        }
    }
}
