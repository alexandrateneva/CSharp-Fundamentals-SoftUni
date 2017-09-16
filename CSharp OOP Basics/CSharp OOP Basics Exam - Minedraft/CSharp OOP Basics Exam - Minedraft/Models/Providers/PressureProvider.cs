namespace CSharp_OOP_Basics_Exam___Minedraft.Models.Providers
{
    using System.Text;

    public class PressureProvider : Provider
    {
        public PressureProvider(string id, double energyOutput)
            : base(id, energyOutput)
        {
            this.EnergyOutput *= 1.5;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Pressure Provider - {this.Id}");
            sb.AppendLine(base.ToString());

            return sb.ToString().Trim();
        }
    }
}
