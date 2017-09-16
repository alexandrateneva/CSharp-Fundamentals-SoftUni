namespace _1.Define_an_Interface_IPerson.Models
{
    using _1.Define_an_Interface_IPerson.Interfaces;

    public class Citizen : IPerson, IBirthable, IIdentifiable
    {
        public string Name { get; }
        public int Age { get; }
        public string Birthdate { get; }
        public string Id { get; }

        public Citizen(string name, int age, string birthdate, string id)
        {
            this.Name = name;
            this.Age = age;
            this.Birthdate = birthdate;
            this.Id = id;
        }
    }
}
