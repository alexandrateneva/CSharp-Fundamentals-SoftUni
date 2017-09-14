namespace _3.Students_by_Age
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StudentsByAge
    {
        public static void Main()
        {
            var students = new List<string[]>();
            var inpuLine = Console.ReadLine();
            while (inpuLine != "END")
            {
                students.Add(inpuLine
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray());
                inpuLine = Console.ReadLine();
            }

            students
                .Where(n => 18 <= int.Parse(n[2]) && int.Parse(n[2]) <= 24)
                .ToList()
                .ForEach(x => Console.WriteLine(x[0] + " " + x[1] + " " + x[2]));
        }
    }
}
