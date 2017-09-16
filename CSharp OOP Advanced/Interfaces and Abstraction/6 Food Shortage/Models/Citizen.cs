namespace _6_Food_Shortage.Models
{
    using _6_Food_Shortage.Interfaces;

    public class Citizen : IPerson, IBuyer
    {
        public string Name { get; }
        public int Age { get; }
        public string Id { get; set; }
        public string DateOfBirth { get; set; }
        public int Food { get; private set; }

        public Citizen(string name, int age, string id, string dateOfBirth)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.DateOfBirth = dateOfBirth;
        }

        public void BuyFood()
        {
            this.Food += 10;
        }
    }
}
