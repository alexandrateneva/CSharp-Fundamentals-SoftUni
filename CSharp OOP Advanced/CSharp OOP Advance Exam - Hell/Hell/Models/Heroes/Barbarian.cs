namespace Hell.Models.Heroes
{
    public class Barbarian : AbstractHero
    {
        public const int Strength = 90;
        public const int Agility = 25;
        public const int Intelligence = 10;
        public const int HitPoints = 350;
        public const int Damage = 150;

        public Barbarian(string name)
            : base(name, Strength, Agility, Intelligence, HitPoints, Damage)
        {
        }
    }
}