using System.Collections.Generic;

public class Trainer
{
    public string name;
    public int badges;
    public List<Pokemon> pokemons;

    public Trainer(string name, List<Pokemon> pokemons)
    {
        this.name = name;
        this.badges = 0;
        this.pokemons = pokemons;
    }
}
