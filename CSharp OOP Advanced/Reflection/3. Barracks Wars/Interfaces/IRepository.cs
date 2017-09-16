namespace _3.Barracks_Wars.Interfaces
{
    public interface IRepository
    {
        void AddUnit(IUnit unit);
        string Statistics { get; }
        string RemoveUnit(string unitTypeName);
    }
}
