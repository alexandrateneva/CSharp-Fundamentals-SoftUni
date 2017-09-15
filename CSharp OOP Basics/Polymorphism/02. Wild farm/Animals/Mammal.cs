public class Mammal : Animal
{
    private string livingRegion;
    
    public Mammal(string animalName, double animalWeight, string livingRegion, string animalType) 
        : base(animalName, animalWeight, animalType)
    {
        this.livingRegion = livingRegion;
    }

    public string LivingRegion
    {
        get { return livingRegion; }
        set { livingRegion = value; }
    }

    public override string ToString()
    {
        return $"{this.AnimalType}[{this.AnimalName}, {this.AnimalWeight}, {this.LivingRegion}, {this.FoodEaten}]";
    }
}