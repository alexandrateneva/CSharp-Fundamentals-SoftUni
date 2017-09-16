namespace RecyclingStation.BusinessLayer.IO
{
    using System;
    using System.Text;
    using RecyclingStation.BusinessLayer.Interfaces.IO;

    public class ConsoleWriter : IWriter
    {
        public ConsoleWriter()
            : this(new StringBuilder())
        {
        }

        public ConsoleWriter(StringBuilder output)
        {
            this.FinalOutput = output;
        }

        public StringBuilder FinalOutput { get; private set; }

        public void StoreMessage(string message)
        {
            this.FinalOutput.AppendLine(message);
        }

        public void WriteOutput()
        {
            Console.Write(this.FinalOutput);
        }
    }
}
