namespace _3.Custom_Min_Function
{
    using System;
    using System.Linq;

    public class CustMinFunc
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse);
            Func<int[], int> min = num => num.Min();
            Console.WriteLine(min(numbers.ToArray()));
        }
    }
}
