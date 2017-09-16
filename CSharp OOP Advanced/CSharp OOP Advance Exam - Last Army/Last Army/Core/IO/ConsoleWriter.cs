namespace Last_Army.Core.IO
{
    using System;
    using System.Text;
    using Last_Army.Interfaces.IO;

    public class ConsoleWriter : IWriter
    {
        private StringBuilder sb;

        public ConsoleWriter()
        {
            this.sb = new StringBuilder();
        }

        public string StoredMessage
        {
            get => this.sb.ToString();
        }

        public void WriteLine(string output)
        {
            Console.WriteLine(output);
        }

        public void StoreMessage(string message)
        {
            this.sb.AppendLine(message.Trim());
        }
    }
}