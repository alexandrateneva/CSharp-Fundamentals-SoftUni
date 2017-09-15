using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace _11.Google
{
    public class Startup
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var persons = new List<Person>();

            while (input != "End")
            {
                var tokens = input.Split(' ');
                var nameOfPerson = tokens[0];
                var typeOfInfo = tokens[1];
                if (!persons.Any(p => p.nameOfPerson == nameOfPerson))
                {
                    persons.Add(new Person(nameOfPerson));
                }
                var person = persons.First(p => p.nameOfPerson == nameOfPerson);

                switch (typeOfInfo)
                {
                    case "company":
                        var companyName = tokens[2];
                        var department = tokens[3];
                        var salary = decimal.Parse(tokens[4]);
                        person.company = new Company(companyName, department, salary);
                        break;
                    case "pokemon":
                        var pokemonName = tokens[2];
                        var pokemonType = tokens[3];
                        person.pokemons.Add(new Pokemon(pokemonName, pokemonType));
                        break;
                    case "parents":
                        var parentName = tokens[2];
                        var parentBirthday = tokens[3];
                        person.parents.Add(new Parent(parentName, parentBirthday));
                        break;
                    case "children":
                        var childName = tokens[2];
                        var childBirthday = tokens[3];
                        person.children.Add(new Child(childName, childBirthday));
                        break;
                    case "car":
                        var model = tokens[2];
                        var speed = int.Parse(tokens[3]);
                        person.car = new Car(model, speed);
                        break;
                }

                input = Console.ReadLine();
            }

            var infoForPerson = Console.ReadLine();
            var currentPerson = persons.First(p => p.nameOfPerson == infoForPerson);
            Console.WriteLine(currentPerson.nameOfPerson);
            Console.WriteLine("Company:");
            if (currentPerson.company != null)
            {
                Console.WriteLine($"{currentPerson.company.companyName} {currentPerson.company.department} {currentPerson.company.salary:F2}");
            }
            Console.WriteLine("Car:");
            if (currentPerson.car != null)
            {
                Console.WriteLine($"{currentPerson.car.model} {currentPerson.car.speed}");
            }
            Console.WriteLine("Pokemon:");
            currentPerson.pokemons.ForEach(i => Console.WriteLine($"{i.pokemonName} {i.type}"));
            Console.WriteLine("Parents:");
            currentPerson.parents.ForEach(i => Console.WriteLine($"{i.parentName} {i.dateOfBirth}"));
            Console.WriteLine("Children:");
            currentPerson.children.ForEach(i => Console.WriteLine($"{i.nameOfChild} {i.dateOfBirth}"));
        }
    }
}
