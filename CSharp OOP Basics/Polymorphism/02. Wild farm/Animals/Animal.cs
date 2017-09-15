using System;

public abstract class Animal
{
    private string animalName;
    private string animalType;
    private double animalWeight;
    private int foodEaten;
    private string favouriteFood;
    private string sound;

    public Animal(string animalName, double animalWeight, string animalType)
    {
        this.AnimalName = animalName;
        this.AnimalWeight = animalWeight;
        this.AnimalType = animalType;
    }

    public string Sound
    {
        get { return sound; }
        set { sound = value; }
    }

    public string FavouriteFood
    {
        get { return favouriteFood; }
        set { favouriteFood = value; }
    }

    public int FoodEaten
    {
        get { return foodEaten; }
        set { foodEaten = value; }
    }

    public double AnimalWeight
    {
        get { return animalWeight; }
        set { animalWeight = value; }
    }

    public string AnimalType
    {
        get { return animalType; }
        set { animalType = value; }
    }

    public string AnimalName
    {
        get { return animalName; }
        set { animalName = value; }
    }

    public void MakeSound()
    {
        Console.WriteLine(this.Sound);
    }

    public virtual void Eat(Food food)
    {
        if (!food.GetType().Name.Equals(favouriteFood))
        {
            Console.WriteLine($"{this.GetType().Name}s are not eating that type of food!");
        }
        else
        {
            this.foodEaten += food.Quantity;
        }
    }
}
