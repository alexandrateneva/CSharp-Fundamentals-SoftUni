namespace _5.Applied_Arithmetics
{
    using System;
    using System.Linq;

    public class AppliedArithmetics
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse);
            var command = Console.ReadLine();
            while (command != "end")
            {
                switch (command)
                {
                    case "add": numbers = numbers.Select(n => n + 1); break;
                    case "multiply": numbers = numbers.Select(n => n * 2); break;
                    case "subtract": numbers = numbers.Select(n => n - 1); break;
                    case "print": Console.WriteLine(string.Join(" ", numbers)); break;
                }
                command = Console.ReadLine();
            }
        }
    }
}
