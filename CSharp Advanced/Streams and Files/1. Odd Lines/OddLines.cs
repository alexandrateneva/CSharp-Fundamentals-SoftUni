namespace _1.Odd_Lines
{
    using System;
    using System.IO;

    public class OddLines
    {
        public static void Main()
        {
            Console.Write("Choose a file path: ");
            var filePath = Console.ReadLine();

            using (var reader = new StreamReader(filePath))
            {
                var readLine = "";
                var counter = 0;
                while ((readLine = reader.ReadLine()) != null)
                {
                    if (counter % 2 != 0)
                    {
                        Console.WriteLine(readLine);
                    }
                    counter++;
                }
            }
        }
    }
}
