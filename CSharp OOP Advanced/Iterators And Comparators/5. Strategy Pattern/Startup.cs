namespace _5.Strategy_Pattern
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            var peopleSortedByName = new SortedSet<Person>(new PersonComparerByName());
            var peopleSortedByAge = new SortedSet<Person>(new PersonComparerByAge());

            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var personInfo = Console.ReadLine().Split(' ');
                var person = new Person(personInfo[0], int.Parse(personInfo[1]));

                peopleSortedByName.Add(person);
                peopleSortedByAge.Add(person);
            }

            foreach (var person in peopleSortedByName)
            {
                Console.WriteLine(person);
            }

            foreach (var person in peopleSortedByAge)
            {
                Console.WriteLine(person);
            }
        }
    }
}
