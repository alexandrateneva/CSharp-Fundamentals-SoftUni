namespace _3.Barracks_Wars.Core.Commands
{
    using _3.Barracks_Wars.Interfaces;

    public abstract class Command : IExecutable
    {
        public string[] Data { get; private set; }

        public Command()
        {
        }

        public Command(string[] data)
        {
            this.Data = data;
        }

        public abstract string Execute();
    }
}
