namespace _2.Ferrari
{
    using System;
    using _2.Ferrari.Interfaces;

    public class Startup
    {
        public static void Main()
        {
            string ferrariName = typeof(global::_2.Ferrari.Models.Ferrari).Name;
            string iCarInterfaceName = typeof(ICar).Name;

            bool isCreated = typeof(ICar).IsInterface;
            if (!isCreated)
            {
                throw new Exception("No interface ICar was created");
            }

            var driverName = Console.ReadLine().Trim();
            var ferrari = new global::_2.Ferrari.Models.Ferrari("488-Spider", driverName);
            Console.WriteLine(ferrari);
        }
    }
}
