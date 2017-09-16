namespace _02.Cars___Lab
{
    using System;
    using _02.Cars___Lab.Interfaces;
    using _02.Cars___Lab.Models;

    public class Startup
    {
        public static void Main()
        {
            ICar seat = new Seat("Leon", "Grey");
            ICar tesla = new Tesla("Model 3", "Red", 2);

            Console.WriteLine(seat.ToString());
            Console.WriteLine(tesla.ToString());
        }
    }
}
