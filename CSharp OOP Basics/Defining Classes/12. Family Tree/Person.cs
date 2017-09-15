using System.Collections.Generic;

public class Person
{
    public string nameOfPerson;
    public string birthday;
    public List<Person> parents;
    public List<Person> children;

    public Person()
    {
        this.children = new List<Person>();
        this.parents = new List<Person>();
    }

    public override string ToString()
    {
        return $"{this.nameOfPerson} {this.birthday}";
    }
}
