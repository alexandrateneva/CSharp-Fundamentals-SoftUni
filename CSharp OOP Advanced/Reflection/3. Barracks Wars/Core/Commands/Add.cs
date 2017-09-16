namespace _3.Barracks_Wars.Core.Commands
{
    using _3.Barracks_Wars.Interfaces;

    public class Add : Command
    {
        public IRepository Repository { get; private set; }
        public IUnitFactory UnitFactory { get; private set; }

        public Add(string[] data, IRepository repository, IUnitFactory unitFactory)
            : base(data)
        {
            this.Repository = repository;
            this.UnitFactory = unitFactory;
        }

        public override string Execute()
        {
            string unitType = this.Data[1];
            IUnit unitToAdd = this.UnitFactory.CreateUnit(unitType);
            this.Repository.AddUnit(unitToAdd);
            string output = unitType + " added!";
            return output;
        }
    }
}
