namespace _4.Basic_Queue_Operations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class BasicQueueOperations
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ');
            var N = int.Parse(input[0]);
            var S = int.Parse(input[1]);
            var X = int.Parse(input[2]);

            var list = new List<int>(Console.ReadLine().Split(' ').Select(a => int.Parse(a)));
            var queue = new Queue<int>();

            for (int i = 0; i < N; i++)
            {
                queue.Enqueue(list[i]);
            }
            for (int i = 0; i < S; i++)
            {
                queue.Dequeue();
            }
            if (queue.Contains(X))
            {
                Console.WriteLine("true");
            }
            else if (queue.Count >= 1)
            {
                Console.WriteLine(queue.Min());
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
