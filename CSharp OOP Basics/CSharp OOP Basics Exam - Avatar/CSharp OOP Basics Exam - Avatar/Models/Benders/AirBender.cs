﻿namespace CSharp_OOP_Basics_Exam___Avatar.Models.Benders
{
    public class AirBender : Bender
    {
        private double aerialIntegrity;

        public AirBender(string name, int power, double aerialIntegrity) 
            : base(name, power)
        {
            this.AerialIntegrity = aerialIntegrity;
        }

        public double AerialIntegrity
        {
            get { return this.aerialIntegrity; }
            set { this.aerialIntegrity = value; }
        }
    
        public override double GetBenderPower()
        {
            return this.Power * this.AerialIntegrity;
        }

        public override string ToString()
        {
            return $"###Air Bender: {this.Name}, Power: {this.Power}, Aerial Integrity: {this.AerialIntegrity:F2}";
        }
    }
}
