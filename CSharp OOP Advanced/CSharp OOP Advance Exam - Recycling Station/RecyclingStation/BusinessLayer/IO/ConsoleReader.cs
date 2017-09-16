namespace RecyclingStation.BusinessLayer.IO
{
    using System;
    using RecyclingStation.BusinessLayer.Interfaces.IO;

    public class ConsoleReader : IReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
