namespace _1.Students_by_Group
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StudentsByGroup
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var students = new List<string>();
            while (input != "END")
            {
                var tokens = input.Split(' ');
                var firstName = tokens[0];
                var lastName = tokens[1];
                var group = int.Parse(tokens[2]);
                if (group == 2)
                {
                    students.Add(firstName + " " + lastName);
                }

                input = Console.ReadLine();
            }
            foreach (var student in students.OrderBy(n => n))
            {
                Console.WriteLine(student);
            }
        }
    }
}
