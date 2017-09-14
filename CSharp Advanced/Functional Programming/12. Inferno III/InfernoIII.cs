namespace _12.Inferno_III
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class InfernoIII
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            numbers.Insert(0, 0);
            numbers.Add(0);
            var command = Console.ReadLine();
            var firstCommand = command.Substring(0, 7);
            var nextCommand = command.Substring(8, command.Length - 8);
            var commands = new List<string>();
            while (command != "Forge")
            {
                firstCommand = command.Substring(0, 7);
                nextCommand = command.Substring(8, command.Length - 8);
                if (firstCommand == "Exclude")
                {
                    commands.Add(nextCommand);
                }
                else if (firstCommand == "Reverse")
                {
                    if (commands.Contains(nextCommand))
                    {
                        commands.Remove(nextCommand);
                    }
                }
                command = Console.ReadLine();
            }
            var result = numbers.Select(n => n.ToString()).ToList();
            foreach (var operation in commands)
            {
                var tokens = operation.Split(';');
                var comm = tokens[0];
                var crit = int.Parse(tokens[1]);
                for (int i = 1; i < numbers.Count - 1; i++)
                {
                    if (isValid(comm, numbers[i - 1], numbers[i], numbers[i + 1], crit))
                    {
                        result.Insert(i, String.Empty);
                        result.RemoveAt(i + 1);
                    }
                }
            }
            result.RemoveAt(0);
            result.RemoveAt(result.Count - 1);
            result.RemoveAll(n => n == String.Empty);
            Console.WriteLine(string.Join(" ", result));
        }
        public static bool isValid(string command, int previousNum, int currentNum, int nextNum, int criteria)
        {
            switch (command)
            {
                case "Sum Left":
                    if (previousNum + currentNum == criteria) return true;
                    break;
                case "Sum Right":
                    if (currentNum + nextNum == criteria) return true;
                    break;
                case "Sum Left Right":
                    if (previousNum + currentNum + nextNum == criteria) return true;
                    break;
            }
            return false;
        }
    }
}
