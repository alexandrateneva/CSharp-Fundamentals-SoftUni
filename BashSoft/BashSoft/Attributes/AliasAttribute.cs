namespace BashSoft.Attributes
{
    using System;

    [AttributeUsage(AttributeTargets.Class)]
    public class AliasAttribute : Attribute
    {
        private string name;

        public AliasAttribute(string aliasname) => this.name = aliasname;

        public string Name => this.name;

        public override bool Equals(object obj) => this.Name.Equals(obj);

        public override int GetHashCode() => base.GetHashCode();
    }
}
