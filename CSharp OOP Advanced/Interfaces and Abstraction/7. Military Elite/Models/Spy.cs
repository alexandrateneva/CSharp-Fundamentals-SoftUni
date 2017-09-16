namespace _7.Military_Elite.Models
{
    using System;
    using _7.Military_Elite.Interfaces;

    public class Spy : Soldier, ISpy
    {
        public int CodeNumber { get; }

        public Spy(string id, string firstName, string lastName, int codeNumber)
            : base(id, firstName, lastName)
        {
            this.CodeNumber = codeNumber;
        }

        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + $"Code Number: {this.CodeNumber}";
        }
    }
}
