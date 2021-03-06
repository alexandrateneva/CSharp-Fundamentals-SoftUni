﻿namespace CSharp_OOP_Basics_Exam___Minedraft.Models
{
    using System;
    using System.Text;

    public abstract class Harvester : Worker
    {
        private const string message = "Harvester is not registered, because of it's {0}";

        private double oreOutput;

        private double energyRequirement;

        protected Harvester(string id, double oreOutput, double energyRequirement)
            : base(id)
        {
            this.Id = id;
            this.OreOutput = oreOutput;
            this.EnergyRequirement = energyRequirement;
        }

        public double EnergyRequirement
        {
            get { return this.energyRequirement; }
            protected set
            {
                if (value < 0 || value > 20000)
                {
                    throw new ArgumentException(String.Format(message, nameof(this.EnergyRequirement)));
                }
                this.energyRequirement = value;
            }
        }

        public double OreOutput
        {
            get { return this.oreOutput; }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException(String.Format(message, nameof(this.OreOutput)));
                }
                this.oreOutput = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Ore Output: {this.OreOutput}");
            sb.AppendLine($"Energy Requirement: {this.EnergyRequirement}");

            return sb.ToString().Trim();
        }
    }
}
