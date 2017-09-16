namespace _1.Card_Suit
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            Console.WriteLine("Card Suits:");
            var values = Enum.GetValues(typeof(Suit));
            foreach (var value in values)
            {
                Console.WriteLine($"Ordinal value: {(int)value}; Name value: {value}");
            }
        }
    }
}
