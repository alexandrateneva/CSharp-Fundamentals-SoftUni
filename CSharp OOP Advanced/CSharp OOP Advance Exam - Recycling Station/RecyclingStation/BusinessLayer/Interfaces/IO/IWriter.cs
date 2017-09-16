namespace RecyclingStation.BusinessLayer.Interfaces.IO
{
    public interface IWriter
    {
        void StoreMessage(string message);

        void WriteOutput();
    }
}
