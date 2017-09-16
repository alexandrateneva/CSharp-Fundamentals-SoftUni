namespace RecyclingStation.BusinessLayer.Interfaces.Core
{
    public interface IRecyclingStation
    {
        string ProcessGarbage(string name, double weight, double volumePerKg, string type);

        string Status();
    }
}
