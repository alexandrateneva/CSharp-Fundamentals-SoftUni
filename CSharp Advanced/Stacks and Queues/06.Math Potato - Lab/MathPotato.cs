namespace _06.Math_Potato___Lab
{
    using System;
    using System.Collections.Generic;

    public class MathPotato
    {
        public static void Main()
        {
            var kids = Console.ReadLine().Split(' ');
            var number = int.Parse(Console.ReadLine());
            var queue = new Queue<string>(kids);
            var cicle = 1;

            while (queue.Count > 1)
            {
                for (int i = 0; i < number - 1; i++)
                {
                    var reminder = queue.Dequeue();
                    queue.Enqueue(reminder);
                }
                if (PrimeTool.IsPrime(cicle))
                {

                    Console.WriteLine($"Prime {queue.Peek()}");
                }
                else
                {

                    Console.WriteLine($"Removed {queue.Dequeue()}");
                }
                cicle++;
            }
            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }

    public static class PrimeTool
    {
        public static bool IsPrime(int candidate)
        {
            if ((candidate & 1) == 0)
            {
                if (candidate == 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            for (int i = 3; (i * i) <= candidate; i += 2)
            {
                if ((candidate % i) == 0)
                {
                    return false;
                }
            }
            return candidate != 1;
        }
    }

}
