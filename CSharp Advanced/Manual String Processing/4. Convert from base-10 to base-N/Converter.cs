namespace _4.Convert_from_base_10_to_base_N
{
    using System;
    using System.Numerics;
    using System.Text;

    public class Converter
    {
        public static void Main()
        {
            var result = new StringBuilder();
            var input = Console.ReadLine()
               .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var baseN = int.Parse(input[0]);
            var number = BigInteger.Parse(input[1]);

            while (number > 0)
            {
                var digit = number % baseN;
                result.Insert(0, digit);
                number /= baseN;
            }
            Console.WriteLine(result);
        }
    }
}
