public class Citizen : IId
{
    public string Id { get; }
    public int Age { get; set; }
    public string Name { get; set; }

    public Citizen(string name, int age, string id)
    {
        this.Name = name;
        this.Id = id;
        this.Age = age;
    }
}
