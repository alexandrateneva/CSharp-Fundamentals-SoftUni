namespace _3.Formatting_Numbers
{
    using System;

    public class FormattingNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            var a = int.Parse(numbers[0]);
            var b = double.Parse(numbers[1]);
            var c = double.Parse(numbers[2]);
            var aAsBinary = Convert.ToString(a, 2).PadLeft(10, '0').Substring(0, 10); ;

            Console.WriteLine($"|{a,-10:X}|{aAsBinary}|{b,10:f2}|{c,-10:f3}|");
        }
    }
}
