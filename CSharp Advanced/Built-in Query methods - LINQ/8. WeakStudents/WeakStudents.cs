namespace _8.WeakStudents
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class WeakStudents
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();
            var students = new List<string[]>();
            while (inputLine != "END")
            {
                students.Add(inputLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
                inputLine = Console.ReadLine();
            }
            students
                .Where(n => n.Skip(2).Count(num => int.Parse(num) <= 3) >= 2)
                .ToList()
                .ForEach(x => Console.WriteLine(x[0] + " " + x[1]));
        }
    }
}
