namespace _12.Family_Tree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            var people = new List<Person>();
            var storePeople = new List<string>();

            var person = Console.ReadLine();

            var input = Console.ReadLine();

            while (!input.Equals("End"))
            {
                var info = input.Split(new[] { " - " }, StringSplitOptions.RemoveEmptyEntries);

                if (info.Length == 1)
                {
                    var tokens = input.Split(' ');
                    var name = tokens[0] + " " + tokens[1];
                    var birthday = tokens[2];

                    var newPerson = new Person();
                    newPerson.nameOfPerson = name;
                    newPerson.birthday = birthday;
                    people.Add(newPerson);
                }
                else
                {
                    storePeople.Add(input);
                }

                input = Console.ReadLine();
            }

            foreach (var storePerson in storePeople)
            {
                var parent = new Person();
                var child = new Person();

                var info = storePerson.Split(new[] { " - " }, StringSplitOptions.RemoveEmptyEntries);

                if (info[0].Contains('/') && info[1].Contains('/'))
                {
                    var parentBirhtday = info[0];
                    var childBirthday = info[1];

                    parent = people
                        .First(p => p.birthday.Equals(parentBirhtday));
                    child = people
                        .First(p => p.birthday.Equals(childBirthday));
                }
                else if (info[0].Contains('/') && !info[1].Contains('/'))
                {
                    var parentBirday = info[0];
                    var childName = info[1];

                    parent = people
                        .First(p => p.birthday.Equals(parentBirday));
                    child = people
                        .First(p => p.nameOfPerson.Equals(childName));

                }
                else if (!info[0].Contains('/') && info[1].Contains('/'))
                {
                    var parentName = info[0];
                    var childBirthday = info[1];

                    child = people
                        .First(p => p.birthday.Equals(childBirthday));
                    parent = people
                        .First(p => p.nameOfPerson.Equals(parentName));

                }
                else
                {
                    var parentName = info[0];
                    var childName = info[1];

                    parent = people
                        .First(p => p.nameOfPerson.Equals(parentName));
                    child = people
                        .First(p => p.nameOfPerson.Equals(childName));
                }

                if (!parent.children.Contains(child))
                {
                    parent.children.Add(child);
                }

                if (!child.parents.Contains(parent))
                {
                    child.parents.Add(parent);
                }
            }

            var wantedPerson = new Person();

            if (person.Contains('/'))
            {
                wantedPerson = people.First(p => p.birthday.Equals(person));
            }
            else
            {
                wantedPerson = people.First(p => p.nameOfPerson.Equals(person));
            }

            Console.WriteLine(wantedPerson);
            Console.WriteLine("Parents:");
            wantedPerson.parents.ForEach(p => Console.WriteLine(p));
            Console.WriteLine("Children:");
            wantedPerson.children.ForEach(p => Console.WriteLine(p));
        }
    }
}
