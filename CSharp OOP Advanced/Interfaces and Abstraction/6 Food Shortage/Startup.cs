namespace _6_Food_Shortage
{
    using System;
    using System.Collections.Generic;
    using _6_Food_Shortage.Interfaces;
    using _6_Food_Shortage.Models;

    public class Startup
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var people = new Dictionary<string, IBuyer>();
            for (int i = 0; i < n; i++)
            {
                var info = Console.ReadLine().Split(' ');
                if (info.Length == 4)
                {
                    var citizen = new Citizen(info[0], int.Parse(info[1]), info[2], info[3]);
                    people.Add(info[0], citizen);
                }
                else if (info.Length == 3)
                {
                    var rebel = new Rebel(info[0], int.Parse(info[1]), info[2]);
                    people.Add(info[0], rebel);
                }
            }

            var input = Console.ReadLine().Trim();
            while (input != "End")
            {
                if (people.ContainsKey(input))
                {
                    people[input].BuyFood();
                }

                input = Console.ReadLine().Trim();
            }

            var totalFood = 0;
            foreach (var person in people)
            {
                totalFood += person.Value.Food;
            }
            Console.WriteLine(totalFood);
        }
    }
}
