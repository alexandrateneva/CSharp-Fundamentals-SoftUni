namespace _3.Card_Power
{
    using System;

    public class Card
    {
        public enum Rank
        {
            Ace = 14,
            Two = 2,
            Three = 3,
            Four = 4,
            Five = 5,
            Six = 6,
            Seven= 7,
            Eight = 8,
            Nine = 9,
            Ten = 10,
            Jack = 11,
            Queen = 12,
            King = 13
        }

        public enum Suit
        {
            Clubs = 0,
            Diamonds = 13,
            Hearts = 26,
            Spades = 39
        }

        public int GetPower(string rank, string suit)
        {
            var cardRank = (int)Enum.Parse(typeof(Rank), rank);
            var cardSuit = (int)Enum.Parse(typeof(Suit), suit);
            return cardSuit + cardRank;
        }
    }
}
