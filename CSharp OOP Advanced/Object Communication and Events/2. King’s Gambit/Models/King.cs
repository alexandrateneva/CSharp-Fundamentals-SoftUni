namespace _2.King_s_Gambit.Models
{
    using System;

    public class King
    {
        public string Name { get; set; }

        public event EventHandler IsUnderAtack;

        public void StartAtack()
        {
            this.IsUnderAtack?.Invoke(this, EventArgs.Empty);
        }
    }
}
