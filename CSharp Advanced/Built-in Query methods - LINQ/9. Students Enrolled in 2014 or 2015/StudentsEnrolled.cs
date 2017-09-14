namespace _9.Students_Enrolled_in_2014_or_2015
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StudentsEnrolled
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
                .Where(n => n[0].EndsWith("14") | n[0].EndsWith("15"))
                .ToList()
                .ForEach(x => Console.WriteLine(string.Join(" ", x.Skip(1))));
        }
    }
}
