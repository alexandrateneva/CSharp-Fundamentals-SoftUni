namespace _2.Stack
{
    using System;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            var stack = new Stack<string>();

            var input = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var command = input[0];
            input.RemoveAt(0);
            while (command != "END")
            {
                switch (command)
                {
                    case "Push":
                        stack.Push(input);
                        break;
                    case "Pop":
                        try
                        {
                            stack.Pop();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                }

                input = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                command = input[0];
                input.RemoveAt(0);
            }

            for (int i = 0; i < 2; i++)
            {
                foreach (var element in stack)
                {
                    Console.WriteLine(element);
                }
            }
        }
    }
}
