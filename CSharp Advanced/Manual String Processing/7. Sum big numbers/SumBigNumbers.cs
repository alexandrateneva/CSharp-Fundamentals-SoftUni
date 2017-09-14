namespace _7.Sum_big_numbers
{
    using System;
    using System.Text;

    public class SumBigNumbers
    {
        public static void Main()
        {
            var num1 = Console.ReadLine();
            var num2 = Console.ReadLine();
            var minLen = 0;
            if (num1.Length > num2.Length)
            {
                num2 = num2.PadLeft(num1.Length, '0');
                minLen = num2.Length;
            }
            else
            {
                num1 = num1.PadLeft(num2.Length, '0');
                minLen = num1.Length;
            }

            var result = new StringBuilder();
            var digitToSum = 0;

            for (int i = 0; i < minLen; i++)
            {
                var sum = int.Parse(num1[minLen - 1 - i].ToString()) + int.Parse(num2[minLen - 1 - i].ToString()) + digitToSum;
                digitToSum = sum / 10;
                var digit = sum % 10;
                result.Insert(0, digit);
            }
            result.Insert(0, digitToSum);

            Console.WriteLine(result.ToString().TrimStart('0'));
        }
    }
}
