using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.Raw_Data
{
    public class Startup
    {
        public static void Main()
        {
            var cars = new List<Car>();
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var model = tokens[0];
                var engine = new Engine(int.Parse(tokens[2]), int.Parse(tokens[1]));
                var cargo = new Cargo(int.Parse(tokens[3]), tokens[4]);
                var tyres = new List<Tyre>();
                tyres.Add(new Tyre(double.Parse(tokens[5]), int.Parse(tokens[6])));
                tyres.Add(new Tyre(double.Parse(tokens[7]), int.Parse(tokens[8])));
                tyres.Add(new Tyre(double.Parse(tokens[9]), int.Parse(tokens[10])));
                tyres.Add(new Tyre(double.Parse(tokens[11]), int.Parse(tokens[12])));

                var currentCar = new Car(model, cargo, engine, tyres);
                cars.Add(currentCar);
            }

            var command = Console.ReadLine();
            if (command == "fragile")
            {
                cars
                    .Where(c => c.cargo.type == "fragile")
                    .Where(c => c.tyres.Any(t => t.presure < 1))
                    .Select(c => c.model)
                    .ToList()
                    .ForEach(m => Console.WriteLine(m));
            }
            else
            {
                cars
                    .Where(c => c.cargo.type == "flamable")
                    .Where(c => c.engine.power > 250)
                    .Select(c => c.model)
                    .ToList()
                    .ForEach(m => Console.WriteLine(m));
            }
        }
    }
}

