namespace _03.Count_Same_Values_in_Array___Lab
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class CountSameValuesInArray
    {
        public static void Main()
        {
            var input = Console.ReadLine().Trim();
            var numbers = Regex.Split(input, " ");
            var dict = new SortedDictionary<double, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
               var num = double.Parse(numbers[i]);
                if (!dict.ContainsKey(num))
                {
                    dict.Add(num, 1);
                }
                else
                {
                    dict[num]++;
                }
            }
            foreach (var number in dict)
            {
                Console.WriteLine($"{number.Key} - {number.Value} times");
            }
        }
    }
}
