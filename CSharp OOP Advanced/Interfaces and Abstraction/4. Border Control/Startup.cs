namespace _4.Border_Control
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            var society = new List<IId>();

            var input = Console.ReadLine();
            while (input != "End")
            {
                var inputArgs = input.Split(' ');
                if (inputArgs.Length == 3)
                {
                    var citizen = new Citizen(inputArgs[0], int.Parse(inputArgs[1]), inputArgs[2]);
                    society.Add(citizen);
                }
                else if (inputArgs.Length == 2)
                {
                    var robot = new Robot(inputArgs[0], inputArgs[1]);
                    society.Add(robot);
                }
                input = Console.ReadLine();
            }

            var endOfId = Console.ReadLine().Trim();
            foreach (var everyone in society)
            {
                if (everyone.Id.EndsWith(endOfId))
                {
                    Console.WriteLine(everyone.Id);
                }
            }
        }
    }
}
