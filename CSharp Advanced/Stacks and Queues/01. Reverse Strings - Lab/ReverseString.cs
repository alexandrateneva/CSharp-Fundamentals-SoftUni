namespace _01.Reverse_Strings___Lab
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ReverseString
    {
        public static void Main()
        {
            var input = Console.ReadLine().ToCharArray();
            input.Reverse();
            var stack = new Stack<char>(input);

            foreach (var symbol in stack)
            {
                Console.Write(symbol);
            }
            Console.WriteLine();
        }
    }
}
