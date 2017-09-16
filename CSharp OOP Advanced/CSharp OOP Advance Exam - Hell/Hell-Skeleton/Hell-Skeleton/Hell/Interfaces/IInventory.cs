namespace Hell.Interfaces
{
    using Hell.Interfaces.Item;

    public interface IInventory
    {
        long TotalStrengthBonus { get; }

        long TotalAgilityBonus { get; }

        long TotalIntelligenceBonus { get; }

        long TotalHitPointsBonus { get; }

        long TotalDamageBonus { get; }

        void AddCommonItem(IItem item);

        void AddRecipeItem(IRecipe recipe);
    }
}
