namespace _04.Academy_Graduation___Lab
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    public class AcademyGraduation
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var students = new SortedDictionary<string, List<double>>();
            for (int i = 0; i < n; i++)
            {
                var name = Console.ReadLine();
                var grades = Console.ReadLine()
                    .Split(new [] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(a => double.Parse(a, CultureInfo.InvariantCulture))
                    .ToList();

                students.Add(name, grades);
            }

            foreach (var student in students)
            {
                Console.WriteLine($"{student.Key} is graduated with {student.Value.Average()}");
            }
        }
    }
}
