namespace CSharp_OOP_Basics_Exam___Minedraft.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using CSharp_OOP_Basics_Exam___Minedraft.Factories;
    using CSharp_OOP_Basics_Exam___Minedraft.Models;

    public class DraftManager
    {
        private List<Harvester> harvesters;
        private List<Provider> providers;

        private List<Worker> allWorkers;

        private double totalEnergyStored;
        private double totalMinedOre;

        private Mode mode;

        public DraftManager()
        {
            this.mode = global::CSharp_OOP_Basics_Exam___Minedraft.Mode.Full;
            this.harvesters = new List<Harvester>();
            this.providers = new List<Provider>();
            this.allWorkers = new List<Worker>();
        }

        public string RegisterHarvester(List<string> arguments)
        {
            try
            {
                var factory = new HarvesterFactory();
                var harvester = factory.CreateHarvester(arguments);

                this.harvesters.Add(harvester);
                this.allWorkers.Add(harvester);
            }
            catch (Exception e)
            {
                return e.Message;
            }

            return $"Successfully registered {arguments[0]} Harvester - {arguments[1]}";

        }

        public string RegisterProvider(List<string> arguments)
        {
            try
            {
                var factory = new ProviderFactory();
                var provider = factory.CreateProvider(arguments);

                this.providers.Add(provider);
                this.allWorkers.Add(provider);
            }
            catch (Exception e)
            {
                return e.Message;
            }

            return $"Successfully registered {arguments[0]} Provider - {arguments[1]}";

        }

        public string Day()
        {
            var consume = 0.0;
            var produce = 0.0;
            switch (this.mode)
            {
                case global::CSharp_OOP_Basics_Exam___Minedraft.Mode.Full:
                    consume = 1;
                    produce = 1;
                    break;
                case global::CSharp_OOP_Basics_Exam___Minedraft.Mode.Half:
                    consume = 0.6;
                    produce = 0.5;
                    break;
                case global::CSharp_OOP_Basics_Exam___Minedraft.Mode.Energy:
                    consume = 0;
                    produce = 0;
                    break;
            }
            var currentEnergyStored = this.providers.Sum(p => p.EnergyOutput);
            this.totalEnergyStored += currentEnergyStored;

            var needEnergy = this.harvesters.Sum(h => h.EnergyRequirement) * consume;
            double currentMinedOre = 0;

            if (this.totalEnergyStored >= needEnergy)
            {
                this.totalEnergyStored -= needEnergy;
                currentMinedOre = this.harvesters.Sum(h => h.OreOutput) * produce;
                this.totalMinedOre += currentMinedOre;
            }

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("A day has passed.");
            sb.AppendLine($"Energy Provided: {currentEnergyStored}");
            sb.AppendLine($"Plumbus Ore Mined: {currentMinedOre}");

            return sb.ToString().Trim();
        }

        public string Mode(List<string> arguments)
        {
            var mode = arguments[0];
            this.mode = (Mode)Enum.Parse(typeof(Mode), mode);

            return $"Successfully changed working mode to {mode} Mode";
        }

        public string Check(List<string> arguments)
        {
            var worker = this.allWorkers.FirstOrDefault(w => w.Id.Equals(arguments[0]));
            if (worker != null)
            {
                return worker.ToString();
            }
            return $"No element found with id - {arguments[0]}";
        }

        public string ShutDown()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("System Shutdown");
            sb.AppendLine($"Total Energy Stored: {this.totalEnergyStored}");
            sb.AppendLine($"Total Mined Plumbus Ore: {this.totalMinedOre}");

            return sb.ToString().Trim();
        }

    }
}