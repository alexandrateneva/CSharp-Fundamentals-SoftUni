namespace _6.Speed_Racing
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var cars = new Dictionary<string, Car>();

            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split(' ');
                var model = tokens[0];
                var fuelAmount = double.Parse(tokens[1]);
                var fuelPerKm = double.Parse(tokens[2]);

                var car = new Car(model, fuelAmount, fuelPerKm);
                cars.Add(model, car);
            }

            var input = Console.ReadLine();
            while (input != "End")
            {
                var tokens = input.Split(' ');
                var model = tokens[1];
                var kms = double.Parse(tokens[2]);
                if (cars.ContainsKey(model))
                {
                    cars[model].GetDistance(kms);
                }

                input = Console.ReadLine();
            }

            foreach (var car in cars.Values)
            {
                Console.WriteLine($"{car.model} {car.fuelAmount:F2} {car.distanceTraveled}");
            }
        }
    }
}
