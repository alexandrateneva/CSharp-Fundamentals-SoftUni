namespace _9.List_Of_Predicates
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ListOfPredicates
    {
        public static void Main()
        {
            var endNum = int.Parse(Console.ReadLine());
            var dividers = Console.ReadLine()
                .Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            if (endNum < 0)
            {
                return;
            }
            var result = new Stack<int>();
            var numbers = Enumerable.Range(1, endNum).ToArray();
            Func<int, int, bool> filter = (n, m) => n % m == 0;
            foreach (var number in numbers)
            {
                var isDivisible = true;
                foreach (var divider in dividers)
                {
                    if (!filter(number, divider))
                    {
                        isDivisible = false;
                        break;
                    }
                }
                if (isDivisible)
                {
                    result.Push(number);
                }
            }
            Console.WriteLine(string.Join(" ", result.Reverse().ToArray()));
        }
    }
}
