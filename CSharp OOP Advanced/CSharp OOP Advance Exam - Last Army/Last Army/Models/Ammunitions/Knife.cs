namespace Last_Army.Models.Ammunitions
{
    public class Knife : Ammunition
    {
        public const double WeightValue = 0.4;

        public Knife(string name)
            : base(name, WeightValue)
        {
        }
    }
}