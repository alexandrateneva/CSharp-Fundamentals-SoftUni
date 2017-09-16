namespace Hell.Interfaces.IO
{
    public interface IOutputWriter
    {
        void Write();

        void AppendLine(string text);
    }
}
