namespace _2.Students_by_First_and_Last_Name
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StudentsByFirstAndLastName
    {
        public static void Main()
        {
            var names = new List<string>();
            var input = Console.ReadLine();
            while (input != "END")
            {
                names.Add(input);
                input = Console.ReadLine();
            }
            var result = names.Select(c =>
                {
                    var tokens = c.Split(' ');
                    var firstName = tokens[0];
                    var lastName = tokens[1];
                    return new { firstName, lastName };
                })
                .Where(n => n.firstName.CompareTo(n.lastName) == -1)
                .ToList();

            foreach (var name in result)
            {
                Console.WriteLine(name.firstName + " " + name.lastName);
            }
        }
    }
}
