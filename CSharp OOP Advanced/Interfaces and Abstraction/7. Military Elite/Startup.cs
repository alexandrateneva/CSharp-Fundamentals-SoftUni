namespace _7.Military_Elite
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using _7.Military_Elite.Models;

    public class Startup
    {
        public static void Main()
        {
            var allPrivates = new List<Private>();
            var militaryManager = new MilitaryManager();
            var input = Console.ReadLine();
            while (input != "End")
            {
                var inputArgs = input.Split(' ').ToList();
                switch (inputArgs[0])
                {
                    case "Private":
                        var privateSoldier = militaryManager.CreatePrivate(inputArgs);
                        Console.WriteLine(privateSoldier);
                        allPrivates.Add(privateSoldier);
                        break;
                    case "LeutenantGeneral":
                        var leutenantGeneral = militaryManager.CreateGeneral(inputArgs, allPrivates);
                        Console.WriteLine(leutenantGeneral);
                        break;
                    case "Engineer":
                        if (militaryManager.IsValidCorp(inputArgs[5]))
                        {
                            var engineer = militaryManager.CreaterEngineer(inputArgs);
                            Console.WriteLine(engineer);
                        }
                        break;
                    case "Commando":
                        if (militaryManager.IsValidCorp(inputArgs[5]))
                        {
                            var commando = militaryManager.CreateCommando(inputArgs);
                            Console.WriteLine(commando);
                        }
                        break;
                    case "Spy":
                        var spy = militaryManager.CreateSpy(inputArgs);
                        Console.WriteLine(spy);
                        break;
                }

                input = Console.ReadLine();
            }
        }
    }
}
