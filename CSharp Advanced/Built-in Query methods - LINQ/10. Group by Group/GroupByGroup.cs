namespace _10.Group_by_Group
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class GroupByGroup
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();
            var students = new Dictionary<int, List<string>>();
            while (inputLine != "END")
            {
                var tockens = inputLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var group = int.Parse(tockens[2]);
                var name = tockens.Take(2);
                if (!students.ContainsKey(group))
                {
                    students.Add(group, new List<string>());
                }
                students[group].Add(string.Join(" ", name));
                inputLine = Console.ReadLine();
            }

            foreach (var student in students.OrderBy(k => k.Key))
            {
                Console.WriteLine(student.Key + " - " + string.Join(", ", student.Value));
            }
        }
    }
}

