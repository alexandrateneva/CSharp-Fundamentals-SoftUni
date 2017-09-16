namespace _3.Froggy
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class Lake : IEnumerable<int>
    {
        private readonly List<int> stones;

        public Lake(List<int> stones)
        {
            this.stones = stones;
        }

        public IEnumerator<int> GetEnumerator()
        {
            var orderedNumbers = this.stones.Where((s, i) => i % 2 == 0).ToList();
            orderedNumbers.AddRange(this.stones.Where((s, i) => i % 2 != 0).Reverse());
            for (int i = 0; i < orderedNumbers.Count; i++)
            {
                yield return orderedNumbers[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
