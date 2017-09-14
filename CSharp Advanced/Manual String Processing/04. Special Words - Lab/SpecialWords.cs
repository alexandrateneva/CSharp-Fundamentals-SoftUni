namespace _04.Special_Words___Lab
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SpecialWords
    {
        public static void Main()
        {
            var specialWords = Console.ReadLine().Split();
            var result = new Dictionary<string, int>();
            foreach (var word in specialWords)
            {
                result.Add(word, 0);
            }

            var text = Console.ReadLine().Split(new[] { '(', ')', '[', ']', '<', '>', ',', '-', '!', '?', ' ' },
                StringSplitOptions.RemoveEmptyEntries);

            foreach (var word in text)
            {
                if (specialWords.Contains(word))
                {
                    result[word]++;
                }
            }

            foreach (var specialWord in result)
            {
                Console.WriteLine($"{specialWord.Key} - {specialWord.Value}");
            }
        }
    }
}
