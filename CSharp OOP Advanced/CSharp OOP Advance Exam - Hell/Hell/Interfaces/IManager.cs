namespace Hell.Interfaces
{
    using System.Collections.Generic;
    using Hell.Interfaces.Hero;

    public interface IManager
    {
        IDictionary<string, IHero> Heroes { get; }

        string AddHero(IList<string> arguments);

        string AddItemToHero(IList<string> arguments);

        string Inspect(IList<string> arguments);

        string AddRecipeToHero(IList<string> arguments);

        string Quit(IList<string> arguments);
    }
}