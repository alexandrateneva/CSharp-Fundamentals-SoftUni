namespace _11.Palindromes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Palindromes
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(new[] { ' ', ',', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
            var result = new SortedSet<string>();
            foreach (var word in input)
            {
                var arr = word.ToCharArray();
                Array.Reverse(arr);
                var reversedWord = new string(arr);
                if (reversedWord.Equals(word))
                {
                    if (!result.Contains(word))
                    {
                        result.Add(word);
                    }
                }
            }
            Console.WriteLine($"[{string.Join(", ", result.Distinct())}]");
        }
    }
}
