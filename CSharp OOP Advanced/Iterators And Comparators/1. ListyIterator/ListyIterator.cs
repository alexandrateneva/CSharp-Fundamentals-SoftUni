namespace _1.ListyIterator
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class ListyIterator<T> : IEnumerable<T>
    {
        private int currentIndex;
        private readonly List<T> list;

        public ListyIterator()
        {
            this.list = new List<T>();
        }

        public ListyIterator(List<T> list)
        {
            this.list = list;
        }

        public bool Move()
        {
            if (this.HasNext())
            {
                this.currentIndex++;
                return true;
            }
            return false;
        }

        public bool HasNext()
        {
            if (this.currentIndex < this.list.Count - 1)
            {
                return true;
            }
            return false;
        }

        public void Print()
        {
            if (!this.list.Any())
            {
                throw new ArgumentException("Invalid Operation!");
            }
            Console.WriteLine(this.list[this.currentIndex]);
        }

        public void PrintAll()
        {
            Console.WriteLine(string.Join(" ", this.list));
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.list.Count; i++)
            {
                yield return this.list[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
