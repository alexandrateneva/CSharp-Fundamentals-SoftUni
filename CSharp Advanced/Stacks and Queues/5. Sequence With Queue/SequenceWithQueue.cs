namespace _5.Sequence_With_Queue
{
    using System;
    using System.Collections.Generic;

    public class SequenceWithQueue
    {
        public static void Main()
        {
            var num = long.Parse(Console.ReadLine());
            var queue = new Queue<long>();
            queue.Enqueue(num);

            var queue2 = new Queue<long>();
            queue2.Enqueue(num);

            var a = queue.Peek();

            while (queue.Count < 50)
            {
                var b = a + 1;
                queue.Enqueue(b);
                queue2.Enqueue(b);
                var c = 2 * a + 1;
                queue.Enqueue(c);
                queue2.Enqueue(c);
                var d = a + 2;
                queue.Enqueue(d);
                queue2.Enqueue(d);

                queue2.Dequeue();
                a = queue2.Peek();
            }
            for (int i = 0; i < 50; i++)
            {
                Console.Write(queue.Dequeue() + " ");
            }
            Console.WriteLine();
        }
    }
}
