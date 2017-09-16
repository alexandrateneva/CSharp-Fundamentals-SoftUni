namespace _3.Barracks_Wars.Core.Factories
{
    using System;
    using _3.Barracks_Wars.Interfaces;

    public class UnitFactory : IUnitFactory
    {
        public IUnit CreateUnit(string unitType)
        {
            Type type = Type.GetType($"_03BarracksFactory.Models.Units.{unitType}");

            var unit = (IUnit)Activator.CreateInstance(type);

            return unit;
        }
    }
}
