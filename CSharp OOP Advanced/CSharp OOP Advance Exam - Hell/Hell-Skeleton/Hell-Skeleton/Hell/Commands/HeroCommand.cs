namespace Hell.Commands
{
    using System.Collections.Generic;
    using Hell.Interfaces;

    public class HeroCommand : AbstractCommand
    {
        public HeroCommand(IList<string> args, IManager manager)
            : base(args, manager)
        {
        }

        public override string Execute()
        {
            return this.Manager.AddHero(this.Args);
        }
    }
}
