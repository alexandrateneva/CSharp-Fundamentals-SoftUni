namespace _9.Stack_Fibonacci
{
    using System;
    using System.Collections.Generic;

    public class StackFibonacci
	{
		public static void Main()
		{
			var number = int.Parse(Console.ReadLine());
			var fibNumbers = new Stack<long>();
			fibNumbers.Push(0);
			var previous = fibNumbers.Peek();
			fibNumbers.Push(1);
			var last = fibNumbers.Peek();

            if (number <= 1)
            {
                Console.WriteLine(0);
            }
            else
            {
                for (int i = 0; i < number - 1; i++)
                {
                    var newLast = last + previous;
                    fibNumbers.Push(newLast);
                    previous = last;
                    last = newLast;
                }
                Console.WriteLine(fibNumbers.Pop());
            }
		}
	}
}
