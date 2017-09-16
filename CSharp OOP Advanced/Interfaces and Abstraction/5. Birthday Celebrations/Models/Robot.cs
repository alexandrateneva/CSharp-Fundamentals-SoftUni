namespace _5.Birthday_Celebrations.Models
{
    using _5.Birthday_Celebrations.Interfaces;

    public class Robot : IId
    {
        public string Model { get; set; }
        public string Id { get; }

        public Robot(string model, string id)
        {
            this.Model = model;
            this.Id = id;
        }
    }
}
