namespace _03.Parse_Tags___Lab
{
    using System;

    public class ParseTags
    {
       public static void Main()
        {
            var input = Console.ReadLine().Trim();
            var startIndex = input.IndexOf("<upcase>");

            while (startIndex > -1)
            {
                var endIndex = input.IndexOf("</upcase>");
                if (endIndex == -1)
                {
                    break;
                }
                var oldPart = input.Substring(startIndex, endIndex - startIndex + 9);
                var newPart = oldPart
                    .Replace("<upcase>", String.Empty)
                    .Replace("</upcase>", String.Empty)
                    .ToUpper();
                input = input.Replace(oldPart, newPart);

                startIndex = input.IndexOf("<upcase>");
            }

            Console.WriteLine(input);
        }
    }
}
