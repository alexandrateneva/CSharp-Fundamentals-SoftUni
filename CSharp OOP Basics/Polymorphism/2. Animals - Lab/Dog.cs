using System;

public class Dog : Animal
{
    public Dog(string name, string faouriteFood) 
        : base(name, faouriteFood)
    {
    }

    public override string ExplainMyself()
    {
        return base.ExplainMyself() + Environment.NewLine + "DJAAF";
    }
}