namespace Hell.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Text;
    using Hell.Interfaces;
    using Hell.Interfaces.Hero;
    using Hell.Models.Items;
    using Hell.Utilities;

    public class HeroManager : IManager
    {
        private Dictionary<string, IHero> heroes;

        public IDictionary<string, IHero> Heroes => this.heroes;

        public HeroManager()
        {
            this.heroes = new Dictionary<string, IHero>();
        }
    
        public string AddHero(IList<string> arguments)
        {
            string result = null;

            var heroName = arguments[0];
            var heroType = arguments[1];

            try
            {
                Type type = Assembly.GetExecutingAssembly().GetTypes()
                    .FirstOrDefault(t => t.Name.Equals(heroType, StringComparison.OrdinalIgnoreCase));
                var constructors = type.GetConstructors();
                IHero hero = (IHero)constructors[0].Invoke(new object[] { heroName });

                if (!this.heroes.ContainsKey(heroName))
                {
                    this.heroes.Add(heroName, hero);
                }

                result = string.Format($"Created {heroType} - {heroName}");
            }
            catch (Exception e)
            {
                return e.Message;
            }

            return result;
        }

        public string AddItemToHero(IList<string> arguments)
        {
            string result = null;

            var itemName = arguments[0];
            var heroName = arguments[1];
            var strengthBonus = int.Parse(arguments[2]);
            var agilityBonus = int.Parse(arguments[3]);
            var intelligenceBonus = int.Parse(arguments[4]);
            var hitPointsBonus = int.Parse(arguments[5]);
            var damageBonus = int.Parse(arguments[6]);

            CommonItem newItem = new CommonItem(itemName, strengthBonus, agilityBonus, intelligenceBonus, hitPointsBonus,
                damageBonus);

            this.heroes[heroName].Inventory.AddCommonItem(newItem);

            result = string.Format(Constants.ItemCreateMessage, newItem.Name, heroName);
            return result;
        }

        public string AddRecipeToHero(IList<string> arguments)
        {
            string result = null;

            var itemName = arguments[0];
            var heroName = arguments[1];
            var strengthBonus = int.Parse(arguments[2]);
            var agilityBonus = int.Parse(arguments[3]);
            var intelligenceBonus = int.Parse(arguments[4]);
            var hitPointsBonus = int.Parse(arguments[5]);
            var damageBonus = int.Parse(arguments[6]);
            var requiredItems = arguments.Skip(7).ToArray();

            RecipeItem newRecipe = new RecipeItem(
                itemName,
                strengthBonus,
                agilityBonus,
                intelligenceBonus,
                hitPointsBonus,
                damageBonus,
                requiredItems);

            this.heroes[heroName].Inventory.AddRecipeItem(newRecipe);

            result = string.Format(Constants.RecipeCreatedMessage, newRecipe.Name, heroName);
            return result;
        }
    
        public string Inspect(IList<string> arguments)
        {
            string heroName = arguments[0];

            return this.heroes[heroName].ToString();
        }

        public string Quit(IList<string> arguments)
        {
            var counter = 1;
            var result = new StringBuilder();
        
            foreach (var hero in this.heroes.Values.OrderByDescending(h => h.PrimaryStats).ThenByDescending(h => h.SecondaryStats))
            {
                result.AppendLine($"{counter}. {hero.GetType().Name}: {hero.Name}");
                result.AppendLine($"###HitPoints: {hero.HitPoints}");
                result.AppendLine($"###Damage: {hero.Damage}");
                result.AppendLine($"###Strength: {hero.Strength}");
                result.AppendLine($"###Agility: {hero.Agility}");
                result.AppendLine($"###Intelligence: {hero.Intelligence}");

                string items = hero.Items.Count == 0 ? "None" : string.Join(", ", hero.Items.Select(i => i.Name));
                result.AppendLine($"###Items: {items}");

                counter++;
            }

            return result.ToString().Trim();
        }
    }
}