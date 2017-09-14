namespace _02.SoftUni_Party___Lab
{
    using System;
    using System.Collections.Generic;

    public class SoftUniParty
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var guests = new SortedSet<string>();

            while (input != "PARTY")
            {
                guests.Add(input);
                input = Console.ReadLine();
            }

            while (input != "END")
            {
                if (guests.Contains(input))
                {
                    guests.Remove(input);
                }
                input = Console.ReadLine();
            }

            Console.WriteLine(guests.Count);
            if (guests.Count > 0)
            {
                foreach (var guest in guests)
                {
                    Console.WriteLine(guest);
                }
            }
        }
    }
}
