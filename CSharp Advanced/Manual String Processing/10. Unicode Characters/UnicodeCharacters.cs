namespace _10.Unicode_Characters
{
    using System;
    using System.Text;

    public class UnicodeCharacters
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var result = new StringBuilder();
            foreach (var symbol in input)
            {
                result.Append("\\u");
                result.Append($"{(int)symbol:x4}");
            }
            Console.WriteLine(result);
        }
    }
}
