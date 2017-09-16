namespace _5.Birthday_Celebrations.Models
{
    using _5.Birthday_Celebrations.Interfaces;

    public class Citizen : IId, IIdenifier
    {
        public string Name { get; set; }
        public string Id { get; }
        public int Age { get; set; }
        public string DateOfBirth { get; }

        public Citizen(string name, int age, string id, string dateOfBirth)
        {
            this.Name = name;
            this.Id = id;
            this.Age = age;
            this.DateOfBirth = dateOfBirth;
        }
    }
}
