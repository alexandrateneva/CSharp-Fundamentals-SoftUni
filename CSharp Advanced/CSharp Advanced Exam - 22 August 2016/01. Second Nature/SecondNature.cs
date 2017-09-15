namespace _01.Second_Nature
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SecondNature
    {
        public static void Main()
        {
            var flowers = new Stack<int>(Console.ReadLine()
               .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .Reverse());

            var buckets = new Stack<int>(Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

            var secondNature = new Queue<int>();

            while (flowers.Count > 0 && buckets.Count > 0)
            {
                if (buckets.Peek() == flowers.Peek())
                {
                    secondNature.Enqueue(flowers.Pop());
                    buckets.Pop();
                }
                else if (buckets.Peek() < flowers.Peek() && flowers.Count > 0 && buckets.Count > 0)
                {
                    var value = flowers.Pop() - buckets.Pop();
                    flowers.Push(value);
                }
                else if (buckets.Peek() > flowers.Peek() && flowers.Count > 0 && buckets.Count > 0)
                {
                    var value = buckets.Pop() - flowers.Pop();
                    buckets.Push(value);

                    if (buckets.Count > 1)
                    {
                        var lastValue = buckets.Pop();
                        var newValue = lastValue + buckets.Pop();
                        buckets.Push(newValue);
                    }
                }
            }
            if (flowers.Count > 0)
            {
                Console.WriteLine(string.Join(" ", new Stack<int>(flowers)));
            }
            else
            {
                Console.WriteLine(string.Join(" ", buckets));
            }
            if (secondNature.Count > 0)
            {
                Console.WriteLine(string.Join(" ", secondNature));
            }
            else
            {
                Console.WriteLine("None");
            }
        }
    }
}
