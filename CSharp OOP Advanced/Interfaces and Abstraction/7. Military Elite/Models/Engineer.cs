namespace _7.Military_Elite.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using _7.Military_Elite.Interfaces;

    public class Engineer : SpecialisedSoldier, IEngineer
    {
        public List<IRepair> Repairs { get; }

        public Engineer(string id, string firstName, string lastName, double salary, string corps)
            : base(id, firstName, lastName, salary, corps)
        {
            this.Repairs = new List<IRepair>();
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.Append("Repairs:");
            if (this.Repairs.Count > 0)
            {
                sb.AppendLine();
                sb.Append("  " + string.Join(Environment.NewLine + "  ", this.Repairs));
            }

            return sb.ToString();
        }
    }
}
