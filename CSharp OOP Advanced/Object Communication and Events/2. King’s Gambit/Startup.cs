namespace _2.King_s_Gambit
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using _2.King_s_Gambit.Models;

    public class Startup
    {
        public static void Main()
        {
            var king = new King();
            king.Name = Console.ReadLine();

            var servents = new List<Servant>();

            var namesOfRoyalGuards = Console.ReadLine().Split(' ');
            foreach (var name in namesOfRoyalGuards)
            {
                var royalGuard = new RoyalGuard();
                royalGuard.Name = name;
                royalGuard.HelpToTheKing(king);
                servents.Add(royalGuard);
            }

            var namesOfFootmen = Console.ReadLine().Split(' ');
            foreach (var name in namesOfFootmen)
            {
                var footman = new Footman();
                footman.Name = name;
                footman.HelpToTheKing(king);
                servents.Add(footman);
            }

            var command = Console.ReadLine().Split(' ');

            while (command[0] != "End")
            {
                switch (command[0])
                {
                    case "Attack":
                        Console.WriteLine($"King {king.Name} is under attack!");
                        king.StartAtack();
                        break;
                    case "Kill":
                        var killedServent = servents.First(s => s.Name == command[1]);
                        killedServent.ServantWasKilled(king);
                        break;
                }

                command = Console.ReadLine().Split(' ');
            }
        }
    }
}
