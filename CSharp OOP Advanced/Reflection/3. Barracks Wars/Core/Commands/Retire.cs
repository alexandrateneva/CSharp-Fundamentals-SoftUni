namespace _3.Barracks_Wars.Core.Commands
{
    using _3.Barracks_Wars.Interfaces;

    public class Retire : Command
    {
        public IRepository Repository { get; private set; }

        public Retire(string[] data, IRepository repository)
            : base(data)
        {
            this.Repository = repository;
        }

        public override string Execute()
        {
            string unitType = this.Data[1];
            return this.Repository.RemoveUnit(unitType);
        }
    }
}
