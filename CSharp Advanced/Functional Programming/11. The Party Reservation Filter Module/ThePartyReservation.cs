namespace _11.The_Party_Reservation_Filter_Module
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ThePartyReservation
    {
        public static void Main()
        {
            var names = Console.ReadLine().Split(' ').ToList();
            var command = Console.ReadLine().Split(';').ToArray();
            if (names.Count < 0 || command.Length != 3)
            {
                return;
            }
            var removed = new Dictionary<string, List<int>>();

            while (command[0] != "Print")
            {
                if (command[0] == "Add filter")
                {
                    var removedNames = names.Where(n => isValid(command[1], n, command[2])).ToList();
                    foreach (var name in removedNames)
                    {
                        if (!removed.ContainsKey(name))
                        {
                            removed.Add(name, new List<int>());
                        }
                        var index = names.IndexOf(name);
                        removed[name].Add(index);
                        names.Insert(index, "");
                        names.RemoveAt(index + 1);
                    }
                }
                else if (command[0] == "Remove filter")
                {
                    foreach (var name in removed)
                    {
                        if (isValid(command[1], name.Key, command[2]))
                        {
                            foreach (var index in name.Value)
                            {
                                names.RemoveAt(index);
                                names.Insert(index, name.Key);
                            }
                        }
                    }
                }

                command = Console.ReadLine().Split(';').ToArray();
            }
            names.RemoveAll(n => n == String.Empty);
            if (names.Count > 0)
            {
                Console.WriteLine(string.Join(" ", names));
            }
        }

        public static bool isValid(string command, string name, string criteria)
        {
            switch (command)
            {
                case "Ends with":
                    if (name.EndsWith(criteria)) return true;
                    break;
                case "Starts with":
                    if (name.StartsWith(criteria)) return true;
                    break;
                case "Length":
                    if (name.Length == int.Parse(criteria)) return true;
                    break;
                case "Contains":
                    if (name.Contains(criteria)) return true;
                    break;
            }
            return false;
        }
    }
}
