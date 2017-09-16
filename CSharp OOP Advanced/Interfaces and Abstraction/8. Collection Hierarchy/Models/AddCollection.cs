namespace _8.Collection_Hierarchy.Models
{
    public class AddCollection : Collection
    {
        public override int Add(string element)
        {
            this.elements.Add(element);
            return this.elements.Count - 1;
        }
    }
}
