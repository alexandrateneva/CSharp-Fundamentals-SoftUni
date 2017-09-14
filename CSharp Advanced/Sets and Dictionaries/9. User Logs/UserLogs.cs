namespace _9.User_Logs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class UserLogs
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var result = new SortedDictionary<string, Dictionary<string, int>>();
            var regex = new Regex(@"IP=(.+) message='(.*)' user=(.+)");

            while (input != "end")
            {
                var current = regex.Split(input).Where(s => s != String.Empty).ToArray();
                var id = current[0];
                string user = null;
                if (current.Length < 3)
                {
                    user = current[1];
                }
                else
                {
                    user = current[2];
                }

                if (!result.ContainsKey(user))
                {
                    result.Add(user, new Dictionary<string, int>());
                    result[user].Add(id, 1);
                }
                else
                {
                    if (result[user].ContainsKey(id))
                    {
                        result[user][id]++;
                    }
                    else
                    {
                        result[user].Add(id, 1);
                    }
                }
                input = Console.ReadLine();
            }
            foreach (var person in result)
            {
                Console.WriteLine($"{person.Key}: ");

                foreach (var id in person.Value)
                {
                    if (id.Key.Equals(person.Value.Last().Key))
                    {
                        Console.WriteLine($"{id.Key} => {id.Value}.");
                    }
                    else
                    {
                        Console.Write($"{id.Key} => {id.Value}, ");
                    }
                }
            }
        }
    }
}
