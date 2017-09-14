namespace _7.Excellent_Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ExcellentStudents
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
                .Where(n => n.Contains("6"))
                .ToList()
                .ForEach(x => Console.WriteLine(x[0] + " " + x[1]));
        }
    }
}
