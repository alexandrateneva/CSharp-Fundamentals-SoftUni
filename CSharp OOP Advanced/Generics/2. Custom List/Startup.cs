namespace _2.Custom_List
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var list = new CustomList<string>();
            var command = Console.ReadLine();
            while (command != "END")
            {
                var commandArgs = command.Split(' ');
                string element;
                switch (commandArgs[0])
                {
                    case "Add":
                        element = commandArgs[1];
                        list.Add(element);
                        break;
                    case "Remove":
                        var index = int.Parse(commandArgs[1]);
                        list.Remove(index);
                        break;
                    case "Contains":
                        element = commandArgs[1];
                        Console.WriteLine(list.Contains(element));
                        break;
                    case "Swap":
                        var index1 = int.Parse(commandArgs[1]);
                        var index2 = int.Parse(commandArgs[2]);
                        list.Swap(index1, index2);
                        break;
                    case "Greater":
                        element = commandArgs[1];
                        Console.WriteLine(list.CountGreaterThan(element));
                        break;
                    case "Max":
                        Console.WriteLine(list.Max());
                        break;
                    case "Min":
                        Console.WriteLine(list.Min());
                        break;
                    case "Sort":
                        list = Sorter.Sort(list);
                        break;
                    case "Print":
                        foreach (var everyone in list)
                        {
                            Console.WriteLine(everyone);
                        }
                        break;
                }
                command = Console.ReadLine();
            }
        }
    }
}
