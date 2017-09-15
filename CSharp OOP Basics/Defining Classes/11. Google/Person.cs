using System.Collections.Generic;

public class Person
{
    public string nameOfPerson;
    public Car car;
    public List<Child> children;
    public Company company;
    public List<Parent> parents;
    public List<Pokemon> pokemons;

    public Person(string nameOfPerson)
    {
        this.nameOfPerson = nameOfPerson;
        this.pokemons = new List<Pokemon>();
        this.parents = new List<Parent>();
        this.children = new List<Child>();
    }
}
