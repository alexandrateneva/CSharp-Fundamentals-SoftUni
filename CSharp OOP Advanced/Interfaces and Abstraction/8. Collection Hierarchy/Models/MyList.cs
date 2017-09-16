namespace _8.Collection_Hierarchy.Models
{
    using _8.Collection_Hierarchy.Interfaces;

    public class MyList : Collection, IRemove
    { 
        public string Remove()
        {
            var lastElement = this.elements[0];
            this.elements.RemoveAt(0);
            return lastElement;
        }

        public int GetAmount()
        {
            return this.elements.Count;
        }
    }
}
