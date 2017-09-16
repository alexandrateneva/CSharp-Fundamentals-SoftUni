namespace Hell.IO
{
    using System;
    using Hell.Interfaces.IO;

    public class InputReader : IInputReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}