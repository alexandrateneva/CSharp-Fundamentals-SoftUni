namespace _9.Text_Filter
{
    using System;

    public class TextFilter
    {
        public static void Main()
        {
            var words = Console.ReadLine()
                .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            var text = Console.ReadLine();

            foreach (var word in words)
            {
                var index = text.IndexOf(word);

                while (index != -1)
                {
                    text = text.Replace(word, new string('*', word.Length));
                    index = text.IndexOf(word);
                }
            }
            Console.WriteLine(text);
        }
    }
}
