namespace _1.Generic_Box
{
    using System;

    public class Box<T>
        where T : IComparable
    {
        public T Data { get; set; }

        public Box(T data)
        {
            this.Data = data;
        }

        public int CompareTo(Box<T> otherBox)
        {
            return this.Data.CompareTo(otherBox.Data);
        }

        public override string ToString()
        {
            return $"{this.Data.GetType().FullName}: {this.Data}";
        }
    }
}
