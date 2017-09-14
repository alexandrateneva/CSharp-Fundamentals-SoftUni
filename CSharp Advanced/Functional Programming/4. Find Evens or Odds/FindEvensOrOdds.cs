namespace _4.Find_Evens_or_Odds
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FindEvensOrOdds
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var command = Console.ReadLine();
            var result = new Stack<int>();
            Predicate<int> isOdd = num => num % 2 != 0;
            Predicate<int> isEven = num => num % 2 == 0;
            for (int i = numbers[0]; i <= numbers[1]; i++)
            {
                if (command == "odd" && isOdd(i) || command == "even" && isEven(i))
                {
                    result.Push(i);
                }
            }
            Console.WriteLine(string.Join(" ", result.Reverse().ToArray()));
        }
    }
}
