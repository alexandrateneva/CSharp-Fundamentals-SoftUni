namespace _13.Office_Stuff
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class OfficeStuff
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var result = new Dictionary<string, Dictionary<string, int>>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Split(new[] { ' ', '-', '|' }, StringSplitOptions.RemoveEmptyEntries);
                var company = input[0];
                var amount = int.Parse(input[1]);
                var product = input[2];
                if (!result.ContainsKey(company))
                {
                    result.Add(company, new Dictionary<string, int>());
                }
                if (!result[company].ContainsKey(product))
                {
                    result[company].Add(product, 0);
                }
                result[company][product] += amount;
            }
            foreach (var company in result.OrderBy(k => k.Key))
            {
                var list = new List<string>();
                foreach (var product in company.Value)
                {
                    list.Add($"{product.Key}-{ product.Value}");
                }
                Console.WriteLine($"{company.Key}: {string.Join(", ", list)}");
            }
        }
    }
}
