namespace _02.Coffee_Machine___Lab
{
    using System;
    using _02.Coffee_Machine___Lab.Models;

    public class Startup
    {
        public static void Main()
        {
            CoffeeMachine machine = new CoffeeMachine();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] inputArgs = input.Split();
                if (inputArgs.Length == 1)
                {
                    machine.InsertCoin(inputArgs[0]);
                }
                else
                {
                    machine.BuyCoffee(inputArgs[0], inputArgs[1]);
                }
            }

            foreach (var coffee in machine.CoffeesSold)
            {
                Console.WriteLine(coffee.CoffeeType);
            }

        }
    }
}
