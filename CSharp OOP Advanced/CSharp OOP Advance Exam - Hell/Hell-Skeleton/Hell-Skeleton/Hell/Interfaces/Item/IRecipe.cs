namespace Hell.Interfaces.Item
{
    using System.Collections.Generic;

    public interface IRecipe : IItem
    {
        IList<string> RequiredItems { get; }
    }
}
