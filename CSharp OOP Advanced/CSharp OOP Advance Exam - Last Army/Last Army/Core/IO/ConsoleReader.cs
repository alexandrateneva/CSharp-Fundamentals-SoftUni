namespace Last_Army.Core.IO
{
    using System;
    using Last_Army.Interfaces.IO;

    public class ConsoleReader : IReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}