namespace _01.Vehicles
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var carInfo = Console.ReadLine().Split(' ');
            var car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]), double.Parse(carInfo[3]));
            var truckInfo = Console.ReadLine().Split(' ');
            var truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]), double.Parse(truckInfo[3]));
            var busInfo = Console.ReadLine().Split(' ');
            var bus = new Bus(double.Parse(busInfo[1]), double.Parse(busInfo[2]), double.Parse(busInfo[3]));
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var info = Console.ReadLine().Split(' ');
                var typeOfOperation = info[0];
                var typeOfVehicle = info[1];
                var distanceOrLitres = double.Parse(info[2]);
                switch (typeOfVehicle)
                {
                    case "Car": GetOperation(car, typeOfOperation, distanceOrLitres); break;
                    case "Truck": GetOperation(truck, typeOfOperation, distanceOrLitres); break;
                    case "Bus":
                        if (typeOfOperation == "DriveEmpty")
                        {
                            bus.IsEmpty = true;
                            typeOfOperation = "Drive";
                        }
                        GetOperation(bus, typeOfOperation, distanceOrLitres); break;
                }

            }
            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);
        }

        public static void GetOperation(Vehicle vehicle, string typeOfOperation, double distanceOrLitres)
        {
            switch (typeOfOperation)
            {
                case "Drive": vehicle.GetDriven(distanceOrLitres); break;
                case "Refuel": vehicle.GetRefueled(distanceOrLitres); break;
            }
        }
    }
}
