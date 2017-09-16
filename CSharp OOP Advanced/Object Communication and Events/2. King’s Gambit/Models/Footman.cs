namespace _2.King_s_Gambit.Models
{
    using System;

    public class Footman : Servant
    {
        public override void ServantWasKilled(King king)
        {
            this.TimesOfKill++;

            if (this.TimesOfKill == 2)
            {
                king.IsUnderAtack -= this.KingIsUnderAtack;
            }
        }

        public override void KingIsUnderAtack(object sender, EventArgs e)
        {
            if (sender is King king)
            {
                Console.WriteLine($"Footman {this.Name} is panicking!");
            }
        }
    }
}