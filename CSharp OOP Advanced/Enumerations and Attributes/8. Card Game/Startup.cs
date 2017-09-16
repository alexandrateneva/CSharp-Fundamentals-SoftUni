namespace _8.Card_Game
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using _8.Card_Game.Enums;
    using _8.Card_Game.Models;

    public class Startup
    {
        public static void Main()
        {
            var players = new Dictionary<string, SortedSet<Card>>();
            var firstName = Console.ReadLine();
            players.Add(firstName, new SortedSet<Card>());
            var secondName = Console.ReadLine();
            players.Add(secondName, new SortedSet<Card>());
            
            var allCards = new SortedSet<Card>();

            while (players[firstName].Count <= 5 && players[secondName].Count < 5)
            {
                var cardInfo = Console.ReadLine().Split(' ');
                var isValidSuit = true;
                Rank rank;
                Enum.TryParse(cardInfo[0], false, out rank);
                Suit suit;
                if (cardInfo[2] == "Clubs")
                {
                    suit = Suit.Clubs;
                }
                else
                {
                    Enum.TryParse(cardInfo[2], false, out suit);
                    if (suit == 0)
                    {
                        isValidSuit = false;
                    }
                }
                try
                {
                    var card = Card.CreateCard(rank, suit, isValidSuit);
                    if (players[firstName].Count < 5)
                    {
                        AddCard(players[firstName], card, allCards);
                        allCards.Add(card);
                    }
                    else
                    {
                        AddCard(players[secondName], card, allCards);
                        allCards.Add(card);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            PrintWinner(players, firstName, secondName, allCards);
        }

        public static void AddCard(SortedSet<Card> cards, Card card, SortedSet<Card> allCards)
        {
            if (!allCards.Contains(card))
            {
                cards.Add(card);
            }
            else
            {
                Console.WriteLine("Card is not in the deck.");
            }
        }

        public static void PrintWinner(Dictionary<string, SortedSet<Card>> players, string firstPLayer, string secondPlayer, SortedSet<Card> allCards)
        {
            var greatestCard = allCards.Last();
            if (players[firstPLayer].Contains(greatestCard))
            {
                Console.WriteLine($"{firstPLayer} wins with {greatestCard}.");
            }
            else
            {
                Console.WriteLine($"{secondPlayer} wins with {greatestCard}.");
            }
        }
    }
}
