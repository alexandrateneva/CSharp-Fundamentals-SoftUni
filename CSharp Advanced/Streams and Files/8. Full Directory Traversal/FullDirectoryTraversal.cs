namespace _8.Full_Directory_Traversal
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class FullDirectoryTraversal
    {
        public static void Main()
        {
            Console.Write("Choose a directory: ");
            var dirPath = Console.ReadLine().Trim();

            var sortedFiles = new Dictionary<string, Dictionary<string, double>>();
            var equalsFiles = new Dictionary<string, int>();

            foreach (string file in Directory.EnumerateFiles(dirPath, "*.*", SearchOption.AllDirectories))
            {
                var fileExt = Path.GetExtension(file);
                var fileName = Path.GetFileName(file);
                var fileSize = file.Length;
                var fileSizeKB = fileSize / 1024.0;


                if (!sortedFiles.ContainsKey(fileExt))
                {
                    sortedFiles.Add(fileExt, new Dictionary<string, double>());
                    sortedFiles[fileExt].Add(fileName, fileSizeKB);
                }
                else
                {
                    if (!sortedFiles[fileExt].ContainsKey(fileName))
                    {
                        sortedFiles[fileExt].Add(fileName, fileSizeKB);
                    }
                    else
                    {
                        if (!equalsFiles.ContainsKey(fileName))
                        {
                            equalsFiles.Add(fileName, 1);
                        }
                        else
                        {
                            equalsFiles[fileName]++;
                        }
                        var newName = string.Concat(fileName, $"({equalsFiles[fileName]})");
                        sortedFiles[fileExt].Add(newName, fileSizeKB);
                    }
                }
            }

            var strPath = Environment.GetFolderPath(System.Environment.SpecialFolder.DesktopDirectory);
            using (var writer = new StreamWriter($"{strPath}//report.txt"))
            {
                foreach (var ext in sortedFiles.OrderByDescending(n => n.Value.Count).ThenBy(n => n.Key))
                {
                    writer.WriteLine(ext.Key);
                    foreach (var file in sortedFiles[ext.Key].OrderBy(n => n.Value))
                    {
                        writer.WriteLine($"--{file.Key} - {file.Value:0.000} kb");
                    }
                }
            }
        }
    }
}

