namespace CSharp_OOP_Basics_Exam___Avatar.Models.Monuments
{
    public class WaterMonument : Monument
    {
        private int waterAffinity;

        public WaterMonument(string name, int waterAffinity)
            : base(name)
        {
            this.WaterAffinity = waterAffinity;
        }

        public int WaterAffinity
        {
            get { return this.waterAffinity; }
            set { this.waterAffinity = value; }
        }

        public override string ToString()
        {
            return $"###Water Monument: {this.Name}, Water Affinity: {this.WaterAffinity}";
        }

        public override double GetAffinity()
        {
            return this.WaterAffinity;
        }
    }
}