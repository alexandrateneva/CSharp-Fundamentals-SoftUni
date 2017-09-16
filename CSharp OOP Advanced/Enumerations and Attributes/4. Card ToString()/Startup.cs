namespace _4.Card_ToString__
{
    using System;
    using _4.Card_ToString__.Enums;
    using _4.Card_ToString__.Models;

    public class Startup
    {
        public static void Main()
        {
            var rank = (Rank)Enum.Parse(typeof(Rank), Console.ReadLine());
            var suit = (Suit)Enum.Parse(typeof(Suit), Console.ReadLine());

            var card = new Card(rank, suit);
            Console.WriteLine(card);
        }
    }
}
