namespace _7.Deck_of_Cards
{
    using System;
    using System.Linq;
    using _7.Deck_of_Cards.Enums;

    public class Startup
    {
        public static void Main()
        {
            var allRanks = Enum.GetValues(typeof(Rank)).OfType<Rank>().ToList();
            var last = allRanks[allRanks.Count - 1];
            allRanks.RemoveAt(allRanks.Count - 1);
            allRanks.Insert(0, last);
            var allSuits = Enum.GetValues(typeof(Suit));

            foreach (var suit in allSuits)
            {
                foreach (var rank in allRanks)
                {
                    Console.WriteLine($"{rank} of {suit}");
                }
            }
        }
    }
}
