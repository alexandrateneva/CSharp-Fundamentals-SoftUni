namespace _2.Ferrari.Interfaces
{
    public interface ICar
    {
        string Model { get; set; }
        string DriverName { get; set; }
        string Brakes();
        string PushTheGas();
    }
}
