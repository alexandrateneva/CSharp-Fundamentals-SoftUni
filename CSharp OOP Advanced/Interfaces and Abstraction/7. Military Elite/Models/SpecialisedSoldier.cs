using System;

namespace _7.Military_Elite.Models
{
    using _7.Military_Elite.Interfaces;

    public abstract class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        public string Corps { get; }

        protected SpecialisedSoldier(string id, string firstName, string lastName, double salary, string corps)
            : base(id, firstName, lastName, salary)
        {
            this.Corps = corps;
        }

        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + $"Corps: {this.Corps}";
        }
    }
}
