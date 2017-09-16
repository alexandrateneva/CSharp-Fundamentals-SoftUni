namespace _7.Military_Elite.Interfaces
{
    public interface IMission
    {
        string CodeName { get; }
        string State { get; }
        void CompleteMission();
        bool IsValid();
    }
}
