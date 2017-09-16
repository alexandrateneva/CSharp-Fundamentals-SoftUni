namespace Hell.Commands
{
    using System.Collections.Generic;
    using Hell.Interfaces;

    public class QuitCommand : AbstractCommand
    {
        public QuitCommand(IList<string> args, IManager manager) 
            : base(args, manager)
        {
        }

        public override string Execute()
        {
            return this.Manager.Quit(this.Args);
        }
    }
}