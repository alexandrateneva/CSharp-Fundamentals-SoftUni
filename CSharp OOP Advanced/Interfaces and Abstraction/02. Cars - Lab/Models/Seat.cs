namespace _02.Cars___Lab.Models
{
    public class Seat : Car
    {
        public Seat(string model, string color) : base(model, color)
        {
        }

        public override string ToString()
        {
            return $"{this.Color} Seat {this.Model}" + base.ToString();
        }
    }
}
