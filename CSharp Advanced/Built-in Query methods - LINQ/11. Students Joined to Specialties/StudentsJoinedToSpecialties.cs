namespace _11.Students_Joined_to_Specialties
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StudentsJoinedToSpecialties
    {
        public static void Main()
        {
            var students = new List<Student>();
            var specialties = new List<StudentSpecialty>();
            var input = Console.ReadLine();
            while (input != "Students:")
            {
                var tokens = input.Split(' ');
                specialties.Add(new StudentSpecialty(tokens[0] + " " + tokens[1], int.Parse(tokens[2])));
                input = Console.ReadLine();
            }
            input = Console.ReadLine();
            while (input != "END")
            {
                var tokens = input.Split(' ');
                students.Add(new Student(tokens[1] + " " + tokens[2], int.Parse(tokens[0])));
                input = Console.ReadLine();
            }

            specialties.Join(students, sp => sp.FacNumber, st => st.FacNumber, (sp, st) => new
            {
                Name = st.StudentName,
                FacultyNumber = sp.FacNumber,
                Spec = sp.SpecName
            })
            .OrderBy(res => res.Name)
            .ToList()
            .ForEach(res => Console.WriteLine($"{res.Name} {res.FacultyNumber} {res.Spec}"));
        }

    }
    public class Student
    {
        public string StudentName { get; set; }
        public int FacNumber { get; set; }
        public Student(string name, int number)
        {
            this.StudentName = name;
            this.FacNumber = number;
        }
    }
    public class StudentSpecialty
    {
        public string SpecName { get; set; }
        public int FacNumber { get; set; }
        public StudentSpecialty(string name, int number)
        {
            this.SpecName = name;
            this.FacNumber = number;
        }
    }
}
