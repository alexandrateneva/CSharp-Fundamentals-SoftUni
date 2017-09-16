namespace Last_Army.Models.Soldiers.Factory
{
    using System;
    using System.Linq;
    using System.Reflection;
    using Last_Army.Interfaces.Factories;
    using Last_Army.Interfaces.Models;

    public class SoldierFactory : ISoldierFactory
    {
        public ISoldier CreateSoldier(string soldierTypeName, string name, int age, double experience, double endurance)
        {
            Type soldierType = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .FirstOrDefault(t => t.Name == soldierTypeName);

            return (ISoldier) Activator.CreateInstance(soldierType, name, age, experience, endurance);
        }
    }
}