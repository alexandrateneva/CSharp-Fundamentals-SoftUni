namespace _1.Unique_Usernames
{
    using System;
    using System.Collections.Generic;

    public class UniqueUsernames
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var guys = new HashSet<string>();
            for (int i = 0; i < n; i++)
            {
                var current = Console.ReadLine();
                guys.Add(current);
            }
            foreach (var guy in guys)
            {
                Console.WriteLine(guy);
            }
        }
    }
}
