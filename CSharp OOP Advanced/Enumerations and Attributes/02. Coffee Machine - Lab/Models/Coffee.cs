namespace _02.Coffee_Machine___Lab.Models
{
    using System;
    using _02.Coffee_Machine___Lab.Enums;

    public class Coffee
    {
        public CoffeePrice CoffeeSize { get; set; }
        public CoffeeType CoffeeType { get; set; }

        public int Price => (int) this.CoffeeSize;

        public Coffee(string size, string type)
        {
            var coffeeSize = (CoffeePrice)Enum.Parse(typeof(CoffeePrice), size);
            var coffeeType = (CoffeeType)Enum.Parse(typeof(CoffeeType), type);

            this.CoffeeSize = coffeeSize;
            this.CoffeeType = coffeeType;
        }  
    }
}
