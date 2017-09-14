namespace _4.Count_Symbols
{
    using System;
    using System.Collections.Generic;

    public class CountSymbols
    {
        public static void Main()
        {
            var text = Console.ReadLine().ToCharArray();
            var symbols = new SortedDictionary<char, int>();

            foreach (var character in text)
            {
                if (!symbols.ContainsKey(character))
                {
                    symbols.Add(character, 1);
                }
                else
                {
                    symbols[character]++;
                }
            }
            foreach (var symbol in symbols)
            {
                Console.WriteLine($"{symbol.Key}: {symbol.Value} time/s");
            }
        }
    }
}
