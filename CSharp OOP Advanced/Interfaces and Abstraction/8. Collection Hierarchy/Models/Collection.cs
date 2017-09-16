namespace _8.Collection_Hierarchy.Models
{
    using System.Collections.Generic;
    using _8.Collection_Hierarchy.Interfaces;

    public abstract class Collection : IAdd
    {
        protected List<string> elements;

        protected Collection()
        {
            this.elements = new List<string>(100);
        }

        public virtual int Add(string element)
        {
            this.elements.Insert(0, element);
            return 0;
        }

    }
}
