public class Robot : IId
{
    public string Id { get; }
    public string Model { get; set; }

    public Robot(string model, string id)
    {
        this.Model = model;
        this.Id = id;
    }
}
