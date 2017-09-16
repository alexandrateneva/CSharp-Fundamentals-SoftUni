namespace _6.Custom_Enum_Attribute.Attributes
{
    using System;

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Enum, AllowMultiple = true)]
    public class TypeAttribute : Attribute
    {
        public string Type { get; private set; }
        public string Category { get; private set; }
        public string Description { get; private set; }

        public TypeAttribute(string type, string category, string description)
        {
            this.Type = type;
            this.Category = category;
            this.Description = description;
        }
    }
}
