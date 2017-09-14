namespace _04.Average_of_Doubles___Lab
{
    using System;
    using System.Linq;

    public class AverageOfDoubles
    {
        public static void Main()
        {
            var average = Console.ReadLine().Split(' ').Select(double.Parse).Average();
            Console.WriteLine(average.ToString("F2"));
        }
    }
}
