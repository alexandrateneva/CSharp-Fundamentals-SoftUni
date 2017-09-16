namespace Last_Army.Interfaces.Factories
{
    using Last_Army.Interfaces.Models;

    public interface IAmmunitionFactory
    {
        IAmmunition CreateAmmunition(string ammunitionName);
    }
}