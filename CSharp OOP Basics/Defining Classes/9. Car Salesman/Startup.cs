namespace _9.Car_Salesman
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            var engines = new Dictionary<string, Engine>();
            var numberOfEngines = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfEngines; i++)
            {
                var engineInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var currentEngine = new Engine(engineInfo[0], int.Parse(engineInfo[1]));
                if (engineInfo.Length > 2)
                {
                    var displacementOrEfficiency = engineInfo[2];
                    if (displacementOrEfficiency.Any(n => char.IsLetter(n)))
                    {
                        currentEngine.efficiency = displacementOrEfficiency;
                    }
                    else
                    {
                        currentEngine.displacement = int.Parse(displacementOrEfficiency);
                    }
                }
                if (engineInfo.Length > 3)
                {
                    currentEngine.efficiency = engineInfo[3];
                }

                engines.Add(currentEngine.model, currentEngine);
            }
            var cars = new List<Car>();
            var numberOfCars = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfCars; i++)
            {
                var carInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var currentEngine = engines[carInfo[1]];
                var currentCar = new Car(carInfo[0], currentEngine);
                if (carInfo.Length > 2)
                {
                    var colorOrWeight = carInfo[2];
                    if (colorOrWeight.Any(n => char.IsDigit(n)))
                    {
                        currentCar.weight = int.Parse(colorOrWeight);
                    }
                    else
                    {
                        currentCar.color = colorOrWeight;
                    }
                }
                if (carInfo.Length > 3)
                {
                    currentCar.color = carInfo[3];
                }

                cars.Add(currentCar);
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
