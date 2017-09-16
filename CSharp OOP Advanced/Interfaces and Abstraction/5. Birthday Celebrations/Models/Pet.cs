namespace _5.Birthday_Celebrations.Models
{
    using _5.Birthday_Celebrations.Interfaces;

    public class Pet : IIdenifier
    {
        public string Name { get; }
        public string DateOfBirth { get; }

        public Pet(string name, string dateOfBirth)
        {
            this.Name = name;
            this.DateOfBirth = dateOfBirth;
        }
    }
}
