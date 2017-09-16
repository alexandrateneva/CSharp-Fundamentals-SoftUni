namespace RecyclingStation
{
    using System;
    using System.Collections.Generic;
    using RecyclingStation.BusinessLayer.Core;
    using RecyclingStation.BusinessLayer.Factories;
    using RecyclingStation.BusinessLayer.Interfaces.Core;
    using RecyclingStation.BusinessLayer.Interfaces.Factories;
    using RecyclingStation.BusinessLayer.Interfaces.IO;
    using RecyclingStation.BusinessLayer.IO;
    using RecyclingStation.WasteDisposal;
    using RecyclingStation.WasteDisposal.Interfaces;

    public class Startup
    {
        public static void Main()
        {
            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();
            
            IStrategyHolder strategyHolder = new StrategyHolder(new Dictionary<Type, IGarbageDisposalStrategy>());

            IGarbageProcessor garbageProcessor = new GarbageProcessor(strategyHolder);
            IWasteFactory wasteFactory = new WasteFactory();

            IRecyclingStation recyclingStation = new RecyclingManager(garbageProcessor, wasteFactory);

            IEngine engine = new Engine(reader, writer, recyclingStation);
            engine.Run();
        }
    }
}
