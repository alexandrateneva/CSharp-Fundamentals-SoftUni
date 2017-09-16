namespace _5.Card_CompareTo__
{
    using System;
    using _5.Card_CompareTo__.Enums;
    using _5.Card_CompareTo__.Models;

    public class Startup
    {
        public static void Main()
        {
            var rankOfFirstCard = (Rank)Enum.Parse(typeof(Rank), Console.ReadLine());
            var suitOfFirstCard = (Suit)Enum.Parse(typeof(Suit), Console.ReadLine());
            var firstCard = new Card(rankOfFirstCard, suitOfFirstCard);

            var rankOfSecondCard = (Rank)Enum.Parse(typeof(Rank), Console.ReadLine());
            var suitOfSecondCard = (Suit)Enum.Parse(typeof(Suit), Console.ReadLine());
            var seconCard = new Card(rankOfSecondCard, suitOfSecondCard);

            Card greaterCard;
            var compare = firstCard.CompareTo(seconCard);
            if (compare > 0)
            {
                greaterCard = firstCard;
            }
            else
            {
                greaterCard = seconCard;
            }
            Console.WriteLine(greaterCard);
        }
    }
}
