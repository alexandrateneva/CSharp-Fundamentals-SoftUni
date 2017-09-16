namespace Last_Army.Models.Ammunitions
{
    using Last_Army.Interfaces.Models;

    public abstract class Ammunition : IAmmunition
    {
        private const int WearLevelMultiplier = 100;

        protected Ammunition(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
            this.WearLevel = this.Weight * WearLevelMultiplier;
        }

        public string Name { get; }

        public double Weight { get; }

        public double WearLevel { get; private set; }

        public void DecreaseWearLevel(double wearAmount) => this.WearLevel -= wearAmount;
    }
}