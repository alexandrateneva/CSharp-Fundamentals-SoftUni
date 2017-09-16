namespace Hell.Commands
{
    using System.Collections.Generic;
    using Hell.Interfaces;

    public class RecipeCommand : AbstractCommand
    {
        public RecipeCommand(IList<string> args, IManager manager)
            : base(args, manager)
        {
        }

        public override string Execute()
        {
            return this.Manager.AddRecipeToHero(this.Args);
        }
    }
}
