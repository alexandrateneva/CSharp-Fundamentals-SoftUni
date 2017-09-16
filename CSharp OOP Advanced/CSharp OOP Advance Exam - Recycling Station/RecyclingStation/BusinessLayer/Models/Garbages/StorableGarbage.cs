namespace RecyclingStation.BusinessLayer.Models.Garbages
{
    using RecyclingStation.BusinessLayer.Attributes;
    using RecyclingStation.BusinessLayer.Strategies;

    [StorableStrategy(typeof(StorableGarbageDisposalStrategy))]
    public class StorableGarbage : Garbage
    {
        public StorableGarbage(string name, double weight, double volumePerKg) 
            : base(name, weight, volumePerKg)
        {
        }
    }
}
