namespace Hell.Models.Items
{
    using System.Text;
    using Hell.Interfaces.Item;

    public abstract class AbstractItem : IItem
    {
        protected AbstractItem(
            string name,
            int strengthBonus,
            int agilityBonus,
            int intelligenceBonus,
            int hitPointsBonus,
            int damageBonus)
        {
            this.Name = name;
            this.StrengthBonus = strengthBonus;
            this.AgilityBonus = agilityBonus;
            this.IntelligenceBonus = intelligenceBonus;
            this.HitPointsBonus = hitPointsBonus;
            this.DamageBonus = damageBonus;
        }

        public string Name { get; private set; }

        public int StrengthBonus { get; private set; }

        public int AgilityBonus { get; private set; }

        public int IntelligenceBonus { get; private set; }

        public int HitPointsBonus { get; private set; }

        public int DamageBonus { get; private set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine($"###Item: {this.Name}");
            result.AppendLine($"###+{this.StrengthBonus} Strength");
            result.AppendLine($"###+{this.AgilityBonus} Agility");
            result.AppendLine($"###+{this.IntelligenceBonus} Intelligence");
            result.AppendLine($"###+{this.HitPointsBonus} HitPoints");
            result.AppendLine($"###+{this.DamageBonus} Damage");

            return result.ToString().Trim();
        }
    }
}
