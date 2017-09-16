namespace _9.Explicit_Interfaces
{
    using System;
    using _9.Explicit_Interfaces.Interfaces;
    using _9.Explicit_Interfaces.Models;

    public class Startup
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            while (input != "End")
            {
                var citizenInfo = input.Split(' ');
                var citizen = new Citizen(citizenInfo[0], citizenInfo[1], int.Parse(citizenInfo[2]));
                var resident = citizen as IResident;
                var person = citizen as IPerson;

                Console.WriteLine(person.GetName());
                Console.WriteLine(resident.GetName());

                input = Console.ReadLine();
            }
        }
    }
}
