namespace _2.Ferrari.Models
{
    using _2.Ferrari.Interfaces;

    public class Ferrari : ICar
    {
        public string Model { get; set; }
        public string DriverName { get; set; }

        public Ferrari(string model, string driverName)
        {
            this.Model = model;
            this.DriverName = driverName;
        }

        public string Brakes()
        {
            return "Brakes!";
        }

        public string PushTheGas()
        {
            return "No air!";
        }

        public override string ToString()
        {
            return $"{this.Model}/{this.Brakes()}/{this.PushTheGas()}/{this.DriverName}";
        }
    }
}
