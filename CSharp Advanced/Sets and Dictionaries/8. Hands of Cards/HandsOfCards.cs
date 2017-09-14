namespace _8.Hands_of_Cards
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class HandsOfCards
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var result = new Dictionary<string, HashSet<string>>();

            while (input != "JOKER")
            {
                var current = input.Split(':');
                var name = current[0];
                var cards = current[1].Split(',').Select(a => a.Trim()).ToHashSet();
                if (!result.ContainsKey(name))
                {
                    result.Add(name, cards);
                }
                else
                {
                    var tillNow = result[name];
                    tillNow.UnionWith(cards);
                    result[name] = tillNow;
                }

                input = Console.ReadLine();
            }
            foreach (var person in result)
            {
                var allCardsValue = 0;

                foreach (var card in person.Value)
                {
                    var cardValue = card.ToCharArray();
                    var powerSymbol = cardValue[0];
                    var typeSymbol = cardValue[1];
                    var power = 0;
                    var type = 0;
                                     
                    if (cardValue.Length == 3)
                    {
                        power = 10;
                        typeSymbol = cardValue[2];
                    }
                    else
                    {
                        switch (powerSymbol)
                        {
                            case 'J': power = 11; break;
                            case 'Q': power = 12; break;
                            case 'K': power = 13; break;
                            case 'A': power = 14; break;
                            default: power = (powerSymbol - '0'); break;
                        }
                    }
                    switch (typeSymbol)
                    {
                        case 'S': type = 4; break;
                        case 'H': type = 3; break;
                        case 'D': type = 2; break;
                        case 'C': type = 1; break;
                    }

                    var value = type * power;
                    allCardsValue += value;                  
                }
                Console.WriteLine($"{person.Key}: {allCardsValue}");
            }
        }
    }

    public static class Extensions
    {
        public static HashSet<T> ToHashSet<T>(this IEnumerable<T> source)
        {
            return new HashSet<T>(source);
        }
    }
}
