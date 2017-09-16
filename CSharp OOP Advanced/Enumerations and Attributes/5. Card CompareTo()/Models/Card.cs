namespace _5.Card_CompareTo__.Models
{
    using System;
    using _5.Card_CompareTo__.Enums;

    public class Card : IComparable<Card>
    {
        public Rank Rank { get; set; }

        public Suit Suit { get; set; }

        public Card(Rank rank, Suit suit)
        {
            this.Rank = rank;
            this.Suit = suit;
        }

        public int GetPower()
        {
            return (int)this.Rank + (int)this.Suit;
        }

        public int CompareTo(Card other)
        {
            return this.GetPower().CompareTo(other.GetPower());
        }

        public override string ToString()
        {
            return $"Card name: {this.Rank} of {this.Suit}; Card power: {this.GetPower()}";
        }
    }
}
