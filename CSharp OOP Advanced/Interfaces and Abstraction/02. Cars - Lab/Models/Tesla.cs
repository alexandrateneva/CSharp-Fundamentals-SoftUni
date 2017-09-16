namespace _02.Cars___Lab.Models
{
    using _02.Cars___Lab.Interfaces;

    public class Tesla : Car, IElectricCar
    {
        public int Battery { get; }

        public Tesla(string model, string color, int battery)
            : base(model, color)
        {
            this.Battery = battery;
        }

        public override string ToString()
        {
            return $"{this.Color} Tesla {this.Model} with {this.Battery} Batteries" + base.ToString();
        }
    }
}
