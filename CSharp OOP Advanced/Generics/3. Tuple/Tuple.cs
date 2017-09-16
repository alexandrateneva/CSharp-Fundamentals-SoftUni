namespace _3.Tuple
{
    public class Tuple<T, V>
    { 
        public V Item2 { get; private set; }
        public T Item1 { get; private set; }

        public Tuple()
        {
            this.Item1 = this.Item1;
            this.Item2 = this.Item2;
        }
        
        public override string ToString()
        {
            return $"{this.Item1} -> {this.Item2}";
        }
    }
}
