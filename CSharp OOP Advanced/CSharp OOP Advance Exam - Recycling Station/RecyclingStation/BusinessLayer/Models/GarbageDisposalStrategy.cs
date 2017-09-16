namespace RecyclingStation.BusinessLayer.Models
{
    using RecyclingStation.BusinessLayer.Data;
    using RecyclingStation.WasteDisposal.Interfaces;

    public abstract class GarbageDisposalStrategy : IGarbageDisposalStrategy
    {
        public IProcessingData ProcessGarbage(IWaste garbage)
        {
            double energyBalance = this.CalculateEnergyBalance(garbage);
            double capitalBalance = this.CalculateCapitalBalance(garbage);

            return new ProcessingData(energyBalance, capitalBalance);
        }

        protected abstract double CalculateEnergyBalance(IWaste garbage);

        protected abstract double CalculateCapitalBalance(IWaste garbage);
    }
}
