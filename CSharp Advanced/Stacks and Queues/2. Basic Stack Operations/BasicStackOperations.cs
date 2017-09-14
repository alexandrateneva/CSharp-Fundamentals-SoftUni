namespace _2.Basic_Stack_Operations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class BasicStackOperations
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ');
            var N = int.Parse(input[0]);  
            var S = int.Parse(input[1]);  
            var X = int.Parse(input[2]);  

            var list = new List<int>(Console.ReadLine().Split(' ').Select(a => int.Parse(a)));
            var stack = new Stack<int>();

            for (int i = 0; i < N; i++)
            {
                stack.Push(list[i]);
            }
            for (int i = 0; i < S; i++)
            {
                stack.Pop();
            }
            if (stack.Contains(X))
            {
                Console.WriteLine("true");
            }
            else if (stack.Count >= 1)
            {
                Console.WriteLine(stack.Min());
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
