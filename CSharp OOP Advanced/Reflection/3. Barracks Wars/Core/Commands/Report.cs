namespace _3.Barracks_Wars.Core.Commands
{
    using _3.Barracks_Wars.Interfaces;

    public class Report : Command
    {
        public IRepository Repository { get; private set; }

        public Report(string[] data, IRepository repository)
            : base(data)
        {
            this.Repository = repository;
        }
        
        public override string Execute()
        {
            string output = this.Repository.Statistics;
            return output;
        }
    }
}
