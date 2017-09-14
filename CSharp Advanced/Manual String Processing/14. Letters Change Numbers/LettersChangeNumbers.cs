namespace _14.Letters_Change_Numbers
{
    using System;

    public class LettersChangeNumbers
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            var alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            double result = 0;

            foreach (var element in input)
            {
                var firstLetter = element[0];
                var secondLetter = element[element.Length - 1];
                var number = double.Parse(element.Substring(1, element.Length - 2));

                if (char.IsUpper(firstLetter))
                {
                    number = number / (alphabet.IndexOf(firstLetter) + 1);
                }
                else if (char.IsLower(firstLetter))
                {
                    firstLetter = char.ToUpper(firstLetter);
                    number = number * (alphabet.IndexOf(firstLetter) + 1);
                }
                if (char.IsUpper(secondLetter))
                {
                    number = number - (alphabet.IndexOf(secondLetter) + 1);
                }
                else if (char.IsLower(secondLetter))
                {
                    secondLetter = char.ToUpper(secondLetter);
                    number = number + (alphabet.IndexOf(secondLetter) + 1);
                }
                result += number;
            }
            Console.WriteLine($"{result:0.00}");
        }
    }
}
