namespace _6.Equality_Logic
{
    using System;

    public class Person : IComparable<Person>
    {
        public string Name { get; private set; }
        public int Age { get; private set; }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public int CompareTo(Person other)
        {
            var nameCompare = this.Name.CompareTo(other.Name);
            if (nameCompare != 0)
            {
                return nameCompare;
            }
            return this.Age.CompareTo(other.Age);
        }

        public override bool Equals(object other)
        {
            var y = other as Person;
            return this.Name == y.Name && this.Age == y.Age;
        }

        public override int GetHashCode()
        {
            var hashCode = this.Name.Length * 10000;
            foreach (var letter in this.Name)
            {
                hashCode += letter;
            }
            hashCode += this.Age * 10000000;

            return hashCode;
        }
    }
}
