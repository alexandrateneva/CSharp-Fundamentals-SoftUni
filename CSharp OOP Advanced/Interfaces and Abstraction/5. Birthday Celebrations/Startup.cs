namespace _5.Birthday_Celebrations
{
    using System;
    using System.Collections.Generic;
    using _5.Birthday_Celebrations.Interfaces;
    using _5.Birthday_Celebrations.Models;

    public class Startup
    {
        public static void Main()
        {
            var humansAndPets = new List<IIdenifier>();
            var humansAndRobots = new List<IId>();

            var input = Console.ReadLine();
            while (input != "End")
            {
                var inputArgs = input.Split(' ');
                switch (inputArgs[0])
                {
                    case "Citizen":
                        var citizen = new Citizen(inputArgs[1], int.Parse(inputArgs[2]), inputArgs[3], inputArgs[4]);
                        humansAndPets.Add(citizen);
                        humansAndRobots.Add(citizen);
                        break;
                    case "Pet":
                        var pet = new Pet(inputArgs[1], inputArgs[2]);
                        humansAndPets.Add(pet);
                        break;
                    case "Robot":
                        var robot = new Robot(inputArgs[1], inputArgs[2]);
                        humansAndRobots.Add(robot);
                        break;
                }

                input = Console.ReadLine();
            }

            var yearOfBirth = Console.ReadLine().Trim();
            foreach (var everyone in humansAndPets)
            {
                if (everyone.DateOfBirth.EndsWith(yearOfBirth))
                {
                    Console.WriteLine(everyone.DateOfBirth);
                }
            }
        }
    }
}
