using System;

public abstract class Vehicle
{
    private double fuelQuantity;
    private double fuelConsumption;
    private double tankCapacity;

    public Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
    {
        this.FuelConsumption = fuelConsumption;
        this.FuelQuantity = fuelQuantity;
        this.TankCapacity = tankCapacity;
    }

    public double TankCapacity
    {
        get { return tankCapacity; }
        set { tankCapacity = value; }
    }

    public double FuelConsumption
    {
        get { return fuelConsumption; }
        set { fuelConsumption = value; }
    }

    public double FuelQuantity
    {
        get { return fuelQuantity; }
        set { fuelQuantity = value; }
    }

    public virtual double GetRealConsumption()
    {
        return this.FuelConsumption;
    }

    public virtual void GetDriven(double distance)
    {
        if (this.GetRealConsumption() * distance > this.FuelQuantity)
        {
            Console.WriteLine($"{this.GetType().Name} needs refueling");
        }
        else
        {
            Console.WriteLine($"{this.GetType().Name} travelled {distance} km");
            this.FuelQuantity -= this.GetRealConsumption() * distance;
        }
    }

    public virtual void GetRefueled(double litres)
    {
        if (litres <= 0)
        {
            Console.WriteLine("Fuel must be a positive number");
        }
        else if (litres > 0 && this.FuelQuantity + litres > this.TankCapacity)
        {
            Console.WriteLine("Cannot fit fuel in tank");
        }
        else
        {
            this.FuelQuantity += litres;
        }
    }

    public override string ToString()
    {
        return $"{this.GetType().Name}: {this.FuelQuantity:F2}";
    }
}
