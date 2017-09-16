namespace _8.Card_Game.Models
{
    using System;
    using _8.Card_Game.Enums;

    public class Card : IComparable<Card>
    {
        public Rank Rank { get; private set; }
        public Suit Suit { get; private set; }

        public Card(Rank rank, Suit suit)
        {
            this.Rank = rank;
            this.Suit = suit;
        }

        public int GetPower()
        {
            return (int) this.Rank + (int) this.Suit;
        }

        public int CompareTo(Card other)
        {
            return this.GetPower().CompareTo(other.GetPower());
        }

        public static Card CreateCard(Rank rank, Suit suit, bool invalidSuit)
        {
            if (rank == 0 || invalidSuit == false)
            {
                throw new ArgumentException("No such card exists.");
            }
            return new Card(rank, suit);
        }

        public override string ToString()
        {
            return $"{this.Rank} of {this.Suit}";
        }
    }
}
