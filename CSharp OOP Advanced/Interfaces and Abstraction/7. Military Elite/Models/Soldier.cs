namespace _7.Military_Elite.Models
{
    using _7.Military_Elite.Interfaces;

    public abstract class Soldier : ISoldier
    {
        public string Id { get; }
        public string FirstName { get; }
        public string LastName { get; }

        protected Soldier(string id, string firstName, string lastName)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public override string ToString()
        {
            return $"Name: {this.FirstName} {this.LastName} Id: {this.Id}";
        }
    }
}