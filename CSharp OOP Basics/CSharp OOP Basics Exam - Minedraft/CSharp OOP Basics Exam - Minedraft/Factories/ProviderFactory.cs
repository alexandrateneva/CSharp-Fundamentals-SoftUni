namespace CSharp_OOP_Basics_Exam___Minedraft.Factories
{
    using System;
    using System.Collections.Generic;
    using CSharp_OOP_Basics_Exam___Minedraft.Models;
    using CSharp_OOP_Basics_Exam___Minedraft.Models.Providers;

    public class ProviderFactory
    {
        public Provider CreateProvider(List<string> arguments)
        {
            var type = arguments[0];
            var id = arguments[1];
            var energyOutput = double.Parse(arguments[2]);

            switch (type)
            {
                case "Solar":
                    return new SolarProvider(id, energyOutput);
                case "Pressure":
                    return new PressureProvider(id, energyOutput);
            }

            throw new ArgumentException("Invalid provider type.");
        }
    }
}
