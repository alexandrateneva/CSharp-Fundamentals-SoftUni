namespace _01.Students_Results___Lab
{
    using System;

    public class StudentsResults
    {
       public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine(string.Format("{0, -10}|{1,7}|{2,7}|{3,7}|{4,7}|", "Name", "CAdv", "COOP",
                "AdvOOP", "Average"));
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Split(new[] { ' ', '-', ',' }, StringSplitOptions.RemoveEmptyEntries);

                var name = input[0];
                var grade1 = double.Parse(input[1]);
                var grade2 = double.Parse(input[2]);
                var grade3 = double.Parse(input[3]);
                var gradeAvr = (grade1 + grade2 + grade3) / 3;

                Console.WriteLine("{0, -10}|{1,7:f2}|{2,7:f2}|{3,7:f2}|{4,7:f4}|", name, grade1, grade2,
                    grade3, gradeAvr);
            }
        }
    }
}
