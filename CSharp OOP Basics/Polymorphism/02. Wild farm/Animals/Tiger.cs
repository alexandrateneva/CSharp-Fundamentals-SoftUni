public class Tiger : Felime
{
    private const string sound = "ROAAR!!!";
    private const string food = "Meat";

    public Tiger(string animalName, double animalWeight, string livingRegion, string animalType)
        : base(animalName, animalWeight, livingRegion, animalType)
    {
        this.Sound = sound;
        this.FavouriteFood = food;
    }
}
