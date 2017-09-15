namespace _3.Opinion_Poll
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            var people = new List<Person>();
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split(' ');
                var name = tokens[0];
                var age = int.Parse(tokens[1]);
                var currentPerson = new Person(name, age);
                people.Add(currentPerson);
            }

            foreach (var person in people.Where(p => p.age > 30).OrderBy(p => p.name))
            {
                Console.WriteLine($"{person.name} - {person.age}");
            }
        }
    }
}
