namespace _2.King_s_Gambit.Models
{
    using System;

    public class RoyalGuard : Servant
    {
        public override void ServantWasKilled(King king)
        {
            this.TimesOfKill++;

            if (this.TimesOfKill == 3)
            {
                king.IsUnderAtack -= this.KingIsUnderAtack;
            }
        }

        public override void KingIsUnderAtack(object sender, EventArgs e)
        {
            if (sender is King king)
            {
                Console.WriteLine($"Royal Guard {this.Name} is defending!");
            }
        }
    }
}
