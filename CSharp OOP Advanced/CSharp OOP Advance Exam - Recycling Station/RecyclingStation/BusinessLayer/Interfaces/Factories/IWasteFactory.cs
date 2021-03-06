﻿namespace RecyclingStation.BusinessLayer.Interfaces.Factories
{
    using RecyclingStation.WasteDisposal.Interfaces;

    public interface IWasteFactory
    {
        IWaste Create(string name, double weight, double volumePerKg, string type);
    }
}
