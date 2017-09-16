namespace Hell.Commands
{
    using System.Collections.Generic;
    using Hell.Interfaces;

    public abstract class AbstractCommand : IExecutable
    {
        public IList<string> Args { get; set; }
        public IManager Manager { get; set; }

        protected AbstractCommand(IList<string> args, IManager manager)
        {
            this.Args = args;
            this.Manager = manager;
        }

        public abstract string Execute();
    }
}
