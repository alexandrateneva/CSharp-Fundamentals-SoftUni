namespace _6.Reverse_And_Exclude
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ReverseAndExclude
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).Reverse().ToArray();
            var n = int.Parse(Console.ReadLine());
            var result = new Stack<int>();
            foreach (var number in numbers)
            {
                if (number % n != 0)
                {
                    result.Push(number);
                }
            }
            Console.WriteLine(string.Join(" ", result.Reverse().ToArray()));
        }
    }
}
