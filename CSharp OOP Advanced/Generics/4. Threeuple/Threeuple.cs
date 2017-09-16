namespace _4.Threeuple
{
    public class Threeuple<T, V, U>
    {
        public T Item1 { get; private set; }
        public V Item2 { get; private set; }
        public U Item3 { get; private set; }

        public Threeuple()
        {
            this.Item1 = this.Item1;
            this.Item2 = this.Item2;
            this.Item3 = this.Item3;
        }

        public override string ToString()
        {
            return $"{this.Item1} -> {this.Item2} -> {this.Item3}";
        }
    }
}
