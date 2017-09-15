﻿namespace _2.Line_Numbers
{
    using System;
    using System.IO;

    public class LineNumbers
    {
        public static void Main()
        {
            Console.Write("Choose a file path: ");
            var filePath = Console.ReadLine();

            using (var reader = new StreamReader(filePath))
            using (var writer = new StreamWriter("../../result.txt"))
            {
                var readLine = "";
                var counter = 1;
                while ((readLine = reader.ReadLine()) != null)
                {
                    writer.WriteLine($"{counter}. {readLine}");
                    counter++;
                }
            }
        }
    }
}
