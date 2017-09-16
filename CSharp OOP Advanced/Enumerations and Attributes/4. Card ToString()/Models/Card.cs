namespace _4.Card_ToString__.Models
{
    using _4.Card_ToString__.Enums;

    public class Card
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
            return (int) this.Rank + (int) this.Suit;
        }

        public override string ToString()
        {
            return $"Card name: {this.Rank} of {this.Suit}; Card power: {this.GetPower()}";
        }
    }
}
