namespace Hell.Models.Heroes
{
    public class Wizard : AbstractHero
    {
        public const int Strength = 25;
        public const int Agility = 25;
        public const int Intelligence = 100;
        public const int HitPoints = 100;
        public const int Damage = 250;

        public Wizard(string name)
            : base(name, Strength, Agility, Intelligence, HitPoints, Damage)
        {
        }
    }
}
