namespace _3.Pizza_Calories
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            try
            {
                string inputLine;
                while ((inputLine = Console.ReadLine()) != "END")
                {
                    var tokens = inputLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    var command = tokens[0];
                    switch (command)
                    {
                        case "Pizza":
                            var pizza = new Pizza(tokens[1], int.Parse(tokens[2]));
                            var doughInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                            pizza.Dough = new Dough(doughInfo[1], doughInfo[2], double.Parse(doughInfo[3]));
                            for (int i = 0; i < int.Parse(tokens[2]); i++)
                            {
                                var toppingInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                                var currentTopping = new Topping(toppingInfo[1], int.Parse(toppingInfo[2]));
                                pizza.AddTopping(currentTopping);
                            }
                            Console.WriteLine($"{pizza.Name} - {pizza.GetTotalCalories():F2} Calories.");
                            break;
                        case "Dough":
                            var dough = new Dough(tokens[1], tokens[2], double.Parse(tokens[3]));
                            Console.WriteLine($"{dough.GetTotalCalories():F2}");
                            break;
                        case "Topping":
                            var topping = new Topping(tokens[1], int.Parse(tokens[2]));
                            Console.WriteLine($"{topping.GetTotalCalories():F2}");
                            break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
