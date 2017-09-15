public class Zebra : Mammal
{
    private const string sound = "Zs";
    private const string food = "Vegetable";

    public Zebra(string animalName, double animalWeight, string livingRegion, string animalType)
        : base(animalName, animalWeight, livingRegion, animalType)
    {
        this.FavouriteFood = food;
        this.Sound = sound;
    }
}
