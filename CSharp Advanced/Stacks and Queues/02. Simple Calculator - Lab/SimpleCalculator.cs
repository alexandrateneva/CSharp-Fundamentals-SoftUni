namespace _02.Simple_Calculator___Lab
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SimpleCalculator
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var stack = new Stack<string>(input.Reverse());

            while (stack.Count > 1)
            {
                int number1 = int.Parse(stack.Pop());
                string op = stack.Pop();
                int number2 = int.Parse(stack.Pop());

                switch (op)
                {
                    case "+": stack.Push((number1 + number2).ToString()); break;
                    case "-": stack.Push((number1 - number2).ToString()); break;
                }
            }
            Console.WriteLine(stack.Pop());
        }
    }
}
