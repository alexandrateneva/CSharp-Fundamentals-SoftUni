namespace CSharp_OOP_Basics_Exam___Minedraft.Models.Providers
{
    using System.Text;

    public class SolarProvider : Provider
    {
        public SolarProvider(string id, double energyOutput)
            : base(id, energyOutput)
        {
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Solar Provider - {this.Id}");
            sb.AppendLine(base.ToString());

            return sb.ToString().Trim();
        }
    }
}
