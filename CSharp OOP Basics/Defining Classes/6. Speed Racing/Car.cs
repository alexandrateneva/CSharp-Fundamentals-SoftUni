using System;

public class Car
{
    public string model;
    public double fuelAmount;
    public double fuelPerKm;
    public double distanceTraveled;

    public Car(string model, double fuelAmount, double fuelPerKm)
    {
        this.model = model;
        this.fuelAmount = fuelAmount;
        this.fuelPerKm = fuelPerKm;
        this.distanceTraveled = 0;
    }

    public void GetDistance(double distance)
    {
        var totalCostOfFuel = distance * this.fuelPerKm;
        if (this.fuelAmount >= totalCostOfFuel)
        {
            this.fuelAmount -= totalCostOfFuel;
            this.distanceTraveled += distance;
        }
        else
        {
            Console.WriteLine("Insufficient fuel for the drive");
        }
    }
}
