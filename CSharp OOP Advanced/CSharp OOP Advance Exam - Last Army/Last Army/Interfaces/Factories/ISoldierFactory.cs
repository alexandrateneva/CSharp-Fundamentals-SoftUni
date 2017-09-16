namespace Last_Army.Interfaces.Factories
{
    using Last_Army.Interfaces.Models;

    public interface ISoldierFactory
    {
        ISoldier CreateSoldier(string soldierTypeName, string name, int age, double experience, double endurance);
    }
}
