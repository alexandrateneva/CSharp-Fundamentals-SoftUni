namespace _3.Word_Count
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class WordCount
    {
        public static void Main()
        {
            using (var readerWords = new StreamReader("../../words.txt"))
            using (var readerText = new StreamReader("../../text.txt"))
            using (var writer = new StreamWriter("../../result.txt"))
            {
                var words = readerWords
                     .ReadToEnd()
                     .ToLower()
                     .Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

                var text = readerText
                    .ReadToEnd()
                    .ToLower()
                    .Split(new char[] { '\n', '\r', '.', ',', '?', '!', ' ', '-' }, StringSplitOptions.RemoveEmptyEntries);

                var result = new Dictionary<string, int>();

                for (int i = 0; i < text.Length; i++)
                {
                    var currentElement = text[i].ToLower();
                    if (words.Contains(currentElement))
                    {
                        if (!result.ContainsKey(currentElement))
                        {
                            result.Add(currentElement, 0);
                        }
                        result[currentElement]++;
                    }
                }

                foreach (var word in result.OrderByDescending(x => x.Value))
                {
                    writer.WriteLine($"{word.Key} - {word.Value}");
                }
            }
        }
    }
}
