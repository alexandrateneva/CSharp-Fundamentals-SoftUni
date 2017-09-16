namespace CSharp_OOP_Basics_Exam___Minedraft.Models.Harvesters
{
    using System.Text;

    public class SonicHarvester : Harvester
    {
        private int sonicFactor;

        public int SonicFactor
        {
            get { return this.sonicFactor; }
            set { this.sonicFactor = value; }
        }

        public SonicHarvester(string id, double oreOutput, double energyRequirement, int sonicFactor)
            : base(id, oreOutput, energyRequirement)
        {
            this.SonicFactor = sonicFactor;
            this.EnergyRequirement /= this.SonicFactor;
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Sonic Harvester - {this.Id}");
            sb.AppendLine(base.ToString());

            return sb.ToString().Trim();
        }
    }
}
