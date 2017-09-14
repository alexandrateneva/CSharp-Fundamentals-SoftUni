namespace _03.Count_Uppercase_Words
{
    using System;

    public class CountUppercaseWords
    {
        public static void Main()
        {
            var words = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var word in words)
            {
                if (char.IsUpper(word[0]))
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}
