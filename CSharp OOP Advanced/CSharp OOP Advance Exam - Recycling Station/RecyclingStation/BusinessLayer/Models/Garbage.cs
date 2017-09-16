namespace RecyclingStation.BusinessLayer.Models
{
    using RecyclingStation.WasteDisposal.Interfaces;

    public abstract class Garbage : IWaste
    {
        public string Name { get; set; }
        public double VolumePerKg { get; set; }
        public double Weight { get; set; }

        protected Garbage(string name, double weight, double volumePerKg)
        {
            this.Name = name;
            this.VolumePerKg = volumePerKg;
            this.Weight = weight;
        }
    }
}
