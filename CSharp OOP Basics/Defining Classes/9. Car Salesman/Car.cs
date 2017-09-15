public class Car
{
    public string model;
    public Engine engine;
    public int weight;
    public string color;

    public Car(string model, Engine engine)
    {
        this.model = model;
        this.engine = engine;
        this.color = "n/a";
        this.weight = 0;
    }

    public override string ToString()
    {
        string result;
        string empty = "n/a";
        if (this.engine.displacement == 0 && this.weight == 0)
        {
            result = $"{this.model}:\n  {this.engine.model}:\n    Power: {this.engine.power}\n    Displacement: {empty}\n   Efficiency: {this.engine.efficiency}\n Weight: {empty}\n Color: {this.color}";
        }
        else if (this.engine.displacement == 0)
        {
            result = $"{this.model}:\n  {this.engine.model}:\n    Power: {this.engine.power}\n    Displacement: {empty}\n   Efficiency: {this.engine.efficiency}\n Weight: {this.weight}\n Color: {this.color}";
        }
        else if (this.weight == 0)
        {
            result = $"{this.model}:\n  {this.engine.model}:\n    Power: {this.engine.power}\n    Displacement: {this.engine.displacement}\n   Efficiency: {this.engine.efficiency}\n Weight: {empty}\n Color: {this.color}";
        }
        else
        {
            result = $"{this.model}:\n  {this.engine.model}:\n    Power: {this.engine.power}\n    Displacement: {this.engine.displacement}\n   Efficiency: {this.engine.efficiency}\n Weight: {this.weight}\n Color: {this.color}";
        }
        return result;
    }
}
