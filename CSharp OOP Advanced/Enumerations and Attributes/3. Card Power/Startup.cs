namespace _3.Card_Power
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var card = new Card();
            var rank = Console.ReadLine();
            var suit = Console.ReadLine();
            var power = card.GetPower(rank, suit);

            Console.WriteLine($"Card name: {rank} of {suit}; Card power: {power}");
        }
    }
}
