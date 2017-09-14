namespace _5.Convert_from_base_N_to_base_10
{
    using System;
    using System.Numerics;

    public class Converter
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var baseN = long.Parse(input[0]);
            var numberN = input[1];

            BigInteger result = 0;

            var power = numberN.Length - 1;

            for (int i = 0; i < numberN.Length; i++)
            {
                var num = BigInteger.Parse(numberN[i].ToString());
                result += BigInteger.Multiply(num, BigInteger.Pow(baseN, power));
                power--;
            }

            Console.WriteLine(result);
        }
    }
}
