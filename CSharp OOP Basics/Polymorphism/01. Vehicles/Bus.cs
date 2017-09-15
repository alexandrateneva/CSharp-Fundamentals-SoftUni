public class Bus : Vehicle
{
    private bool isEmpty;

    public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity)
        : base(fuelQuantity, fuelConsumption, tankCapacity)
    {
    }

    public bool IsEmpty { get; set; }

    public override double GetRealConsumption()
    {
        if (!IsEmpty)
        {
            return base.GetRealConsumption() + 1.4;
        }
        return base.GetRealConsumption();
    }
}
