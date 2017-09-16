namespace _02.Cars___Lab.Interfaces
{
    public interface ICar
    {
        string Model { get; }
        string Color { get; }
        string Start();
        string Stop();
    }
}
