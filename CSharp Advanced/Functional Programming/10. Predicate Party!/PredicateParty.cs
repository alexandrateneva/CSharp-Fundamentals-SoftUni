namespace _10.Predicate_Party_
{
    using System;
    using System.Linq;

    public class PredicateParty
    {
        public static void Main()
        {
            var names = Console.ReadLine()
                .Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            var command = Console.ReadLine()
                .Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            while (command[0] != "Party!")
            {
                if (command[0] == "Remove")
                {
                    names.RemoveAll(n => isValid(command[1], n, command[2]));
                }
                else if (command[0] == "Double")
                {
                    var namesToDouble = names.Where(name => isValid(command[1], name, command[2])).ToArray();
                    foreach (var name in namesToDouble)
                    {
                        var index = names.IndexOf(name);
                        names.Insert(index, name);
                    }
                }

                command = Console.ReadLine()
                    .Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
            }
            if (names.Count > 0)
            {
                Console.WriteLine(string.Join(", ", names) + " are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }

        public static bool isValid(string command, string name, string criteria)
        {
            switch (command)
            {
                case "EndsWith":
                    if (name.EndsWith(criteria)) return true;
                    break;
                case "StartsWith":
                    if (name.StartsWith(criteria)) return true;
                    break;
                case "Length":
                    if (name.Length == int.Parse(criteria)) return true;
                    break;
            }
            return false;
        }
    }
}
