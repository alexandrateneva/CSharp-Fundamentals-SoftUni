namespace _7.Pet_Clinics
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            var pets = new Dictionary<string, Pet>();
            var clinics = new Dictionary<string, Clinic>();

            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ');
                Clinic currentClinic;
                switch (input[0])
                {
                    case "Create":
                        if (input[1] == "Pet")
                        {
                            var pet = new Pet(input[2], int.Parse(input[3]), input[4]);
                            pets.Add(input[2], pet);
                        }
                        else
                        {
                            try
                            {
                                var clinic = new Clinic(input[2], int.Parse(input[3]));
                                clinics.Add(input[2], clinic);
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                        }
                        break;
                    case "Add":
                        currentClinic = clinics[input[2]];
                        if (pets.ContainsKey(input[1]))
                        {
                            var currentPet = pets[input[1]];
                            Console.WriteLine(currentClinic.Add(currentPet.Name));
                        }
                        else
                        {
                            Console.WriteLine("Invalid Operation!");
                        }
                        break;
                    case "Release":
                        currentClinic = clinics[input[1]];
                        Console.WriteLine(currentClinic.Release());
                        break;
                    case "HasEmptyRooms":
                        currentClinic = clinics[input[1]];
                        Console.WriteLine(currentClinic.HasEmptyRooms());
                        break;
                    case "Print":
                        currentClinic = clinics[input[1]];
                        if (input.Length == 2)
                        {
                            PrintAllRooms(currentClinic, pets);
                        }
                        else
                        {
                            PrintRoom(currentClinic, int.Parse(input[2]), pets);
                        }
                        break;
                }
            }
        }

        public static void PrintAllRooms(Clinic currentClinic, Dictionary<string, Pet> pets)
        {
            for (int i = 0; i < currentClinic.RoomsАsArray.Length; i++)
            {
                PrintRoom(currentClinic, i + 1, pets);
            }
        }

        public static void PrintRoom(Clinic currentClinic, int room, Dictionary<string, Pet> pets)
        {
            var currentRoom = currentClinic.RoomsАsArray[room - 1];
            if (currentRoom == null)
            {
                Console.WriteLine("Room empty");
            }
            else
            {
                var petName = currentRoom;
                if (pets.ContainsKey(petName))
                {
                    Console.WriteLine(pets[petName]);
                }
                else
                {
                    Console.WriteLine("Invalid Operation!");
                }
            }
        }
    }
}
