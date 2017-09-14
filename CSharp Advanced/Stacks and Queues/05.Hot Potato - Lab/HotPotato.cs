namespace _05.Hot_Potato___Lab
{
    using System;
    using System.Collections.Generic;

    public class HotPotato
    {
        public static void Main()
        {
            var kids = Console.ReadLine().Split(' ');
            var number = int.Parse(Console.ReadLine());
            var queue = new Queue<string>(kids);

            while (queue.Count > 1)
            {
                for (int i = 0; i < number - 1; i++)
                {
                    var reminder = queue.Dequeue();
                    queue.Enqueue(reminder);
                }
                Console.WriteLine($"Removed {queue.Dequeue()}");
            }
            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}
