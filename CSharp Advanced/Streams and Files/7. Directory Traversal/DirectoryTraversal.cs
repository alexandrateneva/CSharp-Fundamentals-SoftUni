namespace _7.Directory_Traversal
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class DirectoryTraversal
    {
        public static void Main()
        {
            Console.Write("Choose a directory: ");
            var dirPath = Console.ReadLine().Trim();

            var sortedFiles = new Dictionary<string, Dictionary<string, double>>();

            var dir = new DirectoryInfo(dirPath);
            var files = dir.GetFiles();

            foreach (var file in files)
            {
                var fileExt = file.Extension;
                var fileName = file.Name;
                var fileSize = file.Length;
                var fileSizeKB = fileSize / 1024.0; ;

                if (!sortedFiles.ContainsKey(fileExt))
                {
                    sortedFiles.Add(fileExt, new Dictionary<string, double>());
                }
                sortedFiles[fileExt].Add(fileName, fileSizeKB);

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
