namespace _10.Simple_Text_Editor
{
    using System;
    using System.Collections.Generic;

    public class SimpleTextEditor
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var result = new Stack<string>();
            result.Push(string.Empty);

            for (int i = 0; i < n; i++)
            {
                var command = Console.ReadLine().Split(' ');
                var commandName = int.Parse(command[0]);

                switch (commandName)
                {
                    case 1:
                        {
                            var text = command[1];
                            var update = result.Peek() + text;
                            result.Push(update);
                            break;
                        }
                    case 2:
                        {
                            var count = int.Parse(command[1]);
                            var update = result.Peek();
                            update = update.Remove(update.Length - count);
                            result.Push(update);
                            break;
                        }
                    case 3:
                        {
                            var index = int.Parse(command[1]);
                            Console.WriteLine(result.Peek()[index - 1]);
                            break;
                        }
                    case 4:
                        {
                            result.Pop();
                            break;
                        }
                }
            }
        }
    }
}
