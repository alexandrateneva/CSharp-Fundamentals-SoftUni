namespace Hell.Models.Heroes
{
    public class Assassin : AbstractHero
    {
        public const int Strength = 25;
        public const int Agility = 100;
        public const int Intelligence = 15;
        public const int HitPoints = 150;
        public const int Damage = 300;

        public Assassin(string name)
            : base(name, Strength, Agility, Intelligence, HitPoints, Damage)
        {
        }
    }
}
