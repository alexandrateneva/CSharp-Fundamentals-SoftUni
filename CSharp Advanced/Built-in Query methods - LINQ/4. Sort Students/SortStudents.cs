namespace _4.Sort_Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SortStudents
    {
        public static void Main()
        {
            var students = new List<string[]>();
            var inputLine = Console.ReadLine();
            while (inputLine != "END")
            {
                students.Add(inputLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
                inputLine = Console.ReadLine();
            }
            students
                  .OrderBy(n => n[1])
                  .ThenByDescending(n => n[0])
                  .ToList()
                  .ForEach(x => Console.WriteLine(x[0] + " " + x[1]));
        }
    }
}
