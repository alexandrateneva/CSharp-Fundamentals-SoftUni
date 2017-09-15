namespace _6.Zipping_Sliced_Files
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.IO.Compression;
    using System.Linq;

    public class ZippingSlicedFiles
    {
        public static void Main()
        {
            Console.Write("Choose a file path for slice and compress option: ");
            var filePath = Console.ReadLine().Trim();
            Console.Write("Parts: ");
            var parts = int.Parse(Console.ReadLine().Trim());
            Slice(filePath, parts);


            Console.Write("Do you want to assemble back and decompress the files?  ");
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
            foreach (var subDir in dir.GetDirectories())
            {
                dir.Delete(true);
            }
            using (var reader = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                for (int i = 0; i < parts; i++)
                {
                    using (var writer = new FileStream($"../../parts/part-{i}.gz", FileMode.Create))
                    {
                        using (var comressStream = new GZipStream(writer, CompressionMode.Compress))
                        {
                            var partsSize = reader.Length / parts + reader.Length % parts;
                            var buffer = new byte[partsSize];
                            var readBytes = reader.Read(buffer, 0, buffer.Length);
                            comressStream.Write(buffer, 0, readBytes);
                        }
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
                        using (var decomressStream = new GZipStream(reader, CompressionMode.Decompress, false))
                        {

                            var buffer = new byte[4096];
                            int readBytes;

                            while ((readBytes = decomressStream.Read(buffer, 0, buffer.Length)) != 0)
                            {
                                writer.Write(buffer, 0, readBytes);
                            }
                        }
                    }
                }
            }
        }
    }
}
