namespace _04.Add_VAT___Lab
{
    using System;
    using System.Linq;

    public class AddVAT
    {
        public static void Main()
        {
            var prices = Console.ReadLine()
                .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .Select(n => n * 1.20);

            foreach (var price in prices)
            {
                Console.WriteLine(price.ToString("n2"));
            }

        }
    }
}
