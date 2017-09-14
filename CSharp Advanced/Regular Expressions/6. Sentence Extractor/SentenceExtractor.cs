namespace _6.Sentence_Extractor
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class SentenceExtractor
    {
        public static void Main()
        {
            var word = Console.ReadLine();
            var text = Console.ReadLine();
            var regex = new Regex(@".*?[\.|\?|\!]");
            var matches = regex.Matches(text);
            foreach (var sentance in matches)
            {
                var words = sentance.ToString().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (words.Contains(word))
                {
                    Console.WriteLine(sentance.ToString().Trim());
                }
            }
        }
    }
}
