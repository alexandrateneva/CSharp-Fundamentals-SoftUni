namespace _8.Multiply_big_number
{
    using System;
    using System.Text;

    public class MultiplyBigNumber
    {
        public static void Main()
        {
            var number = Console.ReadLine().Trim('0');
            var multiplier = int.Parse(Console.ReadLine());
            if (number == String.Empty || multiplier == 0)
            {
                Console.WriteLine(0);
                return;
            }

            var result = new StringBuilder();
            var digitToSum = 0;

            for (int i = 0; i < number.Length; i++)
            {
                var sum = int.Parse(number[number.Length - 1 - i].ToString()) * multiplier + digitToSum;
                digitToSum = sum / 10;
                var digit = sum % 10;
                result.Insert(0, digit);
            }
            result.Insert(0, digitToSum);

            Console.WriteLine(result.ToString().TrimStart('0'));
        }
    }
}
