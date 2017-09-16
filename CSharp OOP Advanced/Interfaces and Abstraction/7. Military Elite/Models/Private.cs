namespace _7.Military_Elite.Models
{
    using _7.Military_Elite.Interfaces;

    public class Private :  Soldier, IPrivate
    {
        public double Salary { get; }

        public Private(string id, string firstName, string lastName, double salary) 
            : base(id, firstName, lastName)
        {
            this.Salary = salary;
        }
        
        public override string ToString()
        {
            return $"{base.ToString()} Salary: {this.Salary:F2}";
        }
    }
}