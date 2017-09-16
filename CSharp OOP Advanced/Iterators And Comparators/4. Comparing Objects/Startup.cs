namespace _4.Comparing_Objects
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            var people = new List<Person>();
            var input = Console.ReadLine();
            while (input != "END")
            {
                var personInfo = input.Split(' ');
                var person = new Person(personInfo[0], int.Parse(personInfo[1]), personInfo[2]);
                people.Add(person);
                input = Console.ReadLine();
            }

            var indexOfPersonToCompare = int.Parse(Console.ReadLine()) - 1;
            Person personToCompare = null;
            int equalPeople = 0;

            if (indexOfPersonToCompare > 0 && indexOfPersonToCompare < people.Count)
            {
                personToCompare = people[indexOfPersonToCompare];
                equalPeople = people.Count(p => p.CompareTo(personToCompare) == 0);
            }

            if (equalPeople == 1 || equalPeople == 0)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{equalPeople} {people.Count - equalPeople} {people.Count}");
            }
        }
    }
}
