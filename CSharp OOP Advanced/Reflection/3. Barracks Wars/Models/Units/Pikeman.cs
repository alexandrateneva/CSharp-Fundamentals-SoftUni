namespace _3.Barracks_Wars.Models.Units
{
    public class Pikeman : Unit
    {
        private const int DefaultHealth = 30;
        private const int DefaultDamage = 15;

        public Pikeman() 
            : base(DefaultHealth, DefaultDamage)
        {
        }
    }
}
