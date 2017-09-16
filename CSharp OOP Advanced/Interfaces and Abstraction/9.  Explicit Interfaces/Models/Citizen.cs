namespace _9.Explicit_Interfaces.Models
{
    using _9.Explicit_Interfaces.Interfaces;

    public class Citizen : IPerson, IResident
    {
        public string Name { get; }
        public int Age { get; }
        public string Country { get; }

        public Citizen(string name, string country, int age)
        {
            this.Name = name;
            this.Country = country;
            this.Age = age;
        }

        string IPerson.GetName()
        {
            return $"{this.Name}";
        }

        string IResident.GetName()
        {
            return $"Mr/Ms/Mrs {this.Name}";
        }
    }
}
