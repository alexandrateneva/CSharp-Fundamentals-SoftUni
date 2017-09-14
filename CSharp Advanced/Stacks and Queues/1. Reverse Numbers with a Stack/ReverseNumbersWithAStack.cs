namespace _1.Reverse_Numbers_with_a_Stack
{
    using System;
    using System.Collections.Generic;

    public class ReverseNumbersWithAStack
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ');
            var stack = new Stack<string>(input);
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(stack.Pop() + " ");
            }
            Console.WriteLine();
        }
    }
}
