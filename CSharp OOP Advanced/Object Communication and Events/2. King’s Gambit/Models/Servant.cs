namespace _2.King_s_Gambit.Models
{
    using System;

    public abstract class Servant
    {
        public string Name { get; set; }
        public int TimesOfKill { get; set; }

        public void HelpToTheKing(King king)
        {
            king.IsUnderAtack += this.KingIsUnderAtack;
        }

        public abstract void ServantWasKilled(King king);

        public abstract void KingIsUnderAtack(object sender, EventArgs e);
    }
}