namespace _02.Wild_farm
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var infoForAnimal = Console.ReadLine().Split(' ');
            while (infoForAnimal[0] != "End")
            {
                var animalType = infoForAnimal[0];
                var animalName = infoForAnimal[1];
                var animalWeight = double.Parse(infoForAnimal[2]);
                var animalLivingRegion = infoForAnimal[3];
                string catBreed = null;
                if (infoForAnimal.Length > 4)
                {
                    catBreed = infoForAnimal[4];
                }

                Animal animal;
                switch (animalType)
                {
                    case "Mouse":
                        animal = new Mouse(animalName, animalWeight, animalLivingRegion, animalType);
                        break;
                    case "Zebra":
                        animal = new Zebra(animalName, animalWeight, animalLivingRegion, animalType);
                        break;
                    case "Cat":
                        animal = new Cat(animalName, animalWeight, animalLivingRegion, catBreed, animalType);
                        break;
                    case "Tiger":
                        animal = new Tiger(animalName, animalWeight, animalLivingRegion, animalType);
                        break;
                    default:
                        animal = null;
                        break;
                }

                animal.MakeSound();

                var infoForFood = Console.ReadLine().Split(' ');
                var type = infoForFood[0];
                var weight = int.Parse(infoForFood[1]);
                Food food;
                switch (type)
                {
                    case "Vegetable": food = new Vegetable(weight); break;
                    case "Meat": food = new Meat(weight); break;
                    default: food = null; break;
                }

                animal.Eat(food);

                Console.WriteLine(animal);

                infoForAnimal = Console.ReadLine().Split(' ');
            }
        }
    }
}
