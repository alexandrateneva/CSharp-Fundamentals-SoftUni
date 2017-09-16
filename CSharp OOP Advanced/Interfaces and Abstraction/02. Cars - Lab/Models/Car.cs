namespace _02.Cars___Lab.Models
{
    using System;
    using _02.Cars___Lab.Interfaces;

    public abstract class Car : ICar
    {
        public string Model { get; }
        public string Color { get; }

        protected Car(string model, string color)
        {
            this.Model = model;
            this.Color = color;
        }

        public string Start()
        {
            return "Engine start";
        }

        public string Stop()
        {
            return "Breaaak!";
        }

        public override string ToString()
        {
            return Environment.NewLine + this.Start() + Environment.NewLine + this.Stop();
        }
    }
}
