namespace _7.Military_Elite.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using _7.Military_Elite.Interfaces;

    public class Commando : SpecialisedSoldier, ICommando
    {
        public List<IMission> Missions { get; }

        public Commando(string id, string firstName, string lastName, double salary, string corps)
            : base(id, firstName, lastName, salary, corps)
        {
            this.Missions = new List<IMission>();
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.Append("Missions:");
            if (this.Missions.Count > 0)
            {
                sb.AppendLine();
                sb.Append("  " + string.Join(Environment.NewLine + "  ", this.Missions));
            }

            return sb.ToString();
        }
    }
}
