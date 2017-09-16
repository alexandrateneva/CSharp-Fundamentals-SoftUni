namespace _02.Coffee_Machine___Lab.Models
{
    using System;
    using System.Collections.Generic;
    using _02.Coffee_Machine___Lab.Enums;

    public class CoffeeMachine
    {
        public int valueOfCoins { get; set; }

        public readonly List<Coffee> CoffeesSold;

        public CoffeeMachine()
        {
            this.CoffeesSold = new List<Coffee>();
        }

        public void InsertCoin(string coin)
        {
            var valueOfCoin = (Coin)Enum.Parse(typeof(Coin), coin);
            this.valueOfCoins += (int)valueOfCoin;
        }

        public void BuyCoffee(string size, string type)
        {
            var coffee = new Coffee(size, type);
            if (this.valueOfCoins >= coffee.Price)
            {
                this.CoffeesSold.Add(coffee);
            }
        }
    }
}
