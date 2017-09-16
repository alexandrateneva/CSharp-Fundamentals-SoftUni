namespace _3.Barracks_Wars.Core.Commands
{
    using System;

    public class Fight : Command
    {
        public override string Execute()
        {
            Environment.Exit(0);
            return string.Empty;
        }
    }
}
