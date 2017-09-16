namespace CSharp_OOP_Basics_Exam___Avatar.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Nation
    {
        private List<Bender> benders;
        private List<Monument> monuments;

        public Nation()
        {
            this.benders = new List<Bender>();
            this.monuments = new List<Monument>();
        }

        public List<Monument> Monuments
        {
            get { return this.monuments; }
            set { this.monuments = value; }
        }

        public List<Bender> Benders
        {
            get { return this.benders; }
            set { this.benders = value; }
        }

        public void AddBender(Bender bender) => this.benders.Add(bender);

        public void AddMonument(Monument monument) => this.monuments.Add(monument);

        public double GetTotalPoints()
        {
            var totalBendersPower = this.benders.Sum(b => b.GetBenderPower());
            var totalMonumentsBonus = this.monuments.Sum(m => m.GetAffinity());
            var totalPowerIncrease = totalBendersPower / 100 * totalMonumentsBonus;

            return totalBendersPower + totalPowerIncrease;
        }

        public void DestroyBendersAndMonuments()
        {
            this.benders.Clear();
            this.monuments.Clear();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (this.benders.Count > 0)
            {
                sb.AppendLine($"Benders:");
                sb.AppendLine(string.Join(Environment.NewLine, this.benders));
            }
            else
            {
                sb.AppendLine("Benders: None");
            }

            if (this.monuments.Count > 0)
            {
                sb.AppendLine($"Monuments:");
                sb.AppendLine(string.Join(Environment.NewLine, this.monuments));
            }
            else
            {
                sb.AppendLine("Monuments: None");
            }

            return sb.ToString().Trim();
        }
    }
}
