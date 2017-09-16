namespace Extended_Database_Problems
{
    public class Person : IPerson
    {
        public long Id { get; private set; }
        public string Username { get; private set; }

        public Person(long id, string name)
        {
            this.Id = id;
            this.Username = name;
        }
    }
}
