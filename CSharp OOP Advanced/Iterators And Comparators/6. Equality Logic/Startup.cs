namespace _6.Equality_Logic
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            var sortedSetOfPeople = new SortedSet<Person>();
            var hashSetOfPeople = new HashSet<Person>();
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var personInfo = Console.ReadLine().Split(' ');
                var person = new Person(personInfo[0], int.Parse(personInfo[1]));

                sortedSetOfPeople.Add(person);
                hashSetOfPeople.Add(person);
            }

            Console.WriteLine(sortedSetOfPeople.Count);
            Console.WriteLine(hashSetOfPeople.Count);
        }
    }
}
