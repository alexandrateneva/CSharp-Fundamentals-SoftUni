namespace _8.Collection_Hierarchy.Models
{
    using _8.Collection_Hierarchy.Interfaces;

    public class AddRemoveCollection : Collection, IAdd, IRemove
    { 
        public string Remove()
        {
            var lastElement = this.elements[this.elements.Count - 1];
            this.elements.RemoveAt(this.elements.Count -1);
            return lastElement;
        }
    }
}
