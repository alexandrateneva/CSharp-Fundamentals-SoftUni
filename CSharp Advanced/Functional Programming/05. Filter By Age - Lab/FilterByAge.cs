namespace _05.Filter_By_Age___Lab
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FilterByAge
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var people = new Dictionary<string, int>();
            for (int i = 0; i < n; i++)
            {
                var data = Console.ReadLine()
                    .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                people.Add(data[0], int.Parse(data[1]));
            }
            var condition = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var format = Console.ReadLine();

            if (condition == "younger")
            {
                people = people.Where(kvp => kvp.Value < age).ToDictionary(k => k.Key, v => v.Value);
            }
            else if (condition == "older")
            {
                people = people.Where(kvp => kvp.Value >= age).ToDictionary(k => k.Key, v => v.Value);
            }

            switch (format)
            {
                case "name":
                    foreach (var man in people)
                    {
                        Console.WriteLine(man.Key);
                    }
                    break;
                case "age":
                    foreach (var man in people)
                    {
                        Console.WriteLine(man.Value);
                    }
                    break;
                case "name age":
                    foreach (var man in people)
                    {
                        Console.WriteLine(man.Key + " - " + man.Value);
                    }
                    break;
            }
        }
    }
}
