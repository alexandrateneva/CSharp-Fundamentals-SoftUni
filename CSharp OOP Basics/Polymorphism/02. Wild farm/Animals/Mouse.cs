public class Mouse : Mammal
{
    private const string sound = "SQUEEEAAAK!";
    private const string food = "Vegetable";

    public Mouse(string animalName, double animalWeight, string livingRegion, string animalType) 
        : base(animalName, animalWeight, livingRegion, animalType)
    {
        this.FavouriteFood = food;
        this.Sound = sound;
    }
}
