namespace Database_Problems
{
    using System;

    public class Database
    {
        private int[] numbers;
        private int count;

        public Database(params int[] numbersByConstr)
        {
            if (numbersByConstr.Length > 16 || numbersByConstr.Length < 16)
            {
                throw new InvalidOperationException("Storing array's capacity must be exactly 16 integers.");
            }
            this.numbers = new int[16];
            for (int i = 0; i < 16; i++)
            {
                this.numbers[i] = numbersByConstr[i];
            }
            this.count = 16;
        }

        public int Count => this.count;

        public void Add(int element)
        {
            if (this.count >= 16)
            {
                throw new InvalidOperationException("Database is full yet.");
            }
            this.numbers[this.count] = element;
            this.count++;
        }

        public void Remove()
        {
            if (this.count < 1)
            {
                throw new InvalidOperationException("Database is empty.");
            }
            this.numbers[this.count - 1] = default(int);
            this.count--;
        }

        public int[] Fetch()
        {
            var result = new int[this.count];
            for (int i = 0; i < this.count; i++)
            {
                result[i] = this.numbers[i];
            }
            return result;
        }
    }
}
