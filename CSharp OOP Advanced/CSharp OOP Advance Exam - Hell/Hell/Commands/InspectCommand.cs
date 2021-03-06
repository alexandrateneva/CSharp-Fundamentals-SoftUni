﻿namespace Hell.Commands
{
    using System.Collections.Generic;
    using Hell.Interfaces;

    public class InspectCommand : AbstractCommand
    {
        public InspectCommand(IList<string> args, IManager manager) 
            : base(args, manager)
        {
        }

        public override string Execute()
        {
            return this.Manager.Inspect(this.Args);
        }
    }
}
