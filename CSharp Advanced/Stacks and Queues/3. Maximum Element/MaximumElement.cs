namespace _3.Maximum_Element
{
    using System;
    using System.Collections.Generic;

    public class MaximumElement
    {
        public static void Main()
        {
            var num = int.Parse(Console.ReadLine());
            var stack = new Stack<int>();
            var maxValues = new Stack<int>();
            maxValues.Push(0);

            for (int i = 0; i < num; i++)
            {
                var input = Console.ReadLine().Split(' ');

                switch (input[0])
                {
                    case "1":
                        var number = int.Parse(input[1]);
                        stack.Push(number);
                        if (number > maxValues.Peek())
                        {
                            maxValues.Push(number);
                        }
                        break;
                    case "2":
                        if (stack.Peek() == maxValues.Peek())
                        {
                            maxValues.Pop();
                        }
                        stack.Pop();
                        break;
                    case "3": Console.WriteLine(maxValues.Peek()); break;
                }

            }
        }
    }
}
