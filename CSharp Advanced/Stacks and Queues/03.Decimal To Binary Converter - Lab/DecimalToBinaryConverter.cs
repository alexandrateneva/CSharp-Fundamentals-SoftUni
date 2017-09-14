namespace _03.Decimal_To_Binary_Converter___Lab
{
    using System;
    using System.Collections.Generic;

    public class DecimalToBinaryConverter
    {
        public static void Main()
        {
            var decimalNumber = int.Parse(Console.ReadLine());
            var stack = new Stack<int>();
            if (decimalNumber == 0)
            {
                Console.Write(0);
            }
            while (decimalNumber != 0)
            {
                stack.Push(decimalNumber % 2);
                decimalNumber /= 2;
            }
            while (stack.Count > 0)
            {
                Console.Write(stack.Pop());
            }
            Console.WriteLine();
        }
    }
}
