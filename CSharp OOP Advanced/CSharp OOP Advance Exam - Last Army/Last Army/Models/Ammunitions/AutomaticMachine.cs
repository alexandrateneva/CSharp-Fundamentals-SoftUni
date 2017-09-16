namespace Last_Army.Models.Ammunitions
{
    public class AutomaticMachine : Ammunition
    {
        public const double WeightValue = 6.3;

        public AutomaticMachine(string name)
            : base(name, WeightValue)
        {
        }
    }
}