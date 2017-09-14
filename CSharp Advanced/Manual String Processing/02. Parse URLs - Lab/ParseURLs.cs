namespace _02.Parse_URLs___Lab
{
    using System;

    public class ParseURLs
    {
        public static void Main()
        {
            var input = Console.ReadLine().Trim();
            var indexProt = input.IndexOf("://");
            if (indexProt == -1)
            {
                Console.WriteLine("Invalid URL");
                return;
            }
            var protocol = input.Substring(0, indexProt);
            input = input.Remove(0, protocol.Length + 3);
            if (input.IndexOf("://") > -1 || input.IndexOf("/") == -1)
            {
                Console.WriteLine("Invalid URL");
                return;
            }
            var indexServer = input.IndexOf("/");
            var server = input.Substring(0, indexServer);
            input = input.Remove(0, server.Length + 1);

            Console.WriteLine($"Protocol = {protocol}");
            Console.WriteLine($"Server = {server}");
            Console.WriteLine($"Resources = {input}");
        }
    }
}
