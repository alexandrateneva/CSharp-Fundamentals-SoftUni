using System;

public class Truck : Vehicle
{
    public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity)
        : base(fuelQuantity, fuelConsumption, tankCapacity)
    {
    }

    public override double GetRealConsumption()
    {
        return base.GetRealConsumption() + 1.6;
    }

    public override void GetRefueled(double litres)
    {
        if (litres <= 0)
        {
            Console.WriteLine("Fuel must be a positive number");
        }
        else
        {
            this.FuelQuantity += litres * 0.95;
        }
    }
}
