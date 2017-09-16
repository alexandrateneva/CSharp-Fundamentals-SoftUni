namespace CSharp_OOP_Basics_Exam___Minedraft.Models
{
    using System;
    using System.Text;

    public abstract class Provider : Worker
    {
        private const string message = "Provider is not registered, because of it's {0}";

        private double energyOutput;

        protected Provider(string id, double energyOutput)
            : base(id)
        {
            this.Id = id;
            this.EnergyOutput = energyOutput;
        }

        public double EnergyOutput
        {
            get { return this.energyOutput; }
            protected set
            {
                if (value < 0 || value > 10000)
                {
                    throw new ArgumentException(String.Format(message, nameof(this.EnergyOutput)));
                }
                this.energyOutput = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Energy Output: {this.EnergyOutput}");

            return sb.ToString().Trim();
        }
    }
}
