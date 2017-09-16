namespace Last_Army.Models.Soldiers
{
    using System.Collections.Generic;
    using Last_Army.Models.Ammunitions;

    public class Ranker : Soldier
    {
        private const double OverallSkillMiltiplier = 1.5;
        private readonly List<string> weaponsAllowed = new List<string>
        {
            nameof(Gun),
            nameof(AutomaticMachine),
            nameof(Helmet)
        };

        public Ranker(string name, int age, double experience, double endurance)
            : base(name, age, experience, endurance)
        {
        }

        protected override IReadOnlyList<string> WeaponsAllowed => this.weaponsAllowed;

        public override double OverallSkill => base.OverallSkill * OverallSkillMiltiplier;
    }
}