namespace _6.Count_Substring_Occurrences
{
    using System;

    public class CountSubstringOccurrences
    {
        public static void Main()
        {
            var input = Console.ReadLine().ToLower();
            var word = Console.ReadLine().ToLower();
            var index = input.IndexOf(word);
            var counter = 0;
            while (index > -1)
            {
                counter++;
                input = input.Remove(index, 1);
                index = input.IndexOf(word);
            }
            Console.WriteLine(counter);
        }
    }
}
