namespace _10.Use_Your_Chains__Buddy
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    public class UseYourChains
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var regex = new Regex(@"<p>(.+?)<\/p>");
            var matches = regex.Matches(text);
            var result = new StringBuilder();
            if (regex.IsMatch(text))
            {
                foreach (Match match in matches)
                {
                    var sentenceWithSpace = Regex.Replace(match.Groups[1].ToString(), "[^a-z0-9]", " ");
                    var sentence = Regex.Replace(sentenceWithSpace, @"\s+", " ");
                    foreach (var letter in sentence)
                    {
                        var currentElement = letter;
                        if (char.IsLetter(letter) && (int)letter < 110)
                        {
                            currentElement = (char) ((int) letter + 13);
                        }
                        else if (char.IsLetter(letter) && (int)letter >= 110)
                        {
                            currentElement = (char)((int)letter - 13);
                        }
                        result.Append(currentElement);
                    }                    
                }
            }
            Console.WriteLine(result);
        }
    }
}
