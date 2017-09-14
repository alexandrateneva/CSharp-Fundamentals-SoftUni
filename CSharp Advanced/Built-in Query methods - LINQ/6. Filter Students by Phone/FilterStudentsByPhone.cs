namespace _6.Filter_Students_by_Phone
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
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
                .Where(n => n[2].StartsWith("+3592") | n[2].StartsWith("02"))
                .ToList()
                .ForEach(x => Console.WriteLine(x[0] + " " + x[1]));
        }
    }
}
