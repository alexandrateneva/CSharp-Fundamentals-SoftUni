namespace _01.Arrange_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class ArrangeNumbers
    {
       public static void Main()
        {
            var dict = new Dictionary<int, string>();
            dict.Add(0, "zero");
            dict.Add(1, "one");
            dict.Add(2, "two");
            dict.Add(3, "three");
            dict.Add(4, "four");
            dict.Add(5, "five");
            dict.Add(6, "six");
            dict.Add(7, "seven");
            dict.Add(8, "eight");
            dict.Add(9, "nine");

            var numbers = new Stack<string>(Console.ReadLine()
                .Split(new[] {", "}, StringSplitOptions.RemoveEmptyEntries));
            var moreThenOne = new Dictionary<int, int>();
            var result = new Dictionary<int, string>();
            foreach (var number in numbers)
            {
                var nameOfNumber = new StringBuilder();
                foreach (var digit in number)
                {
                    string nameOfDigit;
                    if (dict.ContainsKey(int.Parse(digit.ToString())))
                    {
                        nameOfDigit = dict[int.Parse(digit.ToString())];
                        nameOfNumber.Append(nameOfDigit);
                    }
                }
                if (!result.ContainsKey(int.Parse(number)))
                {
                    result.Add(int.Parse(number), nameOfNumber.ToString());
                }
                else
                {
                    if (!moreThenOne.ContainsKey(int.Parse(number)))
                    {
                        moreThenOne.Add(int.Parse(number), 0);
                    }
                    moreThenOne[int.Parse(number)]++;
                }
            }
            var orderedResult = result.OrderBy(v => v.Value).ToDictionary(k => k.Key, v => v.Value);
            if (moreThenOne.Count > 0)
            {
                var finalNumbers = new List<int>();
                foreach (var number in orderedResult.Keys)
                {
                    finalNumbers.Add(number);
                    if (moreThenOne.ContainsKey(number))
                    {
                        var times = moreThenOne[number];
                        for (int i = 0; i < times; i++)
                        {
                            finalNumbers.Add(number);
                        }
                    }
                }
                Console.WriteLine(string.Join(", ", finalNumbers));
            }
            else
            {
                Console.WriteLine(string.Join(", ", orderedResult.Keys));
            }
        }
    }
}
