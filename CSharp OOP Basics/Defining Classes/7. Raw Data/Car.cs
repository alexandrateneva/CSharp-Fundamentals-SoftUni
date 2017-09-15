using System.Collections.Generic;

public class Car
{
    public string model;
    public Cargo cargo;
    public Engine engine;
    public List<Tyre> tyres;

    public Car(string model, Cargo cargo, Engine engine, List<Tyre> tyres)
    {
        this.model = model;
        this.cargo = cargo;
        this.engine = engine;
        this.tyres = tyres;
    }
}
