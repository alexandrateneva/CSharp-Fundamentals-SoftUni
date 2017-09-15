namespace _5.Slicing_File
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class SlicingFile
    {
        public static void Main()
        {

            Console.Write("Choose a file path for slice option: ");
            var filePath = Console.ReadLine().Trim();
            Console.Write("Parts: ");
            var parts = int.Parse(Console.ReadLine().Trim());
            Slice(filePath, parts);


            Console.Write("Do you want to assemble back the files?  ");
            ANSWER: var answer = Console.ReadLine().Trim().ToLower();
            var files = new List<string>();
            if (answer == "yes")
            {
                files = Directory.GetFiles("../../parts").ToList();
                Assemble(files);
            }
            else if (answer == "no")
            {
                Console.WriteLine("Ok, have a nice day :)");
            }
            else
            {
                Console.WriteLine("You have to choose between yes or no.");
                goto ANSWER;
            }
        }

        public static void Slice(string filePath, int parts)
        {
            var dir = new DirectoryInfo("../../parts");
            foreach (var file in dir.GetFiles())
            {
                file.Delete();
            }
            using (var reader = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                for (int i = 0; i < parts; i++)
                {
                    using (var writer = new FileStream($"../../parts/part-{i}.txt", FileMode.Create, FileAccess.ReadWrite))
                    {
                        var partsSize = reader.Length / parts + reader.Length % parts;
                        var buffer = new byte[partsSize];
                        var readBytes = reader.Read(buffer, 0, buffer.Length);
                        writer.Write(buffer, 0, readBytes);
                    }
                }

            }
        }

        public static void Assemble(List<string> files)
        {
            var writer = new FileStream("../../assembled.txt", FileMode.Create, FileAccess.ReadWrite);
            writer.Close();
            using (writer = new FileStream("../../assembled.txt", FileMode.Append))
            {
                foreach (var file in files)
                {
                    using (var reader = new FileStream(file, FileMode.Open, FileAccess.Read))
                    {
                        var buffer = new byte[4096];
                        int readBytes;

                        while ((readBytes = reader.Read(buffer, 0, buffer.Length)) != 0)
                        {
                            writer.Write(buffer, 0, readBytes);
                        }
                    }
                }
            }
        }
    }
}

