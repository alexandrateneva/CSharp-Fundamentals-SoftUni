namespace Hell.IO
{
    using System;
    using System.Text;
    using Hell.Interfaces.IO;

    public class OutputWriter : IOutputWriter
    {
        private readonly StringBuilder content;

        public OutputWriter()
            : this(new StringBuilder())
        {

        }

        public OutputWriter(StringBuilder content)
        {
            this.content = content;
        }

        public void AppendLine(string line)
        {
            this.content.AppendLine(line);
        }

        public void Write()
        {
            Console.Write(this.content.ToString());
        }
    }
}