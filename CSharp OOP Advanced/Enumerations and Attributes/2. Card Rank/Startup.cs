namespace _2.Card_Rank
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            Console.WriteLine("Card Ranks:");
            var values = Enum.GetValues(typeof(Rank));
            foreach (var value in values)
            {
                Console.WriteLine($"Ordinal value: {(int)value}; Name value: {value}");
            }
        }
    }
}
