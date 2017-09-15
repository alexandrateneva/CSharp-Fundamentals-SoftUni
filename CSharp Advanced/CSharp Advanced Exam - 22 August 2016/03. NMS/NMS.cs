namespace _03.NMS
{
    using System;
    using System.Text;

    public class NMS
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();
            var text = new StringBuilder();
            while (inputLine != "---NMS SEND---")
            {
                text.Append(inputLine);
                inputLine = Console.ReadLine();
            }
            var delimiter = Console.ReadLine();
            var textAsStr = text.ToString();
            var counter = 0;
            for (int i = 0; i < textAsStr.Length - 1; i++)
            {
                var firstLetter = textAsStr[i].ToString();
                var secondLetter = textAsStr[i + 1].ToString();
                if (string.Compare(firstLetter, secondLetter, StringComparison.CurrentCultureIgnoreCase) > 0)
                {
                    text.Insert(i + counter + 1, delimiter);
                    counter += delimiter.Length;
                }
            }
            Console.WriteLine(text);
        }
    }
}
