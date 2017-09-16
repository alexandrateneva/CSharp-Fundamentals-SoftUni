namespace _1.Generic_Box
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var list = new List<Box<double>>();
            for (int i = 0; i < n; i++)
            {
                var currentInput = double.Parse(Console.ReadLine());
                var box = new Box<double>(currentInput);
                list.Add(box);
            }

            var elementToCompare = new Box<double>(double.Parse(Console.ReadLine()));

            var counter = 0;
            foreach (var element in list)
            {
                if (element.CompareTo(elementToCompare) > 0)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);

            //var indexes = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            //var index1 = indexes[0];
            //var index2 = indexes[1];

            //Swap(list, index1, index2);

            //foreach (var element in list)
            //{
            //    Console.WriteLine(element);
            //}
        }

        public static void Swap<T>(List<T> list, int index1, int index2)
        {
            T element1 = list[index1];
            T element2 = list[index2];

            list.Insert(index1, element2);
            list.RemoveAt(index1 + 1);
            list.Insert(index2, element1);
            list.RemoveAt(index2 + 1);
        }
    }
}
