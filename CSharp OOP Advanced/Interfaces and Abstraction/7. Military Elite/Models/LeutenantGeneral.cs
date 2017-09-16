namespace _7.Military_Elite.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using _7.Military_Elite.Interfaces;

    public class LeutenantGeneral : Private, ILeutenantGeneral
    {
        public List<IPrivate> Privates { get; }

        public LeutenantGeneral(string id, string firstName, string lastName, double salary)
            : base(id, firstName, lastName, salary)
        {
            this.Privates = new List<IPrivate>();
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.Append("Privates:");
            if (this.Privates.Count > 0)
            {
                sb.AppendLine();
                sb.Append($"{"  " + string.Join(Environment.NewLine + "  ", this.Privates)}");
            }

            return sb.ToString();

        }
    }
}
