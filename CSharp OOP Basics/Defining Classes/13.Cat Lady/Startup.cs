namespace _13.Cat_Lady
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            var cats = new List<Cat>();
            var input = Console.ReadLine();
            while (input != "End")
            {
                var tokens = input.Split(' ');
                var breed = tokens[0];
                var name = tokens[1];
                var anotherSpecific = tokens[2];

                var currentCat = new Cat(name, breed, anotherSpecific);
                cats.Add(currentCat);
                input = Console.ReadLine();
            }

            var wantedCatName = Console.ReadLine();
            var wantedCat = cats.First(c => c.name == wantedCatName);
            if (wantedCat.breed == "Cymric")
            {
                var spesific = double.Parse(wantedCat.anotherSpecific);
                Console.WriteLine($"{wantedCat.breed} {wantedCat.name} {spesific:F2}");
            }
            else
            {
                Console.WriteLine($"{wantedCat.breed} {wantedCat.name} {wantedCat.anotherSpecific}");
            }

        }
    }
}
