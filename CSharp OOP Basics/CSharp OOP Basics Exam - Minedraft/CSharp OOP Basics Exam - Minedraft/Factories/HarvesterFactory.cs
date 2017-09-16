namespace CSharp_OOP_Basics_Exam___Minedraft.Factories
{
    using System;
    using System.Collections.Generic;
    using CSharp_OOP_Basics_Exam___Minedraft.Models;
    using CSharp_OOP_Basics_Exam___Minedraft.Models.Harvesters;

    public class HarvesterFactory
    {
        public Harvester CreateHarvester(List<string> arguments)
        {
            var type = arguments[0];
            var id = arguments[1];
            var oreOutput = double.Parse(arguments[2]);
            var energyRequirement = double.Parse(arguments[3]);

            switch (type)
            {
                case "Sonic":
                    var sonicFactor = int.Parse(arguments[4]);
                    return new SonicHarvester(id, oreOutput, energyRequirement, sonicFactor);
                case "Hammer":
                    return new HammerHarvester(id, oreOutput, energyRequirement);
            }

            throw new ArgumentException("Invalid harvester type.");
        }
    }
}