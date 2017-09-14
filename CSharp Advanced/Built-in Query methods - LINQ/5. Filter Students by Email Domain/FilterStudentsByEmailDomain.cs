namespace _5.Filter_Students_by_Email_Domain
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FilterStudentsByEmailDomain
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
                .Where(n => n[2].EndsWith("@gmail.com"))
                .ToList()
                .ForEach(x => Console.WriteLine(x[0] + " " + x[1]));
        }
    }
}
