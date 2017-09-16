namespace _2.Stack
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;

    public class Stack<T> : IEnumerable<T>
    {
        private int currentIndex = 0;
        private readonly Collection<T> stack;

        public Stack()
        {
            this.stack = new Collection<T>();
        }

        public void Push(List<T> elements)
        {
            foreach (var element in elements)
            {
                this.stack.Add(element);
            }
        }

        public void Pop()
        {
            if (!this.stack.Any())
            {
                throw new ArgumentException("No elements");
            }
            this.stack.RemoveAt(this.stack.Count - 1);
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = this.stack.Count - 1; i >= 0; i--)
            {
                yield return this.stack[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
