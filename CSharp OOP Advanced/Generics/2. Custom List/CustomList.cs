namespace _2.Custom_List
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class CustomList<T> : IEnumerable<T>
        where T : IComparable
    {
        private readonly List<T> data;

        public CustomList()
            : this(Enumerable.Empty<T>())
        {
            this.data = new List<T>();
        }

        public CustomList(IEnumerable<T> collection)
        {
            this.data = new List<T>(collection);
        }

        public List<T> Data { get => this.data; }

        public void Add(T element)
        {
            this.data.Add(element);
        }

        public T Remove(int index)
        {
            var currentElement = this.data[index];
            this.data.RemoveAt(index);
            return currentElement;
        }

        public bool Contains(T element)
        {
            if (this.data.Contains(element))
            {
                return true;
            }
            return false;
        }

        public void Swap(int index1, int index2)
        {
            var element1 = this.data[index1];
            this.data[index1] = this.data[index2];
            this.data[index2] = element1;
        }

        public int CountGreaterThan(T elementToCompare)
        {
            return this.data.Count(x => x.CompareTo(elementToCompare) > 0);
        }

        public T Max()
        {
            return this.data.Max();
        }

        public T Min()
        {
            return this.data.Min();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this.data.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
