namespace _01.Parking_Lot___Lab
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class ParkingLot
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var cars  = new SortedSet<string>();

            while (input != "END")
            {
                var inputParams = Regex.Split(input, ", ");
                if (inputParams[0] == "IN")
                {
                    cars.Add(inputParams[1]);
                }
                else
                {
                    if (cars.Contains(inputParams[1]))
                    {
                        cars.Remove(inputParams[1]);
                    }
                }

                input = Console.ReadLine();
            }
            if (cars.Count > 0)
            {
                foreach (var car in cars)
                {
                    Console.WriteLine(car);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
