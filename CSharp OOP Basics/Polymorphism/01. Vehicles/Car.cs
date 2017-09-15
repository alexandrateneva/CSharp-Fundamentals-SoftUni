public class Car : Vehicle
{
    public Car(double fuelQuantity, double fuelConsumption, double tankCapacity)
        : base(fuelQuantity, fuelConsumption, tankCapacity)
    {
    }

    public override double GetRealConsumption()
    {
        return base.GetRealConsumption() + 0.9;
    }
}
