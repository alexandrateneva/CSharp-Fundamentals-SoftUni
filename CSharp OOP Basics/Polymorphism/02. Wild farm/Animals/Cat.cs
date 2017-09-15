using System.Media;

public class Cat : Felime
{
    private const string sound = "Meowwww";
    private string breed;

    public Cat(string animalName, double animalWeight, string livingRegion, string breed, string animalType) 
        : base(animalName, animalWeight, livingRegion, animalType)
    {
        this.Sound = sound;
        this.Breed = breed;
    }

    public string Breed
    {
        get { return breed; }
        set { breed = value; }
    }

    public override void Eat(Food food)
    {
        base.FoodEaten += food.Quantity;
    }

    public override string ToString()
    {
        return $"{this.AnimalType}[{this.AnimalName}, {this.Breed}, {this.AnimalWeight}, {this.LivingRegion}, {FoodEaten}]";
    }
}
