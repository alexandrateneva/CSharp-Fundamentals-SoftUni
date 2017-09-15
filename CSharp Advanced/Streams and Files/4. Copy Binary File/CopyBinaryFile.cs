namespace _4.Copy_Binary_File
{
    using System;
    using System.IO;

    public class CopyBinaryFile
    {
        public static void Main()
        {
            Console.Write("Choose a file path: ");
            var filePath = Console.ReadLine();

            using (var reader = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                using (var writer = new FileStream("../../image_copy.jpg", FileMode.Create, FileAccess.ReadWrite))
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
